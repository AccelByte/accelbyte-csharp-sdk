using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class PublicListUserIDByPlatformUserIDsV3 : AccelByte.Sdk.Core.Operation
    {
        public PublicListUserIDByPlatformUserIDsV3(
            string namespace_,            
            string platformId,            
            Model.ModelPlatformUserIDRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/platforms/{platformId}/users";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.AccountcommonUserPlatforms? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonUserPlatforms>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}