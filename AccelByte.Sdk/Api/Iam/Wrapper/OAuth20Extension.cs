// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class OAuth20Extension
    {
        private readonly AccelByteSDK _sdk;

        public OAuth20Extension(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public UserAuthenticationV3.UserAuthenticationV3Builder UserAuthenticationV3Op
        {
            get { return Operation.UserAuthenticationV3.Builder.SetWrapperObject(this); }
        }
        public GetCountryLocationV3.GetCountryLocationV3Builder GetCountryLocationV3Op
        {
            get { return Operation.GetCountryLocationV3.Builder.SetWrapperObject(this); }
        }
        public Logout.LogoutBuilder LogoutOp
        {
            get { return Operation.Logout.Builder.SetWrapperObject(this); }
        }
        public PlatformAuthenticationV3.PlatformAuthenticationV3Builder PlatformAuthenticationV3Op
        {
            get { return Operation.PlatformAuthenticationV3.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public string UserAuthenticationV3(UserAuthenticationV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelCountryLocationResponse? GetCountryLocationV3(GetCountryLocationV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void Logout(Logout input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public string PlatformAuthenticationV3(PlatformAuthenticationV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}