// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Sessionhistory.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class SessionHistoryTests : BaseServiceTests
    {
        public SessionHistoryTests() : base(false) { }

        [Test]
        [Ignore("X-Ray metric endpoint is unavailable in stage")]
        public void TotalMatchmakingMatchTests()
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

            string endDate = DateTime.Now
                .ToUniversalTime()
                .ToString("u").Replace(" ", "T");
            string startDate = DateTime.Now.Subtract(TimeSpan.FromDays(10))
                .ToUniversalTime()
                .ToString("u").Replace(" ", "T");

            #region Get total matchmaking match
            var response = _Sdk.Sessionhistory.XRay.QueryTotalMatchmakingMatchOp
                .Execute(_Sdk.Namespace, endDate, startDate);
            #endregion
            Assert.IsNotNull(response);
            if ((response != null) && (response.Data != null))
                Assert.GreaterOrEqual(response.Data.Count, 0);

            ResetPolicy();
        }

        [Test]
        public void GameSessionTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            DisableRetry();

            #region Get all game sessions history
            var response = _Sdk.Sessionhistory.GameSessionDetail.AdminQueryGameSessionDetailOp
                .SetOffset(0)
                .SetLimit(20)
                .Execute(_Sdk.Namespace);
            #endregion
            Assert.IsNotNull(response);
            if ((response != null) && (response.Data != null))
                Assert.GreaterOrEqual(response.Data.Count, 0);

            #region Get all matchmaking history
            var mResponse = _Sdk.Sessionhistory.GameSessionDetail.AdminQueryMatchmakingDetailOp
                .SetOffset(0)
                .SetLimit(20)
                .Execute(_Sdk.Namespace);
            #endregion
            Assert.IsNotNull(mResponse);
            if ((mResponse != null) && (mResponse.Data != null))
                Assert.GreaterOrEqual(mResponse.Data.Count, 0);

            ResetPolicy();
        }
    }
}
