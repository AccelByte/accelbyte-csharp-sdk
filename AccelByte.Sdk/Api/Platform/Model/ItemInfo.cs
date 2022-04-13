// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ItemInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonStringEnum]
        public ItemInfoAppType? AppType { get; set; }

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
        [JsonStringEnum]
        public ItemInfoEntitlementType? EntitlementType { get; set; }

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
        [JsonStringEnum]
        public ItemInfoItemType? ItemType { get; set; }

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
        [JsonStringEnum]
        public ItemInfoSeasonType? SeasonType { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("stackable")]
        public bool? Stackable { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public ItemInfoStatus? Status { get; set; }

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

    public class ItemInfoAppType : StringEnum<ItemInfoAppType>
    {
        public static readonly ItemInfoAppType GAME
            = new ItemInfoAppType("GAME");

        public static readonly ItemInfoAppType SOFTWARE
            = new ItemInfoAppType("SOFTWARE");

        public static readonly ItemInfoAppType DLC
            = new ItemInfoAppType("DLC");

        public static readonly ItemInfoAppType DEMO
            = new ItemInfoAppType("DEMO");


        public static implicit operator ItemInfoAppType(string value)
        {
            return Create(value);
        }

        public ItemInfoAppType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class ItemInfoEntitlementType : StringEnum<ItemInfoEntitlementType>
    {
        public static readonly ItemInfoEntitlementType DURABLE
            = new ItemInfoEntitlementType("DURABLE");

        public static readonly ItemInfoEntitlementType CONSUMABLE
            = new ItemInfoEntitlementType("CONSUMABLE");


        public static implicit operator ItemInfoEntitlementType(string value)
        {
            return Create(value);
        }

        public ItemInfoEntitlementType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class ItemInfoItemType : StringEnum<ItemInfoItemType>
    {
        public static readonly ItemInfoItemType APP
            = new ItemInfoItemType("APP");

        public static readonly ItemInfoItemType COINS
            = new ItemInfoItemType("COINS");

        public static readonly ItemInfoItemType INGAMEITEM
            = new ItemInfoItemType("INGAMEITEM");

        public static readonly ItemInfoItemType BUNDLE
            = new ItemInfoItemType("BUNDLE");

        public static readonly ItemInfoItemType CODE
            = new ItemInfoItemType("CODE");

        public static readonly ItemInfoItemType SUBSCRIPTION
            = new ItemInfoItemType("SUBSCRIPTION");

        public static readonly ItemInfoItemType SEASON
            = new ItemInfoItemType("SEASON");

        public static readonly ItemInfoItemType MEDIA
            = new ItemInfoItemType("MEDIA");


        public static implicit operator ItemInfoItemType(string value)
        {
            return Create(value);
        }

        public ItemInfoItemType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class ItemInfoSeasonType : StringEnum<ItemInfoSeasonType>
    {
        public static readonly ItemInfoSeasonType PASS
            = new ItemInfoSeasonType("PASS");

        public static readonly ItemInfoSeasonType TIER
            = new ItemInfoSeasonType("TIER");


        public static implicit operator ItemInfoSeasonType(string value)
        {
            return Create(value);
        }

        public ItemInfoSeasonType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class ItemInfoStatus : StringEnum<ItemInfoStatus>
    {
        public static readonly ItemInfoStatus ACTIVE
            = new ItemInfoStatus("ACTIVE");

        public static readonly ItemInfoStatus INACTIVE
            = new ItemInfoStatus("INACTIVE");


        public static implicit operator ItemInfoStatus(string value)
        {
            return Create(value);
        }

        public ItemInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}