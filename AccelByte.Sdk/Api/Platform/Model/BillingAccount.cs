using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class BillingAccount : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalData")]
        public AdditionalData? AdditionalData { get; set; }
        
        [JsonPropertyName("paymentMethod")]
        public string? PaymentMethod { get; set; }
        
        [JsonPropertyName("paymentProvider")]
        public string? PaymentProvider { get; set; }
        
    }
}