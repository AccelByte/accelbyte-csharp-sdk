using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// querySubscriptions
    ///
    /// Query subscriptions.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:SUBSCRIPTION", action=2 (READ)
    ///   *  Returns : paginated subscriptions
    /// </summary>
    public class QuerySubscriptions : AccelByte.Sdk.Core.Operation
    {
        public QuerySubscriptions(
            string namespace_,            
            string? chargeStatus,            
            string? itemId,            
            int? limit,            
            int? offset,            
            string? sku,            
            string? status,            
            string? subscribedBy,            
            string? userId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (chargeStatus != null) QueryParams["chargeStatus"] = chargeStatus;
            if (itemId != null) QueryParams["itemId"] = itemId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sku != null) QueryParams["sku"] = sku;
            if (status != null) QueryParams["status"] = status;
            if (subscribedBy != null) QueryParams["subscribedBy"] = subscribedBy;
            if (userId != null) QueryParams["userId"] = userId;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/subscriptions";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.SubscriptionPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.SubscriptionPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.SubscriptionPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}