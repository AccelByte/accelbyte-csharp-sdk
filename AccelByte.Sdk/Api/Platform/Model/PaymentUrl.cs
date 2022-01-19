using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentUrl : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("paymentProvider")]
        public string? PaymentProvider { get; set; }
        
        [JsonPropertyName("paymentType")]
        public string? PaymentType { get; set; }
        
        [JsonPropertyName("paymentUrl")]
        public string? PaymentUrl_ { get; set; }
        
        [JsonPropertyName("returnUrl")]
        public string? ReturnUrl { get; set; }
        
    }
}