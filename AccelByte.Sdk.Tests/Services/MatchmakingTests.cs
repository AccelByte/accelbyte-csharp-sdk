// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Api.Matchmaking.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class MatchmakingTests : BaseServiceTests
    {
        private string _GameModePrefix = "csharp_sdk_gm_";

        public MatchmakingTests() : base(true) { }

        [Test]
        public void MatchmakingServiceApiTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string channel_name = (_GameModePrefix + Helper.GenerateRandomId(8));

            #region Create a channel
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
            #endregion
            Assert.IsNotNull(cResp);
            if (cResp != null)
                Assert.AreEqual(channel_name, cResp.GameMode);

            #region Get a channel
            ModelsChannelV1? gResp = _Sdk.Matchmaking.Matchmaking.GetSingleMatchmakingChannelOp
                .Execute(channel_name, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(gResp);
            if (gResp != null)
                Assert.AreEqual("CSharp Server SDK Test", gResp.Description);

            #region Get sessions in channel
            List<ModelsMatchmakingResult>? mResults = _Sdk.Matchmaking.Matchmaking.GetAllSessionsInChannelOp
                .Execute(channel_name, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(mResults);

            #region Update a channel
            ModelsUpdateChannelRequest updateChannel = new ModelsUpdateChannelRequest()
            {
                Description = "Updated description."
            };

            _Sdk.Matchmaking.Matchmaking.UpdateMatchmakingChannelOp
                .Execute(updateChannel, channel_name, _Sdk.Namespace);
            #endregion

            //Get a channel back to confirm update
            gResp = _Sdk.Matchmaking.Matchmaking.GetSingleMatchmakingChannelOp
                .Execute(channel_name, _Sdk.Namespace);
            Assert.IsNotNull(gResp);
            if (gResp != null)
                Assert.AreEqual("Updated description.", gResp.Description);

            #region Delete a channel
            _Sdk.Matchmaking.Matchmaking.DeleteChannelHandlerOp
                .Execute(channel_name, _Sdk.Namespace);
            #endregion

            //Finally, recheck if the data is truly deleted.
            HttpResponseException? hrx = Assert.Throws<HttpResponseException>(() =>
            {
                DisableRetry();
                ModelsChannelV1? gResp = _Sdk.Matchmaking.Matchmaking.GetSingleMatchmakingChannelOp
                    .Execute(channel_name, _Sdk.Namespace);
            });
        }
    }
}
