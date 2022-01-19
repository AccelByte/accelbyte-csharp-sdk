using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class PublicGetEntitlementOwnershipToken : AccelByte.Sdk.Core.Operation
    {
        public PublicGetEntitlementOwnershipToken(
            string namespace_,            
            List<string>? appIds,            
            List<string>? itemIds,            
            List<string>? skus            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (appIds != null) QueryParams["appIds"] = Convert.ToString(appIds)!;
            if (itemIds != null) QueryParams["itemIds"] = Convert.ToString(itemIds)!;
            if (skus != null) QueryParams["skus"] = Convert.ToString(skus)!;
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/me/entitlements/ownershipToken";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.OwnershipToken? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OwnershipToken>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}