using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class RewardItem : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("duration")]
        public int? Duration { get; set; }
        
        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }
        
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }
        
    }
}