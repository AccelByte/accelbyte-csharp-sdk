using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class RewardUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }
        
        [JsonPropertyName("currency")]
        public RewardCurrency? Currency { get; set; }
        
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }
        
        [JsonPropertyName("image")]
        public Image? Image { get; set; }
        
        [JsonPropertyName("nullFields")]
        public List<string>? NullFields { get; set; }
        
    }
}