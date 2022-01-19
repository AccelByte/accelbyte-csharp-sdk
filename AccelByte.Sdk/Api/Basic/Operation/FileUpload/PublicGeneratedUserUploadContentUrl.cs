using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    public class PublicGeneratedUserUploadContentUrl : AccelByte.Sdk.Core.Operation
    {
        public PublicGeneratedUserUploadContentUrl(
            string namespace_,            
            string userId,            
            string fileType            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (fileType != null) QueryParams["fileType"] = fileType;
            
            
            
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/{userId}/files";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.FileUploadUrlInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FileUploadUrlInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}