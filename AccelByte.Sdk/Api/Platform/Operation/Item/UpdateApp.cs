using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class UpdateApp : AccelByte.Sdk.Core.Operation
    {
        public UpdateApp(
            string itemId,            
            string namespace_,            
            string storeId,            
            Model.AppUpdate body            
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            if (storeId != null) QueryParams["storeId"] = storeId;
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/{itemId}/app";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.FullAppInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullAppInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}