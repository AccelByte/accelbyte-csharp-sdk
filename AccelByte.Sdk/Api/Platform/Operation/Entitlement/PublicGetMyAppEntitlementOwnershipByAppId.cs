using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// publicGetMyAppEntitlementOwnershipByAppId
    ///
    /// Get my app entitlement ownership by appId.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:ENTITLEMENT", action=2 (READ)
    ///   *  Path's namespace :
    ///     * can be filled with publisher namespace in order to get publisher namespace app entitlement ownership
    /// </summary>
    public class PublicGetMyAppEntitlementOwnershipByAppId : AccelByte.Sdk.Core.Operation
    {
        public PublicGetMyAppEntitlementOwnershipByAppId(
            string namespace_,            
            string appId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (appId != null) QueryParams["appId"] = appId;
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/me/entitlements/ownership/byAppId";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.Ownership? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.Ownership>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.Ownership>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}