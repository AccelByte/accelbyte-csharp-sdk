using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    public class AdminUpdateConfigV1 : AccelByte.Sdk.Core.Operation
    {
        public AdminUpdateConfigV1(
            string namespace_,            
            Model.ModelsConfigReq body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/lobby/v1/admin/config/namespaces/{namespace}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsConfigReq? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsConfigReq>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}