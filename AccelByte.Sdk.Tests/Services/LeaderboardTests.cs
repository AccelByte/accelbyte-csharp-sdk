// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class LeaderboardTests : BaseServiceTests
    {
        public LeaderboardTests() : base(true) { }

        [Test]
        public void LeaderboardServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            DisableRetry();
                
            string stat_code = "csharpserversdkteststat" + Guid.NewGuid().ToString().Substring(0, 6);
            string leaderboard_code = "csharpsdklbtest" + Guid.NewGuid().ToString().Substring(0, 6);
            string start_time = DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd'T'HH:mm:ss.ffK");

            // Create a stat code first
            StatCreate createStat = new StatCreate()
            {
                Name = "CSharp Server SDK Test Stat",
                Description = "CSharp server sdk integration test.",
                StatCode = stat_code,
                SetBy = "SERVER",
                Minimum = 0.0,
                Maximum = 100.0,
                DefaultValue = 50.0,
                IncrementOnly = true,
                SetAsGlobal = false,
                Tags = new List<string>() { "csharp", "server_sdk", "test" }
            };

            StatInfo? cStat = _Sdk.Social.StatConfiguration.CreateStatOp
                .SetBody(createStat)
                .Execute(_Sdk.Namespace);
            Assert.IsNotNull(cStat);
            if (cStat != null)
                Assert.AreEqual("CSharp Server SDK Test Stat", cStat.Name);

            #region Create a leaderboard
            ModelsLeaderboardConfigReq newLeaderboard = new ModelsLeaderboardConfigReq()
            {
                LeaderboardCode = leaderboard_code,
                Name = "CSharp SDK Leaderboard Test",
                StatCode = stat_code,
                SeasonPeriod = 36,
                Descending = false,
                StartTime = start_time,
                Daily = new ModelsDailyConfig()
                {
                    ResetTime = "00:00:00"
                },
                Weekly = new ModelsWeeklyConfig()
                {
                    ResetDay = 0,
                    ResetTime = "00:00:00"
                },
                Monthly = new ModelsMonthlyConfig()
                {
                    ResetDate = 1,
                    ResetTime = "00:00:00"
                }
            };

            ModelsLeaderboardConfigReq? cLeaderboard = _Sdk.Leaderboard.LeaderboardConfiguration.CreateLeaderboardConfigurationAdminV1Op
                .Execute(newLeaderboard, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(cLeaderboard);
            if (cLeaderboard != null)
                Assert.AreEqual("CSharp SDK Leaderboard Test", cLeaderboard.Name!);

            #region Get a leaderboard
            ModelsGetLeaderboardConfigResp? gLeaderboard = _Sdk.Leaderboard.LeaderboardConfiguration.GetLeaderboardConfigurationAdminV1Op
                .Execute(leaderboard_code, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(gLeaderboard);
            if (gLeaderboard != null)
                Assert.AreEqual("CSharp SDK Leaderboard Test", gLeaderboard.Name!);

            #region Update a leaderboard
            ModelsUpdateLeaderboardConfigReq updateLeaderboard = new ModelsUpdateLeaderboardConfigReq()
            {
                Name = "CSharp SDK Leaderboard Test",
                StatCode = stat_code,
                StartTime = start_time,
                SeasonPeriod = 40
            };

            ModelsGetLeaderboardConfigResp? uLeaderboard = _Sdk.Leaderboard.LeaderboardConfiguration.UpdateLeaderboardConfigurationAdminV1Op
                .Execute(updateLeaderboard, leaderboard_code, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(uLeaderboard);
            if (uLeaderboard != null)
                Assert.AreEqual(40, uLeaderboard.SeasonPeriod!);

            #region Delete a leaderboard
            _Sdk.Leaderboard.LeaderboardConfiguration.DeleteLeaderboardConfigurationAdminV1Op
                .Execute(leaderboard_code, _Sdk.Namespace);
            #endregion

            //Finally, recheck if the data is truly deleted.
            DisableRetry();
            ModelsGetLeaderboardConfigResp? dcLeaderboard = _Sdk.Leaderboard.LeaderboardConfiguration.GetLeaderboardConfigurationAdminV1Op
                .Execute(leaderboard_code, _Sdk.Namespace);
            Assert.IsNotNull(dcLeaderboard);
            Assert.IsTrue(dcLeaderboard!.IsDeleted!);

            //Last, delete the stat code
            _Sdk.Social.StatConfiguration.DeleteStatOp
                .Execute(_Sdk.Namespace, stat_code);

            ResetPolicy();
        }
    }
}
