using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentOrderChargeRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("extTxId")]
        public string? ExtTxId { get; set; }
        
        [JsonPropertyName("paymentMethod")]
        public string? PaymentMethod { get; set; }
        
        [JsonPropertyName("paymentProvider")]
        public string? PaymentProvider { get; set; }
        
    }
}