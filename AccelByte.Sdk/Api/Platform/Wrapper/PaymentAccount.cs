using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class PaymentAccount {
        private readonly AccelByteSDK _sdk;

        public PaymentAccount(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public List<Model.PaymentAccount>? PublicGetPaymentAccounts(PublicGetPaymentAccounts input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicDeletePaymentAccount(PublicDeletePaymentAccount input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}