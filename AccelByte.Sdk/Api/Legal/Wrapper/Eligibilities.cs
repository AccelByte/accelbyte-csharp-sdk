using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class Eligibilities {
        private readonly AccelByteSDK _sdk;

        public Eligibilities(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public List<Model.RetrieveUserEligibilitiesResponse>? RetrieveEligibilitiesPublic(RetrieveEligibilitiesPublic input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RetrieveUserEligibilitiesIndirectResponse? RetrieveEligibilitiesPublicIndirect(RetrieveEligibilitiesPublicIndirect input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}