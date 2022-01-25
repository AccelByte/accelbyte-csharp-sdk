using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class PaymentDedicated {
        private readonly AccelByteSDK _sdk;

        public PaymentDedicated(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.PaymentOrderCreateResult? CreatePaymentOrderByDedicated(CreatePaymentOrderByDedicated input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderRefundResult? RefundPaymentOrderByDedicated(RefundPaymentOrderByDedicated input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderSyncResult? SyncPaymentOrders(SyncPaymentOrders input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}