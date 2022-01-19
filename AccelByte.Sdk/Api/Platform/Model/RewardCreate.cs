using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class RewardCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("eventTopic")]
        public string? EventTopic { get; set; }
        
        [JsonPropertyName("maxAwarded")]
        public int? MaxAwarded { get; set; }
        
        [JsonPropertyName("maxAwardedPerUser")]
        public int? MaxAwardedPerUser { get; set; }
        
        [JsonPropertyName("rewardCode")]
        public string? RewardCode { get; set; }
        
        [JsonPropertyName("rewardConditions")]
        public List<RewardCondition>? RewardConditions { get; set; }
        
    }
}