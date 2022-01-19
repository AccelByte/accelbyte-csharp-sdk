using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentCallbackConfigInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("dryRun")]
        public bool? DryRun { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("notifyUrl")]
        public string? NotifyUrl { get; set; }
        
        [JsonPropertyName("privateKey")]
        public string? PrivateKey { get; set; }
        
    }
}