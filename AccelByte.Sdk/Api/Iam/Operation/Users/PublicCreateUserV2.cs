using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class PublicCreateUserV2 : AccelByte.Sdk.Core.Operation
    {
        public PublicCreateUserV2(
            string namespace_,            
            Model.ModelUserCreateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v2/public/namespaces/{namespace}/users";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelUserCreateResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserCreateResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}