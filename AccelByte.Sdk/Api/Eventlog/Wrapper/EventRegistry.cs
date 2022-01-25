using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Eventlog.Wrapper
{
    public class EventRegistry {
        private readonly AccelByteSDK _sdk;

        public EventRegistry(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.ModelsEventRegistry? GetRegisteredEventsHandler(GetRegisteredEventsHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void RegisterEventHandler(RegisterEventHandler input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsEventRegistry? GetRegisteredEventIDHandler(GetRegisteredEventIDHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateEventRegistryHandler(UpdateEventRegistryHandler input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UnregisterEventIDHandler(UnregisterEventIDHandler input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsEventRegistry? GetRegisteredEventsByEventTypeHandler(GetRegisteredEventsByEventTypeHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}