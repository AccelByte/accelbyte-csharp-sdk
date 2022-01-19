using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class RevokeUserEntitlements : AccelByte.Sdk.Core.Operation
    {
        public RevokeUserEntitlements(
            string namespace_,            
            string userId,            
            string entitlementIds            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (entitlementIds != null) QueryParams["entitlementIds"] = entitlementIds;
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/revoke/byIds";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.BulkOperationResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.BulkOperationResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}