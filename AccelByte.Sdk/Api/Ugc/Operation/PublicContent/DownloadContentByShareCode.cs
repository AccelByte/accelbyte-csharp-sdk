using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    public class DownloadContentByShareCode : AccelByte.Sdk.Core.Operation
    {
        public DownloadContentByShareCode(
            string namespace_,            
            string shareCode            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["shareCode"] = shareCode;
            
            
            
            
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/contents/sharecodes/{shareCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json","application/octet-stream" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsContentDownloadResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}