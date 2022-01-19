using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsMatchingRule : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("attribute")]
        public string? Attribute { get; set; }
        
        [JsonPropertyName("criteria")]
        public string? Criteria { get; set; }
        
        [JsonPropertyName("reference")]
        public double? Reference { get; set; }
        
    }
}