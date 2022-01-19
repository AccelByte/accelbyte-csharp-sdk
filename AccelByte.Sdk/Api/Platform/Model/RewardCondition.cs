using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class RewardCondition : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("condition")]
        public string? Condition { get; set; }
        
        [JsonPropertyName("conditionName")]
        public string? ConditionName { get; set; }
        
        [JsonPropertyName("eventName")]
        public string? EventName { get; set; }
        
        [JsonPropertyName("rewardItems")]
        public List<RewardItem>? RewardItems { get; set; }
        
    }
}