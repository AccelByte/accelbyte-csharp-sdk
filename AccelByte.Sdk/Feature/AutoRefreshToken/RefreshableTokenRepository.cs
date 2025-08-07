// Copyright (c) 2022-2025 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

namespace AccelByte.Sdk.Feature.AutoTokenRefresh
{
    public class RefreshableTokenRepository : BaseRefreshTokenRepository
    {
        public RefreshableTokenRepository()
            : base(OnDemandTokenRefreshOptions.Default) { }

        public RefreshableTokenRepository(OnDemandTokenRefreshOptions opts)
            : base(opts) { }
    }
}