using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsCreateContentRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("payload")]
        public string? Payload { get; set; }
        
        [JsonPropertyName("preview")]
        public string? Preview { get; set; }
        
        [JsonPropertyName("subType")]
        public string? SubType { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
    }
}