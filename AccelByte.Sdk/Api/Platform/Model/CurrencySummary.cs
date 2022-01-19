using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CurrencySummary : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }
        
        [JsonPropertyName("currencySymbol")]
        public string? CurrencySymbol { get; set; }
        
        [JsonPropertyName("currencyType")]
        public string? CurrencyType { get; set; }
        
        [JsonPropertyName("decimals")]
        public int? Decimals { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
    }
}