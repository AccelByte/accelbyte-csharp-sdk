using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class Agreement {
        private readonly AccelByteSDK _sdk;

        public Agreement(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public List<Model.RetrieveAcceptedAgreementResponse>? RetrieveAcceptedAgreements(RetrieveAcceptedAgreements input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.PagedRetrieveUserAcceptedAgreementResponse>? RetrieveAllUsersByPolicyVersion(RetrieveAllUsersByPolicyVersion input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void ChangePreferenceConsent(ChangePreferenceConsent input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AcceptVersionedPolicy(AcceptVersionedPolicy input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrieveAcceptedAgreementResponse>? RetrieveAgreementsPublic(RetrieveAgreementsPublic input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AcceptAgreementResponse? BulkAcceptVersionedPolicy(BulkAcceptVersionedPolicy input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AcceptAgreementResponse? IndirectBulkAcceptVersionedPolicyV2(IndirectBulkAcceptVersionedPolicyV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AcceptAgreementResponse? IndirectBulkAcceptVersionedPolicy1(IndirectBulkAcceptVersionedPolicy1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}