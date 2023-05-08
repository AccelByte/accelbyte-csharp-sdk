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
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ItemSnapshotAppType? AppType { get; set; }

        [JsonPropertyName("baseAppId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BaseAppId { get; set; }

        [JsonPropertyName("boothName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BoothName { get; set; }

        [JsonPropertyName("createdAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("entitlementType")]
        [JsonStringEnum]
        public ItemSnapshotEntitlementType? EntitlementType { get; set; }

        [JsonPropertyName("features")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Features { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemIds")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? ItemIds { get; set; }

        [JsonPropertyName("itemQty")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, int>? ItemQty { get; set; }

        [JsonPropertyName("itemType")]
        [JsonStringEnum]
        public ItemSnapshotItemType? ItemType { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("listable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Listable { get; set; }

        [JsonPropertyName("lootBoxConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public LootBoxConfig? LootBoxConfig { get; set; }

        [JsonPropertyName("maxCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxCount { get; set; }

        [JsonPropertyName("maxCountPerUser")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxCountPerUser { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("optionBoxConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public OptionBoxConfig? OptionBoxConfig { get; set; }

        [JsonPropertyName("purchasable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Purchasable { get; set; }

        [JsonPropertyName("recurring")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Recurring? Recurring { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("regionDataItem")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public RegionDataItem? RegionDataItem { get; set; }

        [JsonPropertyName("saleConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public SaleConfig? SaleConfig { get; set; }

        [JsonPropertyName("seasonType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ItemSnapshotSeasonType? SeasonType { get; set; }

        [JsonPropertyName("sectionExclusive")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? SectionExclusive { get; set; }

        [JsonPropertyName("sellable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Sellable { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("stackable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Stackable { get; set; }

        [JsonPropertyName("targetCurrencyCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetCurrencyCode { get; set; }

        [JsonPropertyName("targetItemId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetItemId { get; set; }

        [JsonPropertyName("targetNamespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetNamespace { get; set; }

        [JsonPropertyName("thumbnailUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ThumbnailUrl { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("updatedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("useCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? UseCount { get; set; }

    }



    public class ItemSnapshotAppType : StringEnum<ItemSnapshotAppType>
    {
        public static readonly ItemSnapshotAppType DEMO
            = new ItemSnapshotAppType("DEMO");

        public static readonly ItemSnapshotAppType DLC
            = new ItemSnapshotAppType("DLC");

        public static readonly ItemSnapshotAppType GAME
            = new ItemSnapshotAppType("GAME");

        public static readonly ItemSnapshotAppType SOFTWARE
            = new ItemSnapshotAppType("SOFTWARE");


        public static implicit operator ItemSnapshotAppType(string value)
        {
            return NewValue(value);
        }

        public ItemSnapshotAppType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ItemSnapshotEntitlementType : StringEnum<ItemSnapshotEntitlementType>
    {
        public static readonly ItemSnapshotEntitlementType CONSUMABLE
            = new ItemSnapshotEntitlementType("CONSUMABLE");

        public static readonly ItemSnapshotEntitlementType DURABLE
            = new ItemSnapshotEntitlementType("DURABLE");


        public static implicit operator ItemSnapshotEntitlementType(string value)
        {
            return NewValue(value);
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

        public static readonly ItemSnapshotItemType BUNDLE
            = new ItemSnapshotItemType("BUNDLE");

        public static readonly ItemSnapshotItemType CODE
            = new ItemSnapshotItemType("CODE");

        public static readonly ItemSnapshotItemType COINS
            = new ItemSnapshotItemType("COINS");

        public static readonly ItemSnapshotItemType EXTENSION
            = new ItemSnapshotItemType("EXTENSION");

        public static readonly ItemSnapshotItemType INGAMEITEM
            = new ItemSnapshotItemType("INGAMEITEM");

        public static readonly ItemSnapshotItemType LOOTBOX
            = new ItemSnapshotItemType("LOOTBOX");

        public static readonly ItemSnapshotItemType MEDIA
            = new ItemSnapshotItemType("MEDIA");

        public static readonly ItemSnapshotItemType OPTIONBOX
            = new ItemSnapshotItemType("OPTIONBOX");

        public static readonly ItemSnapshotItemType SEASON
            = new ItemSnapshotItemType("SEASON");

        public static readonly ItemSnapshotItemType SUBSCRIPTION
            = new ItemSnapshotItemType("SUBSCRIPTION");


        public static implicit operator ItemSnapshotItemType(string value)
        {
            return NewValue(value);
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
            return NewValue(value);
        }

        public ItemSnapshotSeasonType(string enumValue)
            : base(enumValue)
        {

        }
    }
}