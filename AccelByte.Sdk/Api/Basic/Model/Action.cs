using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class Action : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("color")]
        public string? Color { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("duration")]
        public long? Duration { get; set; }
        
        [JsonPropertyName("icon")]
        public string? Icon { get; set; }
        
        [JsonPropertyName("id")]
        public int? Id { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("priority")]
        public int? Priority { get; set; }
        
    }
}