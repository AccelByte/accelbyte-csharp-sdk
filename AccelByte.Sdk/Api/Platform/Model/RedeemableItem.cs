using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class RedeemableItem : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("extraSubscriptionDays")]
        public int? ExtraSubscriptionDays { get; set; }
        
        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }
        
        [JsonPropertyName("itemName")]
        public string? ItemName { get; set; }
        
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }
        
    }
}