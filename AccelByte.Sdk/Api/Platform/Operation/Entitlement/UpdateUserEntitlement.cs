using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class UpdateUserEntitlement : AccelByte.Sdk.Core.Operation
    {
        public UpdateUserEntitlement(
            string entitlementId,            
            string namespace_,            
            string userId,            
            Model.EntitlementUpdate body            
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.EntitlementInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EntitlementInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}