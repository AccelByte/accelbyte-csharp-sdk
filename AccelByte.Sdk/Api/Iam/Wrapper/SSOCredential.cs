// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class SSOCredential {
        private readonly AccelByteSDK _sdk;

        public SSOCredential(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public List<Model.ModelSSOPlatformCredentialResponse>? RetrieveAllSSOLoginPlatformCredentialV3(RetrieveAllSSOLoginPlatformCredentialV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelSSOPlatformCredentialResponse? RetrieveSSOLoginPlatformCredential(RetrieveSSOLoginPlatformCredential input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelSSOPlatformCredentialResponse? AddSSOLoginPlatformCredential(AddSSOLoginPlatformCredential input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteSSOLoginPlatformCredentialV3(DeleteSSOLoginPlatformCredentialV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelSSOPlatformCredentialResponse? UpdateSSOPlatformCredential(UpdateSSOPlatformCredential input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}