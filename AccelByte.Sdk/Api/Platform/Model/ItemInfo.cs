// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ItemInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }
        
        [JsonPropertyName("appType")]
        public string? AppType { get; set; }
        
        [JsonPropertyName("baseAppId")]
        public string? BaseAppId { get; set; }
        
        [JsonPropertyName("boothName")]
        public string? BoothName { get; set; }
        
        [JsonPropertyName("boundItemIds")]
        public List<string>? BoundItemIds { get; set; }
        
        [JsonPropertyName("categoryPath")]
        public string? CategoryPath { get; set; }
        
        [JsonPropertyName("clazz")]
        public string? Clazz { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("displayOrder")]
        public int? DisplayOrder { get; set; }
        
        [JsonPropertyName("entitlementType")]
        public string? EntitlementType { get; set; }
        
        [JsonPropertyName("ext")]
        public Dictionary<string, object>? Ext { get; set; }
        
        [JsonPropertyName("features")]
        public List<string>? Features { get; set; }
        
        [JsonPropertyName("images")]
        public List<Image>? Images { get; set; }
        
        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }
        
        [JsonPropertyName("itemIds")]
        public List<string>? ItemIds { get; set; }
        
        [JsonPropertyName("itemQty")]
        public Dictionary<string, int>? ItemQty { get; set; }
        
        [JsonPropertyName("itemType")]
        public string? ItemType { get; set; }
        
        [JsonPropertyName("language")]
        public string? Language { get; set; }
        
        [JsonPropertyName("listable")]
        public bool? Listable { get; set; }
        
        [JsonPropertyName("localExt")]
        public Dictionary<string, object>? LocalExt { get; set; }
        
        [JsonPropertyName("longDescription")]
        public string? LongDescription { get; set; }
        
        [JsonPropertyName("maxCount")]
        public int? MaxCount { get; set; }
        
        [JsonPropertyName("maxCountPerUser")]
        public int? MaxCountPerUser { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("purchasable")]
        public bool? Purchasable { get; set; }
        
        [JsonPropertyName("recurring")]
        public Recurring? Recurring { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
        [JsonPropertyName("regionData")]
        public List<RegionDataItem>? RegionData { get; set; }
        
        [JsonPropertyName("seasonType")]
        public string? SeasonType { get; set; }
        
        [JsonPropertyName("sku")]
        public string? Sku { get; set; }
        
        [JsonPropertyName("stackable")]
        public bool? Stackable { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
        [JsonPropertyName("targetCurrencyCode")]
        public string? TargetCurrencyCode { get; set; }
        
        [JsonPropertyName("targetItemId")]
        public string? TargetItemId { get; set; }
        
        [JsonPropertyName("targetNamespace")]
        public string? TargetNamespace { get; set; }
        
        [JsonPropertyName("thumbnailUrl")]
        public string? ThumbnailUrl { get; set; }
        
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
        [JsonPropertyName("useCount")]
        public int? UseCount { get; set; }
        
    }
}