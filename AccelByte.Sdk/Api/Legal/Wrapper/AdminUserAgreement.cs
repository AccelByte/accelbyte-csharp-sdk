using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class AdminUserAgreement {
        private readonly AccelByteSDK _sdk;

        public AdminUserAgreement(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.AcceptAgreementResponse? IndirectBulkAcceptVersionedPolicy(IndirectBulkAcceptVersionedPolicy input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}