using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class PolicyVersions {
        private readonly AccelByteSDK _sdk;

        public PolicyVersions(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.UpdatePolicyVersionResponse? UpdatePolicyVersion(UpdatePolicyVersion input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublishPolicyVersion(PublishPolicyVersion input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrievePolicyVersionResponse>? RetrieveSinglePolicyVersion(RetrieveSinglePolicyVersion input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CreatePolicyVersionResponse? CreatePolicyVersion(CreatePolicyVersion input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrievePolicyVersionResponse>? RetrievePolicyVersions(RetrievePolicyVersions input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}