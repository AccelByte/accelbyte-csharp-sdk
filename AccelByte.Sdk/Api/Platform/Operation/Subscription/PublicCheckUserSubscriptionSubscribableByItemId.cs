using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// publicCheckUserSubscriptionSubscribableByItemId
    ///
    /// Check user subscription subscribable by itemId, ACTIVE USER subscription can't
    /// do subscribe again.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SUBSCRIPTION", action=2 (READ)
    ///   *  Returns : subscribable info
    /// </summary>
    public class PublicCheckUserSubscriptionSubscribableByItemId : AccelByte.Sdk.Core.Operation
    {
        public PublicCheckUserSubscriptionSubscribableByItemId(
            string namespace_,            
            string userId,            
            string itemId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (itemId != null) QueryParams["itemId"] = itemId;
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/subscriptions/subscribable/byItemId";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.Subscribable? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.Subscribable>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.Subscribable>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}