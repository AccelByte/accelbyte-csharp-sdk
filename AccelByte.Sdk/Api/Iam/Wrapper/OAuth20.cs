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
}