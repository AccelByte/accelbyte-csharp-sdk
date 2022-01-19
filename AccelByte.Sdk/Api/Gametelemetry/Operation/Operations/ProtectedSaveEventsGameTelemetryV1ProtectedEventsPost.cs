using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Gametelemetry.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Gametelemetry.Operation
{
    public class ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost : AccelByte.Sdk.Core.Operation
    {
        public ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost(
            List<Model.TelemetryBody> body            
        )
        {
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/game-telemetry/v1/protected/events";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}