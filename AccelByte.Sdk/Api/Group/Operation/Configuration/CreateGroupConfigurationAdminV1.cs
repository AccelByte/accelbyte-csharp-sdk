using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Group.Operation
{
    public class CreateGroupConfigurationAdminV1 : AccelByte.Sdk.Core.Operation
    {
        public CreateGroupConfigurationAdminV1(
            string namespace_,            
            Model.ModelsCreateGroupConfigurationRequestV1 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/configuration";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsCreateGroupConfigurationResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateGroupConfigurationResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}