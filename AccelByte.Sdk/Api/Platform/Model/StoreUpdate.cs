using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class StoreUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("defaultLanguage")]
        public string? DefaultLanguage { get; set; }
        
        [JsonPropertyName("defaultRegion")]
        public string? DefaultRegion { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("supportedLanguages")]
        public List<string>? SupportedLanguages { get; set; }
        
        [JsonPropertyName("supportedRegions")]
        public List<string>? SupportedRegions { get; set; }
        
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        
    }
}