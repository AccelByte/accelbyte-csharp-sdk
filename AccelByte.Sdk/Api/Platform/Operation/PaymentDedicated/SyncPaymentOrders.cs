using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class SyncPaymentOrders : AccelByte.Sdk.Core.Operation
    {
        public SyncPaymentOrders(
            string? nextEvaluatedKey,            
            string end,            
            string start            
        )
        {
            
            if (nextEvaluatedKey != null) QueryParams["nextEvaluatedKey"] = nextEvaluatedKey;
            if (end != null) QueryParams["end"] = end;
            if (start != null) QueryParams["start"] = start;
            
            
            
        }

        public override string Path => "/platform/admin/payment/orders";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.PaymentOrderSyncResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderSyncResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}