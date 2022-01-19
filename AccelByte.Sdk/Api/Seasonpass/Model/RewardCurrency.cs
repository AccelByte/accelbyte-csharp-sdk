using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class RewardCurrency : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }
        
    }
}