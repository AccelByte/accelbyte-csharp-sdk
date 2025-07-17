// Copyright (c) 2022-2025 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Linq;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Tests.Integration;
namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class SessionTests : BaseServiceTests
    {
        private ITestPlayer? _Player1 = null;

        private ITestPlayer? _Player2 = null;

        public SessionTests() : base(false) { }

        protected override void OnStartup(AccelByteSDK sdk)
        {
            DisableRetry();

            //_Player1 = new ExistingTestPlayer("AB_PLAYER1", true);
            _Player1 = new NewTestPlayer(sdk, true);
            //_Player2 = new ExistingTestPlayer("AB_PLAYER2", true);
            _Player2 = new NewTestPlayer(sdk, true);

            ResetPolicy();
        }

        protected override void OnBeforeEnd()
        {
            _Player1?.Logout();
            _Player2?.Logout();
        }

        [Test]
        public void ConfigurationTemplateTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Temporarily disabled in AGS Starter due to issue in session service.");
                return;
            }

            DisableRetry();

            string cfgTemplateName = $"csharp_sdk_template_{Helper.GenerateRandomId(4)}";

            #region Create session configuration template
            ApimodelsCreateConfigurationTemplateRequest cTemplateBody = new ApimodelsCreateConfigurationTemplateRequest()
            {
                Name = cfgTemplateName,
                Type = ApimodelsCreateConfigurationTemplateRequestType.P2P,
                MinPlayers = 2,
                MaxPlayers = 2,
                InviteTimeout = 60,
                InactiveTimeout = 60,
                Joinability = ApimodelsCreateConfigurationTemplateRequestJoinability.OPEN,
                ClientVersion = "1.0.0",
                RequestedRegions = new List<string>()
                {
                    "us-west-2"
                }
            };

            _Sdk.Session.ConfigurationTemplate.AdminCreateConfigurationTemplateV1Op
                .Execute(cTemplateBody, _Sdk.Namespace);

            ApimodelsConfigurationTemplateResponse? cfgTemplate = _Sdk.Session.ConfigurationTemplate.AdminGetConfigurationTemplateV1Op
                .Execute(cfgTemplateName, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(cfgTemplate);
            if (cfgTemplate != null)
            {
                Assert.AreEqual(ApimodelsCreateConfigurationTemplateRequestType.P2P, cfgTemplate.Type!);
                Assert.AreEqual(ApimodelsCreateConfigurationTemplateRequestJoinability.OPEN, cfgTemplate.Joinability!);
                Assert.AreEqual(2, cfgTemplate.MaxPlayers!);
            }

            #region Update session configuration template
            ApimodelsUpdateConfigurationTemplateRequest uTemplateBody = new ApimodelsUpdateConfigurationTemplateRequest()
            {
                Name = cfgTemplateName,
                Type = ApimodelsUpdateConfigurationTemplateRequestType.P2P,
                Joinability = ApimodelsUpdateConfigurationTemplateRequestJoinability.OPEN,
                MaxPlayers = 4
            };

            ApimodelsConfigurationTemplateResponse? uptTemplate = _Sdk.Session.ConfigurationTemplate.AdminUpdateConfigurationTemplateV1Op
                .Execute(uTemplateBody, cfgTemplateName, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(uptTemplate);
            if (uptTemplate != null)
            {
                Assert.AreEqual(4, uptTemplate.MaxPlayers!);
            }

            #region Delete session configuration template
            _Sdk.Session.ConfigurationTemplate.AdminDeleteConfigurationTemplateV1Op
                .Execute(cfgTemplateName, _Sdk.Namespace);
            #endregion

            ResetPolicy();
        }

        [Test]
        public void GameSessionTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Temporarily disabled in AGS Starter due to issue in session service.");
                return;
            }

            Assert.IsNotNull(_Player1);
            if (_Player1 == null)
                return;

            Assert.IsNotNull(_Player2);
            if (_Player2 == null)
                return;

            DisableRetry();

            string cfgTemplateName = $"csharp_sdk_template_{Helper.GenerateRandomId(4)}";
            _Sdk.Session.ConfigurationTemplate.AdminCreateConfigurationTemplateV1Op
                .Execute(new()
                {
                    Name = cfgTemplateName,
                    Type = ApimodelsCreateConfigurationTemplateRequestType.P2P,
                    MinPlayers = 2,
                    MaxPlayers = 2,
                    InviteTimeout = 60,
                    InactiveTimeout = 60,
                    Joinability = ApimodelsCreateConfigurationTemplateRequestJoinability.OPEN,
                    ClientVersion = "1.0.0",
                    RequestedRegions = new List<string>()
                    {
                        "us-west-2"
                    }
                }, _Sdk.Namespace);

            string gameSessionId = String.Empty;
            _Player1.Run((sdk, player) =>
            {
                #region Create a game session
                ApimodelsCreateGameSessionRequest newGSRequest = new ApimodelsCreateGameSessionRequest()
                {
                    ConfigurationName = cfgTemplateName,
                };

                ApimodelsGameSessionResponse? newGSResponse = sdk.Session.GameSession.CreateGameSessionOp
                    .Execute(newGSRequest, sdk.Namespace);
                #endregion
                Assert.IsNotNull(newGSResponse);
                if (newGSResponse != null)
                    gameSessionId = newGSResponse.Id!;
            });

            if (gameSessionId == String.Empty)
                Assert.Fail("No game session id");

            Wait();

            _Player2.Run((sdk, player) =>
            {
                #region Join a game session
                ApimodelsGameSessionResponse? p2GsJoin = sdk.Session.GameSession.JoinGameSessionOp
                    .Execute(sdk.Namespace, gameSessionId);
                #endregion
                Assert.IsNotNull(p2GsJoin);
            });

            Wait();

            ApimodelsGameSessionResponse? gsCheck = _Sdk.Session.GameSession.GetGameSessionOp
                .Execute(_Sdk.Namespace, gameSessionId);
            if (gsCheck != null)
            {
                Assert.AreEqual(2, gsCheck.Members!.Count);
                List<string> userIds = gsCheck.Members!.Select(item => item.Id!).ToList();
                Assert.Contains(_Player1.UserId, userIds);
                Assert.Contains(_Player2.UserId, userIds);
            }

            _Player2.Run((sdk, player) =>
            {
                #region Leave a game session
                sdk.Session.GameSession.LeaveGameSessionOp
                    .Execute(sdk.Namespace, gameSessionId);
                #endregion
            });

            _Player1.Run((sdk, player) =>
            {
                #region Delete a game session
                sdk.Session.GameSession.DeleteGameSessionOp
                    .Execute(sdk.Namespace, gameSessionId);
                #endregion
            });

            _Sdk.Session.ConfigurationTemplate.AdminDeleteConfigurationTemplateV1Op
                .Execute(cfgTemplateName, _Sdk.Namespace);

            ResetPolicy();
        }

        [Test]
        public void QueryGameSessions()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            #region Query game sessions
            var response = _Sdk.Session.GameSession.PublicQueryGameSessionsByAttributesOp
                .Execute(new Dictionary<string, object>() { }, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(response);
        }

        [Test]
        public void PartyTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Temporarily disabled in AGS Starter due to issue in session service.");
                return;
            }

            Assert.IsNotNull(_Player1);
            if (_Player1 == null)
                return;

            Assert.IsNotNull(_Player2);
            if (_Player2 == null)
                return;

            DisableRetry();

            string cfgTemplateName = $"csharp_sdk_template_{Helper.GenerateRandomId(4)}";
            _Sdk.Session.ConfigurationTemplate.AdminCreateConfigurationTemplateV1Op
                .Execute(new()
                {
                    Name = cfgTemplateName,
                    Type = ApimodelsCreateConfigurationTemplateRequestType.P2P,
                    MinPlayers = 2,
                    MaxPlayers = 2,
                    InviteTimeout = 60,
                    InactiveTimeout = 60,
                    Joinability = ApimodelsCreateConfigurationTemplateRequestJoinability.OPEN,
                    ClientVersion = "1.0.0",
                    RequestedRegions = new List<string>()
                    {
                        "us-west-2"
                    }
                }, _Sdk.Namespace);

            string partyId = String.Empty;
            string joinCode = String.Empty;

            Wait();

            _Player1.Run((sdk, player) =>
            {
                #region User create a party
                ApimodelsCreatePartyRequest partyRequest = new ApimodelsCreatePartyRequest()
                {
                    ConfigurationName = cfgTemplateName,
                    Members = new List<ApimodelsRequestMember>()
                    {
                        new ApimodelsRequestMember()
                        {
                            ID = player.UserId
                        }
                    }
                };

                ApimodelsPartySessionResponse? partyResponse = sdk.Session.Party.PublicCreatePartyOp
                    .Execute(partyRequest, sdk.Namespace);
                #endregion
                Assert.IsNotNull(partyResponse);
                if (partyResponse != null)
                {
                    partyId = partyResponse.Id!;
                    joinCode = partyResponse.Code!;
                }
            });

            if (partyId == String.Empty)
                Assert.Fail("No party id");
            if (joinCode == String.Empty)
                Assert.Fail("No join code");

            Wait();

            _Player2.Run((sdk, player) =>
            {
                #region User join a party with code
                ApimodelsJoinByCodeRequest joinRequest = new ApimodelsJoinByCodeRequest()
                {
                    Code = joinCode
                };

                ApimodelsPartySessionResponse? joinResponse = sdk.Session.Party.PublicPartyJoinCodeOp
                    .Execute(joinRequest, sdk.Namespace);
                #endregion
                Assert.IsNotNull(joinResponse);
            });

            Wait();

            #region Get party detail
            ApimodelsPartySessionResponse? partyData = _Sdk.Session.Party.PublicGetPartyOp
                .Execute(_Sdk.Namespace, partyId);
            #endregion
            Assert.IsNotNull(partyData);
            if (partyData != null)
            {
                Assert.AreEqual(2, partyData.Members!.Count);
                List<string> userIds = partyData.Members!.Select(item => item.Id!).ToList();
                Assert.Contains(_Player1.UserId, userIds);
                Assert.Contains(_Player2.UserId, userIds);
            }

            _Player2.Run((sdk, player) =>
            {
                #region User leave a party
                sdk.Session.Party.PublicPartyLeaveOp
                    .Execute(sdk.Namespace, partyId);
                #endregion
            });

            Wait();

            ApimodelsPartySessionResponse? uPartyData = _Sdk.Session.Party.PublicGetPartyOp
                .Execute(_Sdk.Namespace, partyId);
            Assert.IsNotNull(uPartyData);
            if (uPartyData != null)
            {
                Assert.AreEqual(2, uPartyData.Members!.Count);

                //Get id of members who are still in party.
                List<string> userIds = uPartyData.Members!
                    .Where(item => item.Status! != ApimodelsUserResponseStatus.LEFT)
                    .Select(item => item.Id!).ToList();

                Assert.Contains(_Player1.UserId, userIds);
                Assert.That(userIds, Has.No.Member(_Player2.UserId));
            }

            _Sdk.Session.ConfigurationTemplate.AdminDeleteConfigurationTemplateV1Op
                .Execute(cfgTemplateName, _Sdk.Namespace);

            ResetPolicy();
        }
    }
}