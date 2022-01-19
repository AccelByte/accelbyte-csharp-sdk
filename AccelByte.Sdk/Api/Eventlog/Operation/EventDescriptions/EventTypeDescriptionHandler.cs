using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Eventlog.Operation
{
    public class EventTypeDescriptionHandler : AccelByte.Sdk.Core.Operation
    {
        public EventTypeDescriptionHandler(
        )
        {
            
            
            
            
        }

        public override string Path => "/event/descriptions/eventType";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsMultipleEventType? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMultipleEventType>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}