using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class PublicQueryUserEntitlements : AccelByte.Sdk.Core.Operation
    {
        public PublicQueryUserEntitlements(
            string namespace_,            
            string userId,            
            string? appType,            
            string? entitlementClazz,            
            string? entitlementName,            
            List<string>? itemId,            
            int? limit,            
            int? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (appType != null) QueryParams["appType"] = appType;
            if (entitlementClazz != null) QueryParams["entitlementClazz"] = entitlementClazz;
            if (entitlementName != null) QueryParams["entitlementName"] = entitlementName;
            if (itemId != null) QueryParams["itemId"] = Convert.ToString(itemId)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.EntitlementPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EntitlementPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}