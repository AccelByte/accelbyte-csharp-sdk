using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsCreateTypeRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("subtype")]
        public List<string>? Subtype { get; set; }
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
    }
}