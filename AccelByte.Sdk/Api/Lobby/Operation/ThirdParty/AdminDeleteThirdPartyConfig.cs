using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    public class AdminDeleteThirdPartyConfig : AccelByte.Sdk.Core.Operation
    {
        public AdminDeleteThirdPartyConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
        }

        public override string Path => "/lobby/v1/admin/thirdparty/namespaces/{namespace}/config/steam";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public string? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return JsonSerializer.Deserialize<string>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}