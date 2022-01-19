using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class EntitlementGrant : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }
        
        [JsonPropertyName("grantedCode")]
        public string? GrantedCode { get; set; }
        
        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }
        
        [JsonPropertyName("itemNamespace")]
        public string? ItemNamespace { get; set; }
        
        [JsonPropertyName("language")]
        public string? Language { get; set; }
        
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