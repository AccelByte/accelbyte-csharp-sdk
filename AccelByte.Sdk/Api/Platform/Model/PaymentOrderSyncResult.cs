using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentOrderSyncResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("nextEvaluatedKey")]
        public string? NextEvaluatedKey { get; set; }
        
        [JsonPropertyName("paymentOrders")]
        public List<PaymentOrder>? PaymentOrders { get; set; }
        
    }
}