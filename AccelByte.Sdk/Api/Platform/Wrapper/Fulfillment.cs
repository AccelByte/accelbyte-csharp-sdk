using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Fulfillment {
        private readonly AccelByteSDK _sdk;

        public Fulfillment(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.FulfillmentHistoryPagingSlicedResult? QueryFulfillmentHistories(QueryFulfillmentHistories input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentResult? FulfillItem(FulfillItem input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentResult? RedeemCode(RedeemCode input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentResult? PublicRedeemCode(PublicRedeemCode input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}