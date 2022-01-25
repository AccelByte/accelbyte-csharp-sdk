using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class UserRewardClaim : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("passCode")]
        public string? PassCode { get; set; }
        
        [JsonPropertyName("tierIndex")]
        public int? TierIndex { get; set; }
        
        [JsonPropertyName("rewardCode")]
        public string? RewardCode { get; set; }
        
    }
}