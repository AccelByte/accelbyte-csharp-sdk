using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class OrderDedicated {
        private readonly AccelByteSDK _sdk;

        public OrderDedicated(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.OrderSyncResult? SyncOrders(SyncOrders input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}