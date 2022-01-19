using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class KeyGroupCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
    }
}