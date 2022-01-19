using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class ListCategoriesBasic : AccelByte.Sdk.Core.Operation
    {
        public ListCategoriesBasic(
            string namespace_,            
            string? storeId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (storeId != null) QueryParams["storeId"] = storeId;
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/categories/basic";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.BasicCategoryInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.BasicCategoryInfo>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}