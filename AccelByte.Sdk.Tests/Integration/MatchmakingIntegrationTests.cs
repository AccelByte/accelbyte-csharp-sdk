// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Logging;
using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Api.Dsmc.Wrapper;

using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Matchmaking.Operation;
using AccelByte.Sdk.Api.Matchmaking.Wrapper;

using AccelByte.Sdk.Api.Lobby;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Api.Lobby.WSModel;

using AccelByte.Sdk.Tests.Model;

namespace AccelByte.Sdk.Tests.Integration
{
    [TestFixture(Category = "Integration")]
    [Explicit]
    public class MatchmakingIntegrationTests : BaseIntegrationTest
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
                .UseDefaultTokenRepository()
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

            Admin wDsmcAdmin = new Admin(_Sdk);
            ModelsListServerResponse? serverResp = wDsmcAdmin.ListLocalServer(ListLocalServer.Builder
                .Build(_Sdk.Namespace));
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

            Session wSession = new Session(_Sdk);
            Admin wDsmcAdmin = new Admin(_Sdk);

            Api.Sessionbrowser.Wrapper.Session wSBSession = new Api.Sessionbrowser.Wrapper.Session(_Sdk);            

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

            Api.Sessionbrowser.Model.ModelsSessionResponse? cResp = wSBSession.CreateSession(
                Api.Sessionbrowser.Operation.CreateSession.Builder
                .Build(createSession, _Sdk.Namespace));
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
                MatchingAllies = new List<Api.Dsmc.Model.ModelsRequestMatchingAlly>()
                {
                    new Api.Dsmc.Model.ModelsRequestMatchingAlly()
                    {
                        MatchingParties = new List<Api.Dsmc.Model.ModelsRequestMatchParty>()
                        {
                            new Api.Dsmc.Model.ModelsRequestMatchParty()
                            {
                                PartyAttributes = new Dictionary<string, object>(),
                                PartyId = party_id,
                                PartyMembers = new List<Api.Dsmc.Model.ModelsRequestMatchMember>()
                                {
                                    new Api.Dsmc.Model.ModelsRequestMatchMember()
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

            ModelsSessionResponse? csResp = wSession.CreateSession(CreateSession.Builder
                .Build(sessionRequest, _Sdk.Namespace));
            Assert.IsNotNull(csResp);

            csResp = wSession.GetSession(GetSession.Builder.Build(_Sdk.Namespace, session_id));
            Assert.IsNotNull(csResp);

            //Waiting for the server to be ready
            Thread.Sleep(5000);

            ModelsClaimSessionRequest claimServer = new ModelsClaimSessionRequest()
            {
                SessionId = session_id
            };
            wSession.ClaimServer(ClaimServer.Builder.Build(claimServer, _Sdk.Namespace));

            wDsmcAdmin.DeleteSession(DeleteSession.Builder
                .Build(_Sdk.Namespace, session_id));

            Api.Sessionbrowser.Model.ModelsSessionResponse? delResp = wSBSession.DeleteSession(
                Api.Sessionbrowser.Operation.DeleteSession.Builder
                .Build(_Sdk.Namespace, session_id));
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

            Matchmaking wMatchmaking = new Matchmaking(_Sdk);

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

            ModelsCreateChannelResponse? cResp = wMatchmaking.CreateChannelHandler(CreateChannelHandler.Builder
                .Build(channelReq, _Sdk.Namespace));
            Assert.IsNotNull(cResp);
            if (cResp != null)
                Assert.AreEqual(channel_name, cResp.GameMode);

            //Get a channel
            ModelsChannelV1? gResp = wMatchmaking.GetSingleMatchmakingChannel(GetSingleMatchmakingChannel.Builder
                .Build(channel_name, _Sdk.Namespace));
            Assert.IsNotNull(gResp);
            if (gResp != null)
                Assert.AreEqual("CSharp Server SDK Test", gResp.Description);

            //Get sessions in channel
            List<ModelsMatchmakingResult>? mResults = wMatchmaking.GetAllSessionsInChannel(GetAllSessionsInChannel.Builder
                .Build(channel_name, _Sdk.Namespace));
            Assert.IsNotNull(mResults);

            //Update a channel
            ModelsUpdateChannelRequest updateChannel = new ModelsUpdateChannelRequest()
            {
                Description = "Updated description."
            };

            wMatchmaking.UpdateMatchmakingChannel(UpdateMatchmakingChannel.Builder
                .Build(updateChannel, channel_name, _Sdk.Namespace));

            //Get a channel back to confirm update
            gResp = wMatchmaking.GetSingleMatchmakingChannel(GetSingleMatchmakingChannel.Builder
                .Build(channel_name, _Sdk.Namespace));
            Assert.IsNotNull(gResp);
            if (gResp != null)
                Assert.AreEqual("Updated description.", gResp.Description);

            //Delete a channel
            wMatchmaking.DeleteChannelHandler(DeleteChannelHandler.Builder
                .Build(channel_name, _Sdk.Namespace));

            //Finally, recheck if the data is truly deleted.
            HttpResponseException? hrx = Assert.Throws<HttpResponseException>(() =>
            {
                ModelsChannelV1? gResp = wMatchmaking.GetSingleMatchmakingChannel(GetSingleMatchmakingChannel.Builder
                    .Build(channel_name, _Sdk.Namespace));
            });
        }

        [Test]
        public void LobbyAPIServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            Notification wLobbyNotification = new Notification(_Sdk);

            //Sending a free from notification to all user(s).
            ModelFreeFormNotificationRequest notifBody = new ModelFreeFormNotificationRequest()
            {
                Topic = "csharp_sdk_test",
                Message = "This is integration test for CSharp Server SDK."
            };

            wLobbyNotification.FreeFormNotification(FreeFormNotification.Builder
                .Build(notifBody, _Sdk.Namespace));
        }

        [Test]
        public void LobbyWebSocketServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string request_id = Helper.GenerateRandomId(64);
            bool is_error = false;
            bool? is_response_received = null;

            LobbyService lobby = new LobbyService(_Sdk.Configuration);
            lobby.OnReceiveError = (eMessage) =>
            {
                is_error = true;
            };

            lobby.OnPartyCreateResponse = (PartyCreateResponse resp) =>
            {
                is_response_received = true;
                Assert.AreEqual(request_id, resp.Id);
            };

            Task connectTask = lobby.Connect(false);
            connectTask.Wait();

            Task listenTask = Task.Run(() => lobby.Listen());


            Task sendTask = lobby.SendPartyCreateRequest(new PartyCreateRequest()
            {
                Id = request_id
            }, 0);
            sendTask.Wait();

            //Now wait for the response message...
            while (true)
            {
                if (is_error == true)
                    break;

                if (is_response_received == null)
                    Thread.Sleep(100);
                else
                    break;
            }

            Task disconnectTask = lobby.Disconnect();
            disconnectTask.Wait();

            Assert.IsFalse(is_error);
            Assert.IsNotNull(is_response_received);
        }
    }
}