using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class PublicGetItemByAppId : AccelByte.Sdk.Core.Operation
    {
        public PublicGetItemByAppId(
            string namespace_,            
            string? language,            
            string? region,            
            string? storeId,            
            string appId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (language != null) QueryParams["language"] = language;
            if (region != null) QueryParams["region"] = region;
            if (storeId != null) QueryParams["storeId"] = storeId;
            if (appId != null) QueryParams["appId"] = appId;
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/items/byAppId";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ItemInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}