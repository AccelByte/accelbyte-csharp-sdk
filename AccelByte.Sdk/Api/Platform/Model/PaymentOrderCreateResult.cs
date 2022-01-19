using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentOrderCreateResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdTime")]
        public DateTime? CreatedTime { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("paymentOrderNo")]
        public string? PaymentOrderNo { get; set; }
        
        [JsonPropertyName("paymentStationUrl")]
        public string? PaymentStationUrl { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("targetNamespace")]
        public string? TargetNamespace { get; set; }
        
        [JsonPropertyName("targetUserId")]
        public string? TargetUserId { get; set; }
        
    }
}