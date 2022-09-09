// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class DsmcTests : BaseServiceTests
    {
        [Test]
        public void DSMCListLocalServerTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            #region Get local server list
            ModelsListServerResponse? serverResp = _Sdk.Dsmc.Admin.ListLocalServerOp
                .Execute(_Sdk.Namespace);
            #endregion
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

            #region Register a session to DSMC service
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
            #endregion
            Assert.IsNotNull(csResp);

            #region Get registered session
            csResp = _Sdk.Dsmc.Session.GetSessionOp.Execute(_Sdk.Namespace, session_id);
            #endregion
            Assert.IsNotNull(csResp);

            //Waiting for the server to be ready
            Thread.Sleep(5000);

            #region Claim server for specified session
            ModelsClaimSessionRequest claimServer = new ModelsClaimSessionRequest()
            {
                SessionId = session_id
            };
            _Sdk.Dsmc.Session.ClaimServerOp.Execute(claimServer, _Sdk.Namespace);
            #endregion

            #region Delete a session from DSMC
            _Sdk.Dsmc.Admin.DeleteSessionOp.Execute(_Sdk.Namespace, session_id);
            #endregion

            Api.Sessionbrowser.Model.ModelsSessionResponse? delResp = _Sdk.Sessionbrowser.Session.DeleteSessionOp
                .Execute(_Sdk.Namespace, session_id);
            Assert.IsNotNull(delResp);

            Assert.True(true);
        }
    }
}
