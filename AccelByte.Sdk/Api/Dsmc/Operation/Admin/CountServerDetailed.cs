using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    public class CountServerDetailed : AccelByte.Sdk.Core.Operation
    {
        public CountServerDetailed(
            string namespace_,            
            string? region            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (region != null) QueryParams["region"] = region;
            
            
            
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/servers/count/detailed";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsDetailedCountServerResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDetailedCountServerResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}