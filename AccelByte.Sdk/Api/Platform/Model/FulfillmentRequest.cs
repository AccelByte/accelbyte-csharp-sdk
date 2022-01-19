using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("duration")]
        public int? Duration { get; set; }
        
        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }
        
        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }
        
        [JsonPropertyName("itemSku")]
        public string? ItemSku { get; set; }
        
        [JsonPropertyName("language")]
        public string? Language { get; set; }
        
        [JsonPropertyName("order")]
        public OrderSummary? Order { get; set; }
        
        [JsonPropertyName("orderNo")]
        public string? OrderNo { get; set; }
        
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
        [JsonPropertyName("source")]
        public string? Source { get; set; }
        
        [JsonPropertyName("startDate")]
        public DateTime? StartDate { get; set; }
        
        [JsonPropertyName("storeId")]
        public string? StoreId { get; set; }
        
    }
}