using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class StatInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("defaultValue")]
        public double? DefaultValue { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("incrementOnly")]
        public bool? IncrementOnly { get; set; }
        
        [JsonPropertyName("maximum")]
        public double? Maximum { get; set; }
        
        [JsonPropertyName("minimum")]
        public double? Minimum { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("setAsGlobal")]
        public bool? SetAsGlobal { get; set; }
        
        [JsonPropertyName("setBy")]
        public string? SetBy { get; set; }
        
        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
    }
}