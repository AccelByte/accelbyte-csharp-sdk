using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    public class DeleteContentScreenshot : AccelByte.Sdk.Core.Operation
    {
        public DeleteContentScreenshot(
            string contentId,            
            string namespace_,            
            string screenshotId,            
            string userId            
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["screenshotId"] = screenshotId;
            PathParams["userId"] = userId;
            
            
            
            
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots/{screenshotId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json","application/octet-stream" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}