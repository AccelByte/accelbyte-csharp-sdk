// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Tests.Integration;
namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class MatchV2Tests : BaseServiceTests
    {
        public MatchV2Tests() : base(false) { }

        [Test]
        public void MatchPoolTests()
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

            string nameSuffix = Helper.GenerateRandomId(4);

            string cfgTemplateName = "csharp_sdk_template_" + nameSuffix;
            string rulesetName = "csharp_sdk_ruleset_" + nameSuffix;
            string poolName = "csharp_sdk_pool_" + nameSuffix;

            _Sdk.Session.ConfigurationTemplate.AdminCreateConfigurationTemplateV1Op
                .Execute(new()
                {
                    Name = cfgTemplateName,
                    Type = "P2P",
                    MinPlayers = 2,
                    MaxPlayers = 2,
                    InviteTimeout = 60,
                    InactiveTimeout = 60,
                    Joinability = "OPEN",
                    ClientVersion = "1.0.0",
                    RequestedRegions = new List<string>()
                    {
                        "us-west-2"
                    }
                }, _Sdk.Namespace);

            #region Create a match rule set
            ApiRuleSetPayload cRuleSetBody = new ApiRuleSetPayload()
            {
                Name = rulesetName,
                Data = new Dictionary<string, object>()
                {
                    {"param_1", 40},
                    {"param_2", "A"}
                }
            };

            _Sdk.Match2.RuleSets.CreateRuleSetOp
                .Execute(cRuleSetBody, _Sdk.Namespace);
            #endregion

            #region Create a match pool
            ApiMatchPool createPoolBody = new ApiMatchPool()
            {
                Name = poolName,
                MatchFunction = "basic",
                SessionTemplate = cfgTemplateName,
                BackfillTicketExpirationSeconds = 600,
                RuleSet = rulesetName,
                TicketExpirationSeconds = 600
            };

            _Sdk.Match2.MatchPools.CreateMatchPoolOp
                .Execute(createPoolBody, _Sdk.Namespace);
            #endregion

            #region List match pools
            ApiListMatchPoolsResponse? poolList = _Sdk.Match2.MatchPools.MatchPoolListOp
                .Execute(_Sdk.Namespace);
            #endregion
            Assert.IsNotNull(poolList);

            #region Get match pool detail
            ApiMatchPool? matchPool = _Sdk.Match2.MatchPools.MatchPoolDetailsOp
                .Execute(_Sdk.Namespace, poolName);
            #endregion
            Assert.IsNotNull(matchPool);

            ITestPlayer player1 = new NewTestPlayer(_Sdk, true);
            player1.Run((sdk, player) =>
            {
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

                string partyId = String.Empty;
                ApimodelsPartySessionResponse? partyResponse = sdk.Session.Party.PublicCreatePartyOp
                    .Execute(partyRequest, sdk.Namespace);
                if (partyResponse != null)
                    partyId = partyResponse.Id!;

                #region User create a match ticket
                ApiMatchTicketRequest ticketRequest = new ApiMatchTicketRequest()
                {
                    MatchPool = poolName,
                    SessionID = partyId
                };

                ApiMatchTicketResponse? nTicketResponse = sdk.Match2.MatchTickets.CreateMatchTicketOp
                    .Execute(ticketRequest, sdk.Namespace);
                #endregion
                Assert.IsNotNull(nTicketResponse);
                string ticketId = nTicketResponse!.MatchTicketID!;

                #region User delete a match ticket
                sdk.Match2.MatchTickets.DeleteMatchTicketOp
                    .Execute(sdk.Namespace, ticketId);
                #endregion

                sdk.Session.Party.PublicPartyLeaveOp
                    .Execute(sdk.Namespace, partyId);
            });

            player1.Logout();

            #region Delete a match pool
            _Sdk.Match2.MatchPools.DeleteMatchPoolOp
                .Execute(_Sdk.Namespace, poolName);
            #endregion

            #region Delete a match rule set
            _Sdk.Match2.RuleSets.DeleteRuleSetOp
                .Execute(_Sdk.Namespace, rulesetName);
            #endregion

            _Sdk.Session.ConfigurationTemplate.AdminDeleteConfigurationTemplateV1Op
                .Execute(cfgTemplateName, _Sdk.Namespace);

            ResetPolicy();
        }

        [Test]
        public void MatchFunctionTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            #region List match functions
            ApiListMatchFunctionsResponse? response = _Sdk.Match2.MatchFunctions.MatchFunctionListOp
                .Execute(_Sdk.Namespace);
            #endregion
            Assert.IsNotNull(response);
        }
    }
}