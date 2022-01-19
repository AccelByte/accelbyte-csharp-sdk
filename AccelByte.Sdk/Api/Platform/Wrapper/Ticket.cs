using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Ticket {
        private readonly AccelByteSDK _sdk;

        public Ticket(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.TicketDynamicInfo? GetTicketDynamic(GetTicketDynamic input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DecreaseTicketSale(DecreaseTicketSale input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TicketBoothID? GetTicketBoothID(GetTicketBoothID input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TicketSaleIncrementResult? IncreaseTicketSale(IncreaseTicketSale input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TicketAcquireResult? AcquireUserTicket(AcquireUserTicket input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}