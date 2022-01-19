using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CurrencyUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("localizationDescriptions")]
        public Dictionary<string, string>? LocalizationDescriptions { get; set; }
        
    }
}