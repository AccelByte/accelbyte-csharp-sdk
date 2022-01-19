using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsCreateTypeResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("subtype")]
        public List<string>? Subtype { get; set; }
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
    }
}