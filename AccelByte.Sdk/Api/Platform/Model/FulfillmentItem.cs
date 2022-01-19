using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentItem : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("extraSubscriptionDays")]
        public int? ExtraSubscriptionDays { get; set; }
        
        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }
        
        [JsonPropertyName("itemName")]
        public string? ItemName { get; set; }
        
        [JsonPropertyName("itemSku")]
        public string? ItemSku { get; set; }
        
        [JsonPropertyName("itemType")]
        public string? ItemType { get; set; }
        
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }
        
        [JsonPropertyName("storeId")]
        public string? StoreId { get; set; }
        
    }
}