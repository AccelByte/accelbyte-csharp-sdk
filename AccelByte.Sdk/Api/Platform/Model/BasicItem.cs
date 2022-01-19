using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class BasicItem : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }
        
        [JsonPropertyName("appType")]
        public string? AppType { get; set; }
        
        [JsonPropertyName("baseAppId")]
        public string? BaseAppId { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("entitlementType")]
        public string? EntitlementType { get; set; }
        
        [JsonPropertyName("features")]
        public List<string>? Features { get; set; }
        
        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }
        
        [JsonPropertyName("itemType")]
        public string? ItemType { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("seasonType")]
        public string? SeasonType { get; set; }
        
        [JsonPropertyName("sku")]
        public string? Sku { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
        [JsonPropertyName("useCount")]
        public int? UseCount { get; set; }
        
    }
}