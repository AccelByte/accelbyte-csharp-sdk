using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class CreateCodes : AccelByte.Sdk.Core.Operation
    {
        public CreateCodes(
            string campaignId,            
            string namespace_,            
            Model.CodeCreate body            
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] {  };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.CodeCreateResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CodeCreateResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}