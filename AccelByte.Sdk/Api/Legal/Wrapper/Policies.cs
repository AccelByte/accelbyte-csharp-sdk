using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class Policies {
        private readonly AccelByteSDK _sdk;

        public Policies(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public List<Model.RetrievePolicyResponse>? RetrievePolicies(RetrievePolicies input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UpdatePolicy(UpdatePolicy input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SetDefaultPolicy1(SetDefaultPolicy1 input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrievePolicyPublicResponse>? RetrieveLatestPolicies(RetrieveLatestPolicies input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrievePolicyPublicResponse>? RetrieveLatestPoliciesPublic(RetrieveLatestPoliciesPublic input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrievePolicyPublicResponse>? RetrieveLatestPoliciesByNamespaceAndCountryPublic(RetrieveLatestPoliciesByNamespaceAndCountryPublic input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}