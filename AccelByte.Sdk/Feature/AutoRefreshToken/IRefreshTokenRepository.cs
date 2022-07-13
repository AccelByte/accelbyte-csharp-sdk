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

        bool HasRefreshToken { get; }

        bool IsTokenExpiring { get; }

        float RefreshThreshold { get; }

        bool IsRefreshOnProgress { get; set; }

        bool TryToSetRefreshOnProgressToTrue();

        void StoreRefreshToken(string refreshToken, float refreshThreshold);

        void UpdateRefreshToken(string refreshToken);
    }
}