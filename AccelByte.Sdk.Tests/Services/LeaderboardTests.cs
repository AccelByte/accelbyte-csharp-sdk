// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Leaderboard.Model;

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

            string leaderboard_code = "csharpsdklbtest" + Guid.NewGuid().ToString().Substring(0, 6);
            string start_time = DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd'T'HH:mm:ss.ffK");

            #region Create a leaderboard
            ModelsLeaderboardConfigReq newLeaderboard = new ModelsLeaderboardConfigReq()
            {
                LeaderboardCode = leaderboard_code,
                Name = "CSharp SDK Leaderboard Test",
                StatCode = "1",
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
                StatCode = "1",
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
        }
    }
}
