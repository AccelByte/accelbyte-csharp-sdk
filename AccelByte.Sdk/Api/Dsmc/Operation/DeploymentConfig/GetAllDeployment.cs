using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    public class GetAllDeployment : AccelByte.Sdk.Core.Operation
    {
        public GetAllDeployment(
            string namespace_,            
            long? count,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (count != null) QueryParams["count"] = Convert.ToString(count)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/deployments";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsListDeploymentResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListDeploymentResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}