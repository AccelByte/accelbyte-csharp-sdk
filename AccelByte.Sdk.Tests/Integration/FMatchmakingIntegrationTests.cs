// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Tests.Integration
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class FMatchmakingIntegrationTests : BaseIntegrationTest
    {
        private string _GameModePrefix = "csharp_sdk_gm_";

        [OneTimeSetUp]
        public void Startup()
        {
            HttpClientPolicy policy = HttpClientPolicy.Default;
            policy.MaxRetryCount = 1000;
            policy.RetryInterval = 1000;
            policy.RetryLogicHandler = new ResponseCodeCheckLogicHandler("425");

            _Sdk = AccelByteSDK.Builder
                .SetHttpClient(ReliableHttpClient.Builder
                    .SetDefaultPolicy(policy)
                    .Build())
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseInMemoryTokenRepository()
                .SetCredentialRepository(IntegrationTestCredentialRepository.Admin)
                .EnableLog()
                .Build();

            _Sdk.LoginUser();
        }

        [OneTimeTearDown]
        public void End()
        {
            _Sdk?.Logout();
        }

        [Test]
        public void DSMCListLocalServerTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            ModelsListServerResponse? serverResp = _Sdk.Dsmc.Admin.ListLocalServerOp
                .Execute(_Sdk.Namespace);
            Assert.IsNotNull(serverResp);
        }

        [Test]
        public void DSMCServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string usernameToTest = "dummy@example.com";
            if (_Sdk.Configuration.Credential != null)
                usernameToTest = _Sdk.Configuration.Credential.Username;

            string target_deployment = "default";
            string game_mode = "GAME_MODE";
            string party_id = "PARTY_ID";
            string party_user_id = _Sdk.Configuration.Credential!.UserId;
            string session_id = String.Empty;

            //Create a session
            Api.Sessionbrowser.Model.ModelsCreateSessionRequest createSession = new Api.Sessionbrowser.Model.ModelsCreateSessionRequest()
            {
                SessionType = "p2p",
                GameVersion = "0.3.0",
                Namespace = _Sdk.Namespace,
                Username = usernameToTest,
                GameSessionSetting = new Api.Sessionbrowser.Model.ModelsGameSessionSetting()
                {
                    Mode = game_mode,
                    AllowJoinInProgress = true,
                    MapName = "CSharp SDK Integration Test",
                    MaxPlayer = 100
                }
            };

            Api.Sessionbrowser.Model.ModelsSessionResponse? cResp = _Sdk.Sessionbrowser.Session.CreateSessionOp
                .Execute(createSession, _Sdk.Namespace);
            Assert.IsNotNull(cResp);
            if (cResp != null)
            {
                Assert.AreEqual(usernameToTest, cResp.Username!);
                session_id = cResp.SessionId!;
            }

            //Create a session
            ModelsCreateSessionRequest sessionRequest = new ModelsCreateSessionRequest()
            {
                ClientVersion = "0.3.0",
                Configuration = "",
                Deployment = target_deployment,
                GameMode = game_mode,
                MatchingAllies = new List<ModelsRequestMatchingAlly>()
                {
                    new ModelsRequestMatchingAlly()
                    {
                        MatchingParties = new List<ModelsRequestMatchParty>()
                        {
                            new ModelsRequestMatchParty()
                            {
                                PartyAttributes = new Dictionary<string, object>(),
                                PartyId = party_id,
                                PartyMembers = new List<ModelsRequestMatchMember>()
                                {
                                    new ModelsRequestMatchMember()
                                    {
                                        UserId = party_user_id
                                    }
                                }
                            }
                        }
                    }
                },
                Region = "",
                PodName = "",
                SessionId = session_id,
                Namespace = _Sdk.Namespace,
            };

            ModelsSessionResponse? csResp = _Sdk.Dsmc.Session.CreateSessionOp
                .Execute(sessionRequest, _Sdk.Namespace);
            Assert.IsNotNull(csResp);

            csResp = _Sdk.Dsmc.Session.GetSessionOp.Execute(_Sdk.Namespace, session_id);
            Assert.IsNotNull(csResp);

            //Waiting for the server to be ready
            Thread.Sleep(5000);

            ModelsClaimSessionRequest claimServer = new ModelsClaimSessionRequest()
            {
                SessionId = session_id
            };
            _Sdk.Dsmc.Session.ClaimServerOp.Execute(claimServer, _Sdk.Namespace);

            _Sdk.Dsmc.Admin.DeleteSessionOp.Execute(_Sdk.Namespace, session_id);

            Api.Sessionbrowser.Model.ModelsSessionResponse? delResp = _Sdk.Sessionbrowser.Session.DeleteSessionOp
                .Execute(_Sdk.Namespace, session_id);
            Assert.IsNotNull(delResp);

            Assert.True(true);
        }

        [Test]
        public void MatchmakingServiceApiTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string channel_name = (_GameModePrefix + Helper.GenerateRandomId(8));
            
            //Create a channel
            ModelsChannelRequest channelReq = new ModelsChannelRequest()
            {
                Deployment = "",
                Description = "CSharp Server SDK Test",
                FindMatchTimeoutSeconds = 3600,
                GameMode = channel_name,
                Joinable = false,
                MaxDelayMs = 0,
                SessionQueueTimeoutSeconds = 0,
                SocialMatchmaking = false,
                UseSubGamemode = false,
                RuleSet = new ModelsRuleSet()
                {
                    Alliance = new ModelsAllianceRule()
                    {
                        MaxNumber = 2,
                        MinNumber = 2,
                        PlayerMaxNumber = 1,
                        PlayerMinNumber = 1
                    },
                    AllianceFlexingRule = new List<ModelsAllianceFlexingRule>(),
                    FlexingRule = new List<ModelsFlexingRule>(),
                    MatchOptions = new ModelsMatchOptionRule()
                    {
                        Options = new List<ModelsMatchOption>()
                    },
                    MatchingRule = new List<ModelsMatchingRule>(),
                    SubGameModes = new Dictionary<string, ModelsSubGameMode>()
                }
            };

            ModelsCreateChannelResponse? cResp = _Sdk.Matchmaking.Matchmaking.CreateChannelHandlerOp
                .Execute(channelReq, _Sdk.Namespace);
            Assert.IsNotNull(cResp);
            if (cResp != null)
                Assert.AreEqual(channel_name, cResp.GameMode);

            //Get a channel
            ModelsChannelV1? gResp = _Sdk.Matchmaking.Matchmaking.GetSingleMatchmakingChannelOp
                .Execute(channel_name, _Sdk.Namespace);
            Assert.IsNotNull(gResp);
            if (gResp != null)
                Assert.AreEqual("CSharp Server SDK Test", gResp.Description);

            //Get sessions in channel
            List<ModelsMatchmakingResult>? mResults = _Sdk.Matchmaking.Matchmaking.GetAllSessionsInChannelOp
                .Execute(channel_name, _Sdk.Namespace);
            Assert.IsNotNull(mResults);

            //Update a channel
            ModelsUpdateChannelRequest updateChannel = new ModelsUpdateChannelRequest()
            {
                Description = "Updated description."
            };

            _Sdk.Matchmaking.Matchmaking.UpdateMatchmakingChannelOp
                .Execute(updateChannel, channel_name, _Sdk.Namespace);

            //Get a channel back to confirm update
            gResp = _Sdk.Matchmaking.Matchmaking.GetSingleMatchmakingChannelOp
                .Execute(channel_name, _Sdk.Namespace);
            Assert.IsNotNull(gResp);
            if (gResp != null)
                Assert.AreEqual("Updated description.", gResp.Description);

            //Delete a channel
            _Sdk.Matchmaking.Matchmaking.DeleteChannelHandlerOp
                .Execute(channel_name, _Sdk.Namespace);

            //Finally, recheck if the data is truly deleted.
            HttpResponseException? hrx = Assert.Throws<HttpResponseException>(() =>
            {
                ModelsChannelV1? gResp = _Sdk.Matchmaking.Matchmaking.GetSingleMatchmakingChannelOp
                    .Execute(channel_name, _Sdk.Namespace);
            });
        }

        [Test]
        public void LobbyAPIServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            ModelFreeFormNotificationRequest notifBody = new ModelFreeFormNotificationRequest()
            {
                Topic = "csharp_sdk_test",
                Message = "This is integration test for CSharp Server SDK."
            };

            _Sdk.Lobby.Notification.FreeFormNotificationOp
                .Execute(notifBody, _Sdk.Namespace);
        }
    }
}