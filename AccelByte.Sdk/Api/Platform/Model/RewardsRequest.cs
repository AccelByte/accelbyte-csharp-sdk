using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class RewardsRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("rewards")]
        public List<PlatformReward>? Rewards { get; set; }
        
        [JsonPropertyName("source")]
        public string? Source { get; set; }
        
    }
}