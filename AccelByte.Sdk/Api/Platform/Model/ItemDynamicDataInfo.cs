using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ItemDynamicDataInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("availableCount")]
        public int? AvailableCount { get; set; }
        
        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("userAvailableCount")]
        public long? UserAvailableCount { get; set; }
        
        [JsonPropertyName("userPurchaseLimit")]
        public long? UserPurchaseLimit { get; set; }
        
    }
}