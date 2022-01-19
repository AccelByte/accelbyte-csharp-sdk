using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentCallbackConfigUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("dryRun")]
        public bool? DryRun { get; set; }
        
        [JsonPropertyName("notifyUrl")]
        public string? NotifyUrl { get; set; }
        
        [JsonPropertyName("privateKey")]
        public string? PrivateKey { get; set; }
        
    }
}