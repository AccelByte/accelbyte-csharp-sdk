using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ConditionMatchResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("matched")]
        public bool? Matched { get; set; }
        
        [JsonPropertyName("matchedConditions")]
        public List<object>? MatchedConditions { get; set; }
        
        [JsonPropertyName("notMatchReason")]
        public string? NotMatchReason { get; set; }
        
    }
}