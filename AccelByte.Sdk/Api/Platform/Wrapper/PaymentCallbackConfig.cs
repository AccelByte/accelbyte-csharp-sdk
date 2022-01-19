using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class PaymentCallbackConfig {
        private readonly AccelByteSDK _sdk;

        public PaymentCallbackConfig(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.PaymentCallbackConfigInfo? GetPaymentCallbackConfig(GetPaymentCallbackConfig input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentCallbackConfigInfo? UpdatePaymentCallbackConfig(UpdatePaymentCallbackConfig input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}