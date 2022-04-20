// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class OAuth
    {
        private readonly AccelByteSDK _sdk;

        public OAuth(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public Authorization.AuthorizationBuilder AuthorizationOp
        {
            get { return Operation.Authorization.Builder.SetWrapperObject(this); }
        }
        public GetJWKS.GetJWKSBuilder GetJWKSOp
        {
            get { return Operation.GetJWKS.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public PlatformTokenRequestHandler.PlatformTokenRequestHandlerBuilder PlatformTokenRequestHandlerOp
        {
            get { return Operation.PlatformTokenRequestHandler.Builder.SetWrapperObject(this); }
        }
        public RevokeUser.RevokeUserBuilder RevokeUserOp
        {
            get { return Operation.RevokeUser.Builder.SetWrapperObject(this); }
        }
        public GetRevocationList.GetRevocationListBuilder GetRevocationListOp
        {
            get { return Operation.GetRevocationList.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public RevokeToken.RevokeTokenBuilder RevokeTokenOp
        {
            get { return Operation.RevokeToken.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public RevokeAUser.RevokeAUserBuilder RevokeAUserOp
        {
            get { return Operation.RevokeAUser.Builder.SetWrapperObject(this); }
        }
        public TokenGrant.TokenGrantBuilder TokenGrantOp
        {
            get { return Operation.TokenGrant.Builder.SetWrapperObject(this); }
        }
        public VerifyToken.VerifyTokenBuilder VerifyTokenOp
        {
            get { return Operation.VerifyToken.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public string Authorization(Authorization input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthcommonJWKSet? GetJWKS(GetJWKS input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.OauthmodelTokenResponse? PlatformTokenRequestHandler(PlatformTokenRequestHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public void RevokeUser(RevokeUser input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthapiRevocationList? GetRevocationList(GetRevocationList input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void RevokeToken(RevokeToken input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void RevokeAUser(RevokeAUser input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public Model.OauthmodelTokenResponse? TokenGrant(TokenGrant input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponse? VerifyToken(VerifyToken input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}