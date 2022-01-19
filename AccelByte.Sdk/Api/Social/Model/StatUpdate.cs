using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class StatUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
    }
}