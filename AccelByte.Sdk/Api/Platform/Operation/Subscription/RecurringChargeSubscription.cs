using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// recurringChargeSubscription
    ///
    ///  [TEST FACILITY ONLY] Forbidden in live environment. Recurring charge
    /// subscription, it will trigger recurring charge if the USER subscription status
    /// is ACTIVE, nextBillingDate is before now and no fail recurring charge within
    /// X(default 12) hours.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:SUBSCRIPTION", action=4 (UPDATE)
    ///   *  Returns : recurring charge result
    /// </summary>
    public class RecurringChargeSubscription : AccelByte.Sdk.Core.Operation
    {
        public RecurringChargeSubscription(
            string namespace_,            
            string subscriptionId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/subscriptions/{subscriptionId}/recurring";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.RecurringChargeResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RecurringChargeResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RecurringChargeResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}