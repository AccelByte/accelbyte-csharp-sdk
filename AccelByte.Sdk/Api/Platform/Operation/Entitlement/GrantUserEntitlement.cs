using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class GrantUserEntitlement : AccelByte.Sdk.Core.Operation
    {
        public GrantUserEntitlement(
            string namespace_,            
            string userId,            
            List<Model.EntitlementGrant> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.StackableEntitlementInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.StackableEntitlementInfo>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}