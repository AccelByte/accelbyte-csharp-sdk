// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using NUnit.Framework;

using AccelByte.Sdk.Api;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class SessionHistoryTests : BaseServiceTests
    {
        public SessionHistoryTests() : base(false) { }

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
