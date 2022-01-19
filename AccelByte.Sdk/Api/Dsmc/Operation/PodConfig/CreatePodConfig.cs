using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    public class CreatePodConfig : AccelByte.Sdk.Core.Operation
    {
        public CreatePodConfig(
            string name,            
            string namespace_,            
            Model.ModelsCreatePodConfigRequest body            
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/pods/{name}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsPodConfigRecord? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPodConfigRecord>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}