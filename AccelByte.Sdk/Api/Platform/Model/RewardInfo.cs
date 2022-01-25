using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class RewardInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("eventTopic")]
        public string? EventTopic { get; set; }
        
        [JsonPropertyName("maxAwarded")]
        public int? MaxAwarded { get; set; }
        
        [JsonPropertyName("maxAwardedPerUser")]
        public int? MaxAwardedPerUser { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("rewardCode")]
        public string? RewardCode { get; set; }
        
        [JsonPropertyName("rewardConditions")]
        public List<RewardCondition>? RewardConditions { get; set; }
        
        [JsonPropertyName("rewardId")]
        public string? RewardId { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
    }
}