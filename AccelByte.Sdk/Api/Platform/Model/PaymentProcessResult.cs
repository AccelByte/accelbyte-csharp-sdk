using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentProcessResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("pending")]
        public bool? Pending { get; set; }
        
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }
        
        [JsonPropertyName("redirectUrl")]
        public string? RedirectUrl { get; set; }
        
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        
    }
}