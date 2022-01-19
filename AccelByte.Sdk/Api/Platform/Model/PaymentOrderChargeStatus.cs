using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentOrderChargeStatus : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("charging")]
        public bool? Charging { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
    }
}