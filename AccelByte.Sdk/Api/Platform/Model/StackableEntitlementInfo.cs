using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class StackableEntitlementInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }
        
        [JsonPropertyName("appType")]
        public string? AppType { get; set; }
        
        [JsonPropertyName("clazz")]
        public string? Clazz { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }
        
        [JsonPropertyName("features")]
        public List<string>? Features { get; set; }
        
        [JsonPropertyName("grantedAt")]
        public DateTime? GrantedAt { get; set; }
        
        [JsonPropertyName("grantedCode")]
        public string? GrantedCode { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }
        
        [JsonPropertyName("itemNamespace")]
        public string? ItemNamespace { get; set; }
        
        [JsonPropertyName("itemSnapshot")]
        public ItemSnapshot? ItemSnapshot { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("sku")]
        public string? Sku { get; set; }
        
        [JsonPropertyName("source")]
        public string? Source { get; set; }
        
        [JsonPropertyName("stackable")]
        public bool? Stackable { get; set; }
        
        [JsonPropertyName("stackedUseCount")]
        public int? StackedUseCount { get; set; }
        
        [JsonPropertyName("startDate")]
        public DateTime? StartDate { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("storeId")]
        public string? StoreId { get; set; }
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
        [JsonPropertyName("useCount")]
        public int? UseCount { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}