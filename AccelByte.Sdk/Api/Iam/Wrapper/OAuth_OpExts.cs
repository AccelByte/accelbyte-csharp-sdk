// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class IamOAuth_OpExts
    {
        public static string Execute(
            this Authorization.AuthorizationBuilder builder,
            string clientId,
            string redirectUri,
            string responseType
        )
        {
            Authorization op = builder.Build(
                clientId,
                redirectUri,
                responseType
            );

            return ((Iam.Wrapper.OAuth)builder.WrapperObject!).Authorization(op);
        }

        public static Iam.Model.OauthcommonJWKSet? Execute(
            this GetJWKS.GetJWKSBuilder builder
        )
        {
            GetJWKS op = builder.Build(
            );

            return ((Iam.Wrapper.OAuth)builder.WrapperObject!).GetJWKS(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Iam.Model.OauthmodelTokenResponse? Execute(
            this PlatformTokenRequestHandler.PlatformTokenRequestHandlerBuilder builder,
            string namespace_,
            string platformId
        )
        {
            PlatformTokenRequestHandler op = builder.Build(
                namespace_,
                platformId
            );

            return ((Iam.Wrapper.OAuth)builder.WrapperObject!).PlatformTokenRequestHandler(op);
        }

        public static void Execute(
            this RevokeUser.RevokeUserBuilder builder,
            string namespace_,
            string userId
        )
        {
            RevokeUser op = builder.Build(
                namespace_,
                userId
            );

            ((Iam.Wrapper.OAuth)builder.WrapperObject!).RevokeUser(op);
        }

        public static Iam.Model.OauthapiRevocationList? Execute(
            this GetRevocationList.GetRevocationListBuilder builder
        )
        {
            GetRevocationList op = builder.Build(
            );

            return ((Iam.Wrapper.OAuth)builder.WrapperObject!).GetRevocationList(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static void Execute(
            this RevokeToken.RevokeTokenBuilder builder,
            string token
        )
        {
            RevokeToken op = builder.Build(
                token
            );

            ((Iam.Wrapper.OAuth)builder.WrapperObject!).RevokeToken(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static void Execute(
            this RevokeAUser.RevokeAUserBuilder builder,
            string userID
        )
        {
            RevokeAUser op = builder.Build(
                userID
            );

            ((Iam.Wrapper.OAuth)builder.WrapperObject!).RevokeAUser(op);
        }

        public static Iam.Model.OauthmodelTokenResponse? Execute(
            this TokenGrant.TokenGrantBuilder builder,
            string grantType
        )
        {
            TokenGrant op = builder.Build(
                grantType
            );

            return ((Iam.Wrapper.OAuth)builder.WrapperObject!).TokenGrant(op);
        }

        public static Iam.Model.OauthmodelTokenResponse? Execute(
            this VerifyToken.VerifyTokenBuilder builder,
            string token
        )
        {
            VerifyToken op = builder.Build(
                token
            );

            return ((Iam.Wrapper.OAuth)builder.WrapperObject!).VerifyToken(op);
        }

    }
}