// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Feature.AutoTokenRefresh
{
    public interface IRefreshTokenRepository
    {
        bool RefreshTokenEnabled { get; set; }

        string RefreshToken { get; }

        int SecondsUntilExpiry { get; }

        long IssuedTimestamp { get; }

        bool HasToken { get; }
         
        bool HasRefreshToken { get; }

        bool IsTokenExpired { get; }

        bool IsTokenExpiring { get; }

        float RefreshThreshold { get; }

        LoginType LoginType { get; }

        bool IsRefreshOnProgress { get; set; }

        void StoreRefreshToken(LoginType loginType, string refreshToken, float refreshThreshold, int expiryIn);

        void UpdateRefreshToken(string refreshToken, int expiryIn);
    }
}