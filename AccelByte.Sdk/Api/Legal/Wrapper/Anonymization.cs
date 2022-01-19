using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class Anonymization {
        private readonly AccelByteSDK _sdk;

        public Anonymization(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public void AnonymizeUserAgreement(AnonymizeUserAgreement input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}