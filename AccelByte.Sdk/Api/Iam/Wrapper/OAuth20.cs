// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class OAuth20
    {
        private readonly AccelByteSDK _sdk;

        public OAuth20(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminRetrieveUserThirdPartyPlatformTokenV3.AdminRetrieveUserThirdPartyPlatformTokenV3Builder AdminRetrieveUserThirdPartyPlatformTokenV3Op
        {
            get { return Operation.AdminRetrieveUserThirdPartyPlatformTokenV3.Builder.SetWrapperObject(this); }
        }
        public RevokeUserV3.RevokeUserV3Builder RevokeUserV3Op
        {
            get { return Operation.RevokeUserV3.Builder.SetWrapperObject(this); }
        }
        public AuthorizeV3.AuthorizeV3Builder AuthorizeV3Op
        {
            get { return Operation.AuthorizeV3.Builder.SetWrapperObject(this); }
        }
        public TokenIntrospectionV3.TokenIntrospectionV3Builder TokenIntrospectionV3Op
        {
            get { return Operation.TokenIntrospectionV3.Builder.SetWrapperObject(this); }
        }
        public GetJWKSV3.GetJWKSV3Builder GetJWKSV3Op
        {
            get { return Operation.GetJWKSV3.Builder.SetWrapperObject(this); }
        }
        public Change2faMethod.Change2faMethodBuilder Change2faMethodOp
        {
            get { return Operation.Change2faMethod.Builder.SetWrapperObject(this); }
        }
        public Verify2faCode.Verify2faCodeBuilder Verify2faCodeOp
        {
            get { return Operation.Verify2faCode.Builder.SetWrapperObject(this); }
        }
        public RetrieveUserThirdPartyPlatformTokenV3.RetrieveUserThirdPartyPlatformTokenV3Builder RetrieveUserThirdPartyPlatformTokenV3Op
        {
            get { return Operation.RetrieveUserThirdPartyPlatformTokenV3.Builder.SetWrapperObject(this); }
        }
        public AuthCodeRequestV3.AuthCodeRequestV3Builder AuthCodeRequestV3Op
        {
            get { return Operation.AuthCodeRequestV3.Builder.SetWrapperObject(this); }
        }
        public PlatformTokenGrantV3.PlatformTokenGrantV3Builder PlatformTokenGrantV3Op
        {
            get { return Operation.PlatformTokenGrantV3.Builder.SetWrapperObject(this); }
        }
        public GetRevocationListV3.GetRevocationListV3Builder GetRevocationListV3Op
        {
            get { return Operation.GetRevocationListV3.Builder.SetWrapperObject(this); }
        }
        public TokenRevocationV3.TokenRevocationV3Builder TokenRevocationV3Op
        {
            get { return Operation.TokenRevocationV3.Builder.SetWrapperObject(this); }
        }
        public TokenGrantV3.TokenGrantV3Builder TokenGrantV3Op
        {
            get { return Operation.TokenGrantV3.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.OauthmodelTokenThirdPartyResponse? AdminRetrieveUserThirdPartyPlatformTokenV3(AdminRetrieveUserThirdPartyPlatformTokenV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void RevokeUserV3(RevokeUserV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public string AuthorizeV3(AuthorizeV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenIntrospectResponse? TokenIntrospectionV3(TokenIntrospectionV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthcommonJWKSet? GetJWKSV3(GetJWKSV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void Change2faMethod(Change2faMethod input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponseV3? Verify2faCode(Verify2faCode input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenThirdPartyResponse? RetrieveUserThirdPartyPlatformTokenV3(RetrieveUserThirdPartyPlatformTokenV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public string AuthCodeRequestV3(AuthCodeRequestV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponse? PlatformTokenGrantV3(PlatformTokenGrantV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthapiRevocationList? GetRevocationListV3(GetRevocationListV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void TokenRevocationV3(TokenRevocationV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponseV3? TokenGrantV3(TokenGrantV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class OAuth20_OperationExtensions
    {
        public static Model.OauthmodelTokenThirdPartyResponse? Execute(
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

            return ((OAuth20)builder.WrapperObject!).AdminRetrieveUserThirdPartyPlatformTokenV3(op);
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

            ((OAuth20)builder.WrapperObject!).RevokeUserV3(op);
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

            return ((OAuth20)builder.WrapperObject!).AuthorizeV3(op);
        }

        public static Model.OauthmodelTokenIntrospectResponse? Execute(
            this TokenIntrospectionV3.TokenIntrospectionV3Builder builder,
            string token
        )
        {
            TokenIntrospectionV3 op = builder.Build(
                token
            );

            return ((OAuth20)builder.WrapperObject!).TokenIntrospectionV3(op);
        }

        public static Model.OauthcommonJWKSet? Execute(
            this GetJWKSV3.GetJWKSV3Builder builder
        )
        {
            GetJWKSV3 op = builder.Build(
            );

            return ((OAuth20)builder.WrapperObject!).GetJWKSV3(op);
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

            ((OAuth20)builder.WrapperObject!).Change2faMethod(op);
        }

        public static Model.OauthmodelTokenResponseV3? Execute(
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

            return ((OAuth20)builder.WrapperObject!).Verify2faCode(op);
        }

        public static Model.OauthmodelTokenThirdPartyResponse? Execute(
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

            return ((OAuth20)builder.WrapperObject!).RetrieveUserThirdPartyPlatformTokenV3(op);
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

            return ((OAuth20)builder.WrapperObject!).AuthCodeRequestV3(op);
        }

        public static Model.OauthmodelTokenResponse? Execute(
            this PlatformTokenGrantV3.PlatformTokenGrantV3Builder builder,
            string platformId
        )
        {
            PlatformTokenGrantV3 op = builder.Build(
                platformId
            );

            return ((OAuth20)builder.WrapperObject!).PlatformTokenGrantV3(op);
        }

        public static Model.OauthapiRevocationList? Execute(
            this GetRevocationListV3.GetRevocationListV3Builder builder
        )
        {
            GetRevocationListV3 op = builder.Build(
            );

            return ((OAuth20)builder.WrapperObject!).GetRevocationListV3(op);
        }

        public static void Execute(
            this TokenRevocationV3.TokenRevocationV3Builder builder,
            string token
        )
        {
            TokenRevocationV3 op = builder.Build(
                token
            );

            ((OAuth20)builder.WrapperObject!).TokenRevocationV3(op);
        }

        public static Model.OauthmodelTokenResponseV3? Execute(
            this TokenGrantV3.TokenGrantV3Builder builder,
            string grantType
        )
        {
            TokenGrantV3 op = builder.Build(
                grantType
            );

            return ((OAuth20)builder.WrapperObject!).TokenGrantV3(op);
        }

    }
}