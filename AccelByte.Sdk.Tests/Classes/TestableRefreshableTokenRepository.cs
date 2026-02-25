// Copyright (c) 2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Feature.AutoTokenRefresh;

namespace AccelByte.Sdk.Tests
{
    public class TestableRefreshableTokenRepository : BaseRefreshTokenRepository
    {
        public int RefreshCount { get; protected set; } = 0;

        public int FailedCount { get; protected set; } = 0;

        public Func<LoginType, Exception>? ExceptionFunc { get; set; } = null;

        public TestableRefreshableTokenRepository()
            : base(OnDemandTokenRefreshOptions.Default) { }

        public TestableRefreshableTokenRepository(OnDemandTokenRefreshOptions opts)
            : base(opts) { }

        protected override void OnRefreshingToken(LoginType loginType)
        {
            if (ExceptionFunc != null)
                throw ExceptionFunc.Invoke(loginType);
        }

        protected override void OnTokenRefreshed()
        {
            RefreshCount++;
        }

        protected override void OnTokenRefreshFailed(Exception x, ref bool rethrowException)
        {
            FailedCount++;
            rethrowException = false;
        }
    }
}
