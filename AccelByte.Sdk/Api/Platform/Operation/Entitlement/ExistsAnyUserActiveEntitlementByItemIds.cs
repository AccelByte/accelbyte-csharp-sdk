using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class ExistsAnyUserActiveEntitlementByItemIds : AccelByte.Sdk.Core.Operation
    {
        public ExistsAnyUserActiveEntitlementByItemIds(
            string namespace_,            
            string userId,            
            List<string> itemIds            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (itemIds != null) QueryParams["itemIds"] = itemIds;
            
            
            CollectionFormatMap["itemIds"] = "multi";
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/anyOf";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.Ownership? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.Ownership>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}