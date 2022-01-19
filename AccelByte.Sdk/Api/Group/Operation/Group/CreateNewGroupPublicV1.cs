using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Group.Operation
{
    public class CreateNewGroupPublicV1 : AccelByte.Sdk.Core.Operation
    {
        public CreateNewGroupPublicV1(
            string namespace_,            
            Model.ModelsPublicCreateNewGroupRequestV1 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/groups";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsGroupResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}