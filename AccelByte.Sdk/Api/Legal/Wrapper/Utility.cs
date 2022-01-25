using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class Utility {
        private readonly AccelByteSDK _sdk;

        public Utility(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.LegalReadinessStatusResponse? CheckReadiness(CheckReadiness input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}