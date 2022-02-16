// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class OAuth {
        private readonly AccelByteSDK _sdk;

        public OAuth(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
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