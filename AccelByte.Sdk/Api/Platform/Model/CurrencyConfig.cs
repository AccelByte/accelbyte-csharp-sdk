using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CurrencyConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currencySymbol")]
        public string? CurrencySymbol { get; set; }
        
    }
}