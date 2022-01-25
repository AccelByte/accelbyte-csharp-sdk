using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class AdminUserEligibilities {
        private readonly AccelByteSDK _sdk;

        public AdminUserEligibilities(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.RetrieveUserEligibilitiesIndirectResponse? AdminRetrieveEligibilities(AdminRetrieveEligibilities input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}