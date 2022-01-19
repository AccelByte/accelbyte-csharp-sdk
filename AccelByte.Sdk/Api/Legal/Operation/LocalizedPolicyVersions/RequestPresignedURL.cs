using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    public class RequestPresignedURL : AccelByte.Sdk.Core.Operation
    {
        public RequestPresignedURL(
            string localizedPolicyVersionId,            
            Model.UploadPolicyVersionAttachmentRequest body            
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/agreement/admin/localized-policy-versions/{localizedPolicyVersionId}/attachments";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.UploadLocalizedPolicyVersionAttachmentResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UploadLocalizedPolicyVersionAttachmentResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}