using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PlatformReward : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currency")]
        public PlatformRewardCurrency? Currency { get; set; }
        
        [JsonPropertyName("item")]
        public PlatformRewardItem? Item { get; set; }
        
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
    }
}