using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Eventlog.Wrapper
{
    public class EventDescriptions {
        private readonly AccelByteSDK _sdk;

        public EventDescriptions(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.ModelsMultipleAgentType? AgentTypeDescriptionHandler(AgentTypeDescriptionHandler input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMultipleAgentType? SpecificAgentTypeDescriptionHandler(SpecificAgentTypeDescriptionHandler input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMultipleEventID? EventIDDescriptionHandler(EventIDDescriptionHandler input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMultipleEventID? SpecificEventIDDescriptionHandler(SpecificEventIDDescriptionHandler input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMultipleEventLevel? EventLevelDescriptionHandler(EventLevelDescriptionHandler input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMultipleEventLevel? SpecificEventLevelDescriptionHandler(SpecificEventLevelDescriptionHandler input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMultipleEventType? EventTypeDescriptionHandler(EventTypeDescriptionHandler input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMultipleEventType? SpecificEventTypeDescriptionHandler(SpecificEventTypeDescriptionHandler input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMultipleUX? UXNameDescriptionHandler(UXNameDescriptionHandler input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMultipleUX? SpecificUXDescriptionHandler(SpecificUXDescriptionHandler input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}