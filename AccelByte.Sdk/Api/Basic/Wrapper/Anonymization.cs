using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Basic.Wrapper
{
    public class Anonymization {
        private readonly AccelByteSDK _sdk;

        public Anonymization(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public void AnonymizeUserProfile(AnonymizeUserProfile input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}