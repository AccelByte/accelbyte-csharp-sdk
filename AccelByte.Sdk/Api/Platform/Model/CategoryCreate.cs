using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CategoryCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("categoryPath")]
        public string? CategoryPath { get; set; }
        
        [JsonPropertyName("localizationDisplayNames")]
        public Dictionary<string, string>? LocalizationDisplayNames { get; set; }
        
    }
}