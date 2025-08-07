// Copyright (c) 2022-2025 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Api.Iam.Model;

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

        [Obsolete("Please use overloaded method of `UpdateRefreshToken` that accepts token response model.")]
        void StoreRefreshToken(string refreshToken, float refreshThreshold);

        [Obsolete("Please use overloaded method of `UpdateRefreshToken` that accepts token response model.")]
        void UpdateRefreshToken(string refreshToken);

        void UpdateRefreshToken(OauthmodelTokenResponseV3 tokenResponse);

        void UpdateRefreshToken(OauthmodelTokenResponse tokenResponse);

        void UpdateRefreshToken(OauthmodelTokenWithDeviceCookieResponseV3 tokenResponse);

        void DoRefreshToken(AccelByteSDK sdk, Action? onUpdated, Action<Exception>? onFailed, bool rethrowOnError);

        Task DoRefreshTokenAsync(AccelByteSDK sdk, Action? onUpdated, Action<Exception>? onFailed, bool rethrowOnError);
    }
}