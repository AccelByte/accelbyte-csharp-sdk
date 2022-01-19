using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    public class AdminUploadContentScreenshot : AccelByte.Sdk.Core.Operation
    {
        public AdminUploadContentScreenshot(
            string contentId,            
            string namespace_,            
            Model.ModelsCreateScreenshotRequest body            
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/screenshots";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsCreateScreenshotResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateScreenshotResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}