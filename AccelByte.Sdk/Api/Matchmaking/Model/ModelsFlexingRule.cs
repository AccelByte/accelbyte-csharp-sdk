using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsFlexingRule : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("attribute")]
        public string? Attribute { get; set; }
        
        [JsonPropertyName("criteria")]
        public string? Criteria { get; set; }
        
        [JsonPropertyName("duration")]
        public long? Duration { get; set; }
        
        [JsonPropertyName("reference")]
        public double? Reference { get; set; }
        
    }
}