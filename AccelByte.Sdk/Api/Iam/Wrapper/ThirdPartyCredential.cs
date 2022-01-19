using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class ThirdPartyCredential {
        private readonly AccelByteSDK _sdk;

        public ThirdPartyCredential(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public List<Model.ModelThirdPartyLoginPlatformCredentialResponse>? RetrieveAllThirdPartyLoginPlatformCredentialV3(RetrieveAllThirdPartyLoginPlatformCredentialV3 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelThirdPartyLoginPlatformCredentialResponse>? RetrieveAllActiveThirdPartyLoginPlatformCredentialV3(RetrieveAllActiveThirdPartyLoginPlatformCredentialV3 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelThirdPartyLoginPlatformCredentialResponse? RetrieveThirdPartyLoginPlatformCredentialV3(RetrieveThirdPartyLoginPlatformCredentialV3 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelThirdPartyLoginPlatformCredentialResponse? AddThirdPartyLoginPlatformCredentialV3(AddThirdPartyLoginPlatformCredentialV3 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteThirdPartyLoginPlatformCredentialV3(DeleteThirdPartyLoginPlatformCredentialV3 input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelThirdPartyLoginPlatformCredentialResponse? UpdateThirdPartyLoginPlatformCredentialV3(UpdateThirdPartyLoginPlatformCredentialV3 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelPublicThirdPartyPlatformInfo>? RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3(RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}