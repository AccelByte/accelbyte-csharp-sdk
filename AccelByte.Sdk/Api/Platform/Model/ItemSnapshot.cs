// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ItemSnapshot : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonStringEnum]
        public ItemSnapshotAppType? AppType { get; set; }

        [JsonPropertyName("baseAppId")]
        public string? BaseAppId { get; set; }

        [JsonPropertyName("boothName")]
        public string? BoothName { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("entitlementType")]
        [JsonStringEnum]
        public ItemSnapshotEntitlementType? EntitlementType { get; set; }

        [JsonPropertyName("features")]
        public List<string>? Features { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemIds")]
        public List<string>? ItemIds { get; set; }

        [JsonPropertyName("itemQty")]
        public Dictionary<string, int>? ItemQty { get; set; }

        [JsonPropertyName("itemType")]
        [JsonStringEnum]
        public ItemSnapshotItemType? ItemType { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("listable")]
        public bool? Listable { get; set; }

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

        [JsonPropertyName("regionDataItem")]
        public RegionDataItem? RegionDataItem { get; set; }

        [JsonPropertyName("seasonType")]
        [JsonStringEnum]
        public ItemSnapshotSeasonType? SeasonType { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("stackable")]
        public bool? Stackable { get; set; }

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

    public class ItemSnapshotAppType : StringEnum<ItemSnapshotAppType>
    {
        public static readonly ItemSnapshotAppType GAME
            = new ItemSnapshotAppType("GAME");

        public static readonly ItemSnapshotAppType SOFTWARE
            = new ItemSnapshotAppType("SOFTWARE");

        public static readonly ItemSnapshotAppType DLC
            = new ItemSnapshotAppType("DLC");

        public static readonly ItemSnapshotAppType DEMO
            = new ItemSnapshotAppType("DEMO");


        public static implicit operator ItemSnapshotAppType(string value)
        {
            return Create(value);
        }

        public ItemSnapshotAppType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class ItemSnapshotEntitlementType : StringEnum<ItemSnapshotEntitlementType>
    {
        public static readonly ItemSnapshotEntitlementType DURABLE
            = new ItemSnapshotEntitlementType("DURABLE");

        public static readonly ItemSnapshotEntitlementType CONSUMABLE
            = new ItemSnapshotEntitlementType("CONSUMABLE");


        public static implicit operator ItemSnapshotEntitlementType(string value)
        {
            return Create(value);
        }

        public ItemSnapshotEntitlementType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class ItemSnapshotItemType : StringEnum<ItemSnapshotItemType>
    {
        public static readonly ItemSnapshotItemType APP
            = new ItemSnapshotItemType("APP");

        public static readonly ItemSnapshotItemType COINS
            = new ItemSnapshotItemType("COINS");

        public static readonly ItemSnapshotItemType INGAMEITEM
            = new ItemSnapshotItemType("INGAMEITEM");

        public static readonly ItemSnapshotItemType BUNDLE
            = new ItemSnapshotItemType("BUNDLE");

        public static readonly ItemSnapshotItemType CODE
            = new ItemSnapshotItemType("CODE");

        public static readonly ItemSnapshotItemType SUBSCRIPTION
            = new ItemSnapshotItemType("SUBSCRIPTION");

        public static readonly ItemSnapshotItemType SEASON
            = new ItemSnapshotItemType("SEASON");

        public static readonly ItemSnapshotItemType MEDIA
            = new ItemSnapshotItemType("MEDIA");


        public static implicit operator ItemSnapshotItemType(string value)
        {
            return Create(value);
        }

        public ItemSnapshotItemType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class ItemSnapshotSeasonType : StringEnum<ItemSnapshotSeasonType>
    {
        public static readonly ItemSnapshotSeasonType PASS
            = new ItemSnapshotSeasonType("PASS");

        public static readonly ItemSnapshotSeasonType TIER
            = new ItemSnapshotSeasonType("TIER");


        public static implicit operator ItemSnapshotSeasonType(string value)
        {
            return Create(value);
        }

        public ItemSnapshotSeasonType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}