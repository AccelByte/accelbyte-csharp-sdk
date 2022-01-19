using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    public class HandlerV3Healthz : AccelByte.Sdk.Core.Operation
    {
        public HandlerV3Healthz(
        )
        {
            
            
            
            
        }

        public override string Path => "/matchmaking/healthz";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] {  };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}