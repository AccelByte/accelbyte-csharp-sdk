// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class IamOAuth20_OpExts
    {
        public static Iam.Model.OauthmodelTokenThirdPartyResponse? Execute(
            this AdminRetrieveUserThirdPartyPlatformTokenV3.AdminRetrieveUserThirdPartyPlatformTokenV3Builder builder,
            string namespace_,
            string platformId,
            string userId
        )
        {
            AdminRetrieveUserThirdPartyPlatformTokenV3 op = builder.Build(
                namespace_,
                platformId,
                userId
            );

            return ((Iam.Wrapper.OAuth20)builder.WrapperObject!).AdminRetrieveUserThirdPartyPlatformTokenV3(op);
        }
        public static async Task<Iam.Model.OauthmodelTokenThirdPartyResponse?> ExecuteAsync(
            this AdminRetrieveUserThirdPartyPlatformTokenV3.AdminRetrieveUserThirdPartyPlatformTokenV3Builder builder,
            string namespace_,
            string platformId,
            string userId
        )
        {
            AdminRetrieveUserThirdPartyPlatformTokenV3 op = builder.Build(
                namespace_,
                platformId,
                userId
            );

            return await ((Iam.Wrapper.OAuth20)builder.WrapperObject!).AdminRetrieveUserThirdPartyPlatformTokenV3Async(op);
        }
        public static void Execute(
            this RevokeUserV3.RevokeUserV3Builder builder,
            string namespace_,
            string userId
        )
        {
            RevokeUserV3 op = builder.Build(
                namespace_,
                userId
            );

            ((Iam.Wrapper.OAuth20)builder.WrapperObject!).RevokeUserV3(op);
        }
        public static async Task ExecuteAsync(
            this RevokeUserV3.RevokeUserV3Builder builder,
            string namespace_,
            string userId
        )
        {
            RevokeUserV3 op = builder.Build(
                namespace_,
                userId
            );

            await ((Iam.Wrapper.OAuth20)builder.WrapperObject!).RevokeUserV3Async(op);
        }
        public static string Execute(
            this AuthorizeV3.AuthorizeV3Builder builder,
            string clientId,
            string responseType
        )
        {
            AuthorizeV3 op = builder.Build(
                clientId,
                responseType
            );

            return ((Iam.Wrapper.OAuth20)builder.WrapperObject!).AuthorizeV3(op);
        }
        public static async Task<string> ExecuteAsync(
            this AuthorizeV3.AuthorizeV3Builder builder,
            string clientId,
            string responseType
        )
        {
            AuthorizeV3 op = builder.Build(
                clientId,
                responseType
            );

            return await ((Iam.Wrapper.OAuth20)builder.WrapperObject!).AuthorizeV3Async(op);
        }
        public static Iam.Model.OauthmodelTokenIntrospectResponse? Execute(
            this TokenIntrospectionV3.TokenIntrospectionV3Builder builder,
            string token
        )
        {
            TokenIntrospectionV3 op = builder.Build(
                token
            );

            return ((Iam.Wrapper.OAuth20)builder.WrapperObject!).TokenIntrospectionV3(op);
        }
        public static async Task<Iam.Model.OauthmodelTokenIntrospectResponse?> ExecuteAsync(
            this TokenIntrospectionV3.TokenIntrospectionV3Builder builder,
            string token
        )
        {
            TokenIntrospectionV3 op = builder.Build(
                token
            );

            return await ((Iam.Wrapper.OAuth20)builder.WrapperObject!).TokenIntrospectionV3Async(op);
        }
        public static Iam.Model.OauthcommonJWKSet? Execute(
            this GetJWKSV3.GetJWKSV3Builder builder
        )
        {
            GetJWKSV3 op = builder.Build(
            );

            return ((Iam.Wrapper.OAuth20)builder.WrapperObject!).GetJWKSV3(op);
        }
        public static async Task<Iam.Model.OauthcommonJWKSet?> ExecuteAsync(
            this GetJWKSV3.GetJWKSV3Builder builder
        )
        {
            GetJWKSV3 op = builder.Build(
            );

            return await ((Iam.Wrapper.OAuth20)builder.WrapperObject!).GetJWKSV3Async(op);
        }
        public static void Execute(
            this SendMFAAuthenticationCode.SendMFAAuthenticationCodeBuilder builder,
            string clientId,
            string factor,
            string mfaToken
        )
        {
            SendMFAAuthenticationCode op = builder.Build(
                clientId,
                factor,
                mfaToken
            );

            ((Iam.Wrapper.OAuth20)builder.WrapperObject!).SendMFAAuthenticationCode(op);
        }
        public static async Task ExecuteAsync(
            this SendMFAAuthenticationCode.SendMFAAuthenticationCodeBuilder builder,
            string clientId,
            string factor,
            string mfaToken
        )
        {
            SendMFAAuthenticationCode op = builder.Build(
                clientId,
                factor,
                mfaToken
            );

            await ((Iam.Wrapper.OAuth20)builder.WrapperObject!).SendMFAAuthenticationCodeAsync(op);
        }
        public static void Execute(
            this Change2faMethod.Change2faMethodBuilder builder,
            string factor,
            string mfaToken
        )
        {
            Change2faMethod op = builder.Build(
                factor,
                mfaToken
            );

            ((Iam.Wrapper.OAuth20)builder.WrapperObject!).Change2faMethod(op);
        }
        public static async Task ExecuteAsync(
            this Change2faMethod.Change2faMethodBuilder builder,
            string factor,
            string mfaToken
        )
        {
            Change2faMethod op = builder.Build(
                factor,
                mfaToken
            );

            await ((Iam.Wrapper.OAuth20)builder.WrapperObject!).Change2faMethodAsync(op);
        }
        public static Iam.Model.OauthmodelTokenResponseV3? Execute(
            this Verify2faCode.Verify2faCodeBuilder builder,
            string code,
            string factor,
            string mfaToken,
            bool rememberDevice
        )
        {
            Verify2faCode op = builder.Build(
                code,
                factor,
                mfaToken,
                rememberDevice
            );

            return ((Iam.Wrapper.OAuth20)builder.WrapperObject!).Verify2faCode(op);
        }
        public static async Task<Iam.Model.OauthmodelTokenResponseV3?> ExecuteAsync(
            this Verify2faCode.Verify2faCodeBuilder builder,
            string code,
            string factor,
            string mfaToken,
            bool rememberDevice
        )
        {
            Verify2faCode op = builder.Build(
                code,
                factor,
                mfaToken,
                rememberDevice
            );

            return await ((Iam.Wrapper.OAuth20)builder.WrapperObject!).Verify2faCodeAsync(op);
        }
        public static string Execute(
            this Verify2faCodeForward.Verify2faCodeForwardBuilder builder,
            string clientId,
            string code,
            string factor,
            string mfaToken
        )
        {
            Verify2faCodeForward op = builder.Build(
                clientId,
                code,
                factor,
                mfaToken
            );

            return ((Iam.Wrapper.OAuth20)builder.WrapperObject!).Verify2faCodeForward(op);
        }
        public static async Task<string> ExecuteAsync(
            this Verify2faCodeForward.Verify2faCodeForwardBuilder builder,
            string clientId,
            string code,
            string factor,
            string mfaToken
        )
        {
            Verify2faCodeForward op = builder.Build(
                clientId,
                code,
                factor,
                mfaToken
            );

            return await ((Iam.Wrapper.OAuth20)builder.WrapperObject!).Verify2faCodeForwardAsync(op);
        }
        public static Iam.Model.OauthmodelTokenThirdPartyResponse? Execute(
            this RetrieveUserThirdPartyPlatformTokenV3.RetrieveUserThirdPartyPlatformTokenV3Builder builder,
            string namespace_,
            string platformId,
            string userId
        )
        {
            RetrieveUserThirdPartyPlatformTokenV3 op = builder.Build(
                namespace_,
                platformId,
                userId
            );

            return ((Iam.Wrapper.OAuth20)builder.WrapperObject!).RetrieveUserThirdPartyPlatformTokenV3(op);
        }
        public static async Task<Iam.Model.OauthmodelTokenThirdPartyResponse?> ExecuteAsync(
            this RetrieveUserThirdPartyPlatformTokenV3.RetrieveUserThirdPartyPlatformTokenV3Builder builder,
            string namespace_,
            string platformId,
            string userId
        )
        {
            RetrieveUserThirdPartyPlatformTokenV3 op = builder.Build(
                namespace_,
                platformId,
                userId
            );

            return await ((Iam.Wrapper.OAuth20)builder.WrapperObject!).RetrieveUserThirdPartyPlatformTokenV3Async(op);
        }
        public static string Execute(
            this AuthCodeRequestV3.AuthCodeRequestV3Builder builder,
            string platformId,
            string requestId
        )
        {
            AuthCodeRequestV3 op = builder.Build(
                platformId,
                requestId
            );

            return ((Iam.Wrapper.OAuth20)builder.WrapperObject!).AuthCodeRequestV3(op);
        }
        public static async Task<string> ExecuteAsync(
            this AuthCodeRequestV3.AuthCodeRequestV3Builder builder,
            string platformId,
            string requestId
        )
        {
            AuthCodeRequestV3 op = builder.Build(
                platformId,
                requestId
            );

            return await ((Iam.Wrapper.OAuth20)builder.WrapperObject!).AuthCodeRequestV3Async(op);
        }
        public static Iam.Model.OauthmodelTokenResponse? Execute(
            this PlatformTokenGrantV3.PlatformTokenGrantV3Builder builder,
            string platformId
        )
        {
            PlatformTokenGrantV3 op = builder.Build(
                platformId
            );

            return ((Iam.Wrapper.OAuth20)builder.WrapperObject!).PlatformTokenGrantV3(op);
        }
        public static async Task<Iam.Model.OauthmodelTokenResponse?> ExecuteAsync(
            this PlatformTokenGrantV3.PlatformTokenGrantV3Builder builder,
            string platformId
        )
        {
            PlatformTokenGrantV3 op = builder.Build(
                platformId
            );

            return await ((Iam.Wrapper.OAuth20)builder.WrapperObject!).PlatformTokenGrantV3Async(op);
        }
        public static Iam.Model.OauthapiRevocationList? Execute(
            this GetRevocationListV3.GetRevocationListV3Builder builder
        )
        {
            GetRevocationListV3 op = builder.Build(
            );

            return ((Iam.Wrapper.OAuth20)builder.WrapperObject!).GetRevocationListV3(op);
        }
        public static async Task<Iam.Model.OauthapiRevocationList?> ExecuteAsync(
            this GetRevocationListV3.GetRevocationListV3Builder builder
        )
        {
            GetRevocationListV3 op = builder.Build(
            );

            return await ((Iam.Wrapper.OAuth20)builder.WrapperObject!).GetRevocationListV3Async(op);
        }
        public static void Execute(
            this TokenRevocationV3.TokenRevocationV3Builder builder,
            string token
        )
        {
            TokenRevocationV3 op = builder.Build(
                token
            );

            ((Iam.Wrapper.OAuth20)builder.WrapperObject!).TokenRevocationV3(op);
        }
        public static async Task ExecuteAsync(
            this TokenRevocationV3.TokenRevocationV3Builder builder,
            string token
        )
        {
            TokenRevocationV3 op = builder.Build(
                token
            );

            await ((Iam.Wrapper.OAuth20)builder.WrapperObject!).TokenRevocationV3Async(op);
        }
        public static Iam.Model.OauthmodelTokenResponseV3? Execute(
            this SimultaneousLoginV3.SimultaneousLoginV3Builder builder,
            string nativePlatform,
            string nativePlatformTicket
        )
        {
            SimultaneousLoginV3 op = builder.Build(
                nativePlatform,
                nativePlatformTicket
            );

            return ((Iam.Wrapper.OAuth20)builder.WrapperObject!).SimultaneousLoginV3(op);
        }
        public static async Task<Iam.Model.OauthmodelTokenResponseV3?> ExecuteAsync(
            this SimultaneousLoginV3.SimultaneousLoginV3Builder builder,
            string nativePlatform,
            string nativePlatformTicket
        )
        {
            SimultaneousLoginV3 op = builder.Build(
                nativePlatform,
                nativePlatformTicket
            );

            return await ((Iam.Wrapper.OAuth20)builder.WrapperObject!).SimultaneousLoginV3Async(op);
        }
        public static Iam.Model.OauthmodelTokenWithDeviceCookieResponseV3? Execute(
            this TokenGrantV3.TokenGrantV3Builder builder,
            string grantType
        )
        {
            TokenGrantV3 op = builder.Build(
                grantType
            );

            return ((Iam.Wrapper.OAuth20)builder.WrapperObject!).TokenGrantV3(op);
        }
        public static async Task<Iam.Model.OauthmodelTokenWithDeviceCookieResponseV3?> ExecuteAsync(
            this TokenGrantV3.TokenGrantV3Builder builder,
            string grantType
        )
        {
            TokenGrantV3 op = builder.Build(
                grantType
            );

            return await ((Iam.Wrapper.OAuth20)builder.WrapperObject!).TokenGrantV3Async(op);
        }
        public static Iam.Model.OauthmodelTokenResponseV3? Execute(
            this VerifyTokenV3.VerifyTokenV3Builder builder,
            string token
        )
        {
            VerifyTokenV3 op = builder.Build(
                token
            );

            return ((Iam.Wrapper.OAuth20)builder.WrapperObject!).VerifyTokenV3(op);
        }
        public static async Task<Iam.Model.OauthmodelTokenResponseV3?> ExecuteAsync(
            this VerifyTokenV3.VerifyTokenV3Builder builder,
            string token
        )
        {
            VerifyTokenV3 op = builder.Build(
                token
            );

            return await ((Iam.Wrapper.OAuth20)builder.WrapperObject!).VerifyTokenV3Async(op);
        }
    }
}