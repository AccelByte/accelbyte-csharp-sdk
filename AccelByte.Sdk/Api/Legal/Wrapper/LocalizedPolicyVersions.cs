using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class LocalizedPolicyVersions {
        private readonly AccelByteSDK _sdk;

        public LocalizedPolicyVersions(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public List<Model.RetrieveLocalizedPolicyVersionResponse>? RetrieveLocalizedPolicyVersions(RetrieveLocalizedPolicyVersions input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CreateLocalizedPolicyVersionResponse? CreateLocalizedPolicyVersion(CreateLocalizedPolicyVersion input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UpdateLocalizedPolicyVersionResponse? RetrieveSingleLocalizedPolicyVersion(RetrieveSingleLocalizedPolicyVersion input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UpdateLocalizedPolicyVersionResponse? UpdateLocalizedPolicyVersion(UpdateLocalizedPolicyVersion input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UploadLocalizedPolicyVersionAttachmentResponse? RequestPresignedURL(RequestPresignedURL input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SetDefaultPolicy(SetDefaultPolicy input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RetrieveLocalizedPolicyVersionPublicResponse? RetrieveSingleLocalizedPolicyVersion1(RetrieveSingleLocalizedPolicyVersion1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}