using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    public class SingleAdminUpdateContentS3 : AccelByte.Sdk.Core.Operation
    {
        public SingleAdminUpdateContentS3(
            string channelId,            
            string contentId,            
            string namespace_,            
            Model.ModelsCreateContentRequestS3 body            
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/s3/{contentId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsCreateContentResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateContentResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}