// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Core.Repository
{
    public interface ITokenRepository
    {
        string Token { get; }

        int SecondsUntilExpiry { get; }

        long IssuedTimestamp { get; }

        bool HasToken { get; }

        bool IsTokenExpired { get; }

        LoginType LoginType { get; }

        void RemoveToken();

        void StoreToken(LoginType loginType, OauthmodelTokenResponseV3 tokenResponse);

        void StoreToken(LoginType loginType, OauthmodelTokenResponse tokenResponse);

        void StoreToken(LoginType loginType, OauthmodelTokenWithDeviceCookieResponseV3 tokenResponse);

        void UpdateToken(OauthmodelTokenResponseV3 tokenResponse);

        void UpdateToken(OauthmodelTokenWithDeviceCookieResponseV3 tokenResponse);

        // Deprecated(2023-02-13): Please use `StoreToken` with `OauthmodelTokenResponseV3` or `OauthmodelTokenWithDeviceCookieResponseV3` parameter.
        [Obsolete("# Deprecated(2023-02-13): Please use `StoreToken` with `OauthmodelTokenResponseV3` or `OauthmodelTokenWithDeviceCookieResponseV3` parameter.", DiagnosticId = "AB_TOKEN_REPO_DEPRECATED_METHOD")]
        void StoreToken(string token);

        // Deprecated(2023-02-13): Please use `Token` property instead.
        [Obsolete("# Deprecated(2023-02-13): Please use `Token` property instead.", DiagnosticId = "AB_TOKEN_REPO_DEPRECATED_METHOD")]
        string GetToken();
    }
}