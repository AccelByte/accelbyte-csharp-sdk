// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ItemUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonStringEnum]
        public ItemUpdateAppType? AppType { get; set; }

        [JsonPropertyName("baseAppId")]
        public string? BaseAppId { get; set; }

        [JsonPropertyName("boothName")]
        public string? BoothName { get; set; }

        [JsonPropertyName("categoryPath")]
        public string? CategoryPath { get; set; }

        [JsonPropertyName("clazz")]
        public string? Clazz { get; set; }

        [JsonPropertyName("displayOrder")]
        public int? DisplayOrder { get; set; }

        [JsonPropertyName("entitlementType")]
        [JsonStringEnum]
        public ItemUpdateEntitlementType? EntitlementType { get; set; }

        [JsonPropertyName("ext")]
        public Dictionary<string, object>? Ext { get; set; }

        [JsonPropertyName("features")]
        public List<string>? Features { get; set; }

        [JsonPropertyName("images")]
        public List<Image>? Images { get; set; }

        [JsonPropertyName("itemIds")]
        public List<string>? ItemIds { get; set; }

        [JsonPropertyName("itemQty")]
        public Dictionary<string, int>? ItemQty { get; set; }

        [JsonPropertyName("itemType")]
        [JsonStringEnum]
        public ItemUpdateItemType? ItemType { get; set; }

        [JsonPropertyName("listable")]
        public bool? Listable { get; set; }

        [JsonPropertyName("localizations")]
        public Dictionary<string, Localization>? Localizations { get; set; }

        [JsonPropertyName("maxCount")]
        public int? MaxCount { get; set; }

        [JsonPropertyName("maxCountPerUser")]
        public int? MaxCountPerUser { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("purchasable")]
        public bool? Purchasable { get; set; }

        [JsonPropertyName("recurring")]
        public Recurring? Recurring { get; set; }

        [JsonPropertyName("regionData")]
        public Dictionary<string, object>? RegionData { get; set; }

        [JsonPropertyName("seasonType")]
        [JsonStringEnum]
        public ItemUpdateSeasonType? SeasonType { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("stackable")]
        public bool? Stackable { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public ItemUpdateStatus? Status { get; set; }

        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("targetCurrencyCode")]
        public string? TargetCurrencyCode { get; set; }

        [JsonPropertyName("targetNamespace")]
        public string? TargetNamespace { get; set; }

        [JsonPropertyName("thumbnailUrl")]
        public string? ThumbnailUrl { get; set; }

        [JsonPropertyName("useCount")]
        public int? UseCount { get; set; }

    }

    public class ItemUpdateAppType : StringEnum<ItemUpdateAppType>
    {
        public static readonly ItemUpdateAppType GAME
            = new ItemUpdateAppType("GAME");

        public static readonly ItemUpdateAppType SOFTWARE
            = new ItemUpdateAppType("SOFTWARE");

        public static readonly ItemUpdateAppType DLC
            = new ItemUpdateAppType("DLC");

        public static readonly ItemUpdateAppType DEMO
            = new ItemUpdateAppType("DEMO");


        public static implicit operator ItemUpdateAppType(string value)
        {
            return Create(value);
        }

        public ItemUpdateAppType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class ItemUpdateEntitlementType : StringEnum<ItemUpdateEntitlementType>
    {
        public static readonly ItemUpdateEntitlementType DURABLE
            = new ItemUpdateEntitlementType("DURABLE");

        public static readonly ItemUpdateEntitlementType CONSUMABLE
            = new ItemUpdateEntitlementType("CONSUMABLE");


        public static implicit operator ItemUpdateEntitlementType(string value)
        {
            return Create(value);
        }

        public ItemUpdateEntitlementType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class ItemUpdateItemType : StringEnum<ItemUpdateItemType>
    {
        public static readonly ItemUpdateItemType APP
            = new ItemUpdateItemType("APP");

        public static readonly ItemUpdateItemType COINS
            = new ItemUpdateItemType("COINS");

        public static readonly ItemUpdateItemType INGAMEITEM
            = new ItemUpdateItemType("INGAMEITEM");

        public static readonly ItemUpdateItemType BUNDLE
            = new ItemUpdateItemType("BUNDLE");

        public static readonly ItemUpdateItemType CODE
            = new ItemUpdateItemType("CODE");

        public static readonly ItemUpdateItemType SUBSCRIPTION
            = new ItemUpdateItemType("SUBSCRIPTION");

        public static readonly ItemUpdateItemType SEASON
            = new ItemUpdateItemType("SEASON");

        public static readonly ItemUpdateItemType MEDIA
            = new ItemUpdateItemType("MEDIA");


        public static implicit operator ItemUpdateItemType(string value)
        {
            return Create(value);
        }

        public ItemUpdateItemType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class ItemUpdateSeasonType : StringEnum<ItemUpdateSeasonType>
    {
        public static readonly ItemUpdateSeasonType PASS
            = new ItemUpdateSeasonType("PASS");

        public static readonly ItemUpdateSeasonType TIER
            = new ItemUpdateSeasonType("TIER");


        public static implicit operator ItemUpdateSeasonType(string value)
        {
            return Create(value);
        }

        public ItemUpdateSeasonType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class ItemUpdateStatus : StringEnum<ItemUpdateStatus>
    {
        public static readonly ItemUpdateStatus ACTIVE
            = new ItemUpdateStatus("ACTIVE");

        public static readonly ItemUpdateStatus INACTIVE
            = new ItemUpdateStatus("INACTIVE");


        public static implicit operator ItemUpdateStatus(string value)
        {
            return Create(value);
        }

        public ItemUpdateStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}