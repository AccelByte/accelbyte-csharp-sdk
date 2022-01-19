using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentUrlCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("paymentOrderNo")]
        public string? PaymentOrderNo { get; set; }
        
        [JsonPropertyName("paymentProvider")]
        public string? PaymentProvider { get; set; }
        
        [JsonPropertyName("returnUrl")]
        public string? ReturnUrl { get; set; }
        
        [JsonPropertyName("ui")]
        public string? Ui { get; set; }
        
        [JsonPropertyName("zipCode")]
        public string? ZipCode { get; set; }
        
    }
}