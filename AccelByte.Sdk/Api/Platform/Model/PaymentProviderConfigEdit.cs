using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentProviderConfigEdit : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("aggregate")]
        public string? Aggregate { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
        [JsonPropertyName("sandboxTaxJarApiToken")]
        public string? SandboxTaxJarApiToken { get; set; }
        
        [JsonPropertyName("specials")]
        public List<string>? Specials { get; set; }
        
        [JsonPropertyName("taxJarApiToken")]
        public string? TaxJarApiToken { get; set; }
        
        [JsonPropertyName("taxJarEnabled")]
        public bool? TaxJarEnabled { get; set; }
        
        [JsonPropertyName("useGlobalTaxJarApiToken")]
        public bool? UseGlobalTaxJarApiToken { get; set; }
        
    }
}