using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CategoryUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("localizationDisplayNames")]
        public Dictionary<string, string>? LocalizationDisplayNames { get; set; }
        
    }
}