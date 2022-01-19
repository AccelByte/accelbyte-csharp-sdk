using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Group.Operation
{
    public class GetGroupConfigurationAdminV1 : AccelByte.Sdk.Core.Operation
    {
        public GetGroupConfigurationAdminV1(
            string configurationCode,            
            string namespace_            
        )
        {
            PathParams["configurationCode"] = configurationCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/configuration/{configurationCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsGetGroupConfigurationResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetGroupConfigurationResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}