// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ItemCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonStringEnum]
        public ItemCreateAppType? AppType { get; set; }

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
        public ItemCreateEntitlementType? EntitlementType { get; set; }

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
        public ItemCreateItemType? ItemType { get; set; }

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
        public ItemCreateSeasonType? SeasonType { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("stackable")]
        public bool? Stackable { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public ItemCreateStatus? Status { get; set; }

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

    public class ItemCreateAppType : StringEnum<ItemCreateAppType>
    {
        public static readonly ItemCreateAppType GAME
            = new ItemCreateAppType("GAME");

        public static readonly ItemCreateAppType SOFTWARE
            = new ItemCreateAppType("SOFTWARE");

        public static readonly ItemCreateAppType DLC
            = new ItemCreateAppType("DLC");

        public static readonly ItemCreateAppType DEMO
            = new ItemCreateAppType("DEMO");


        public static implicit operator ItemCreateAppType(string value)
        {
            return Create(value);
        }

        public ItemCreateAppType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class ItemCreateEntitlementType : StringEnum<ItemCreateEntitlementType>
    {
        public static readonly ItemCreateEntitlementType DURABLE
            = new ItemCreateEntitlementType("DURABLE");

        public static readonly ItemCreateEntitlementType CONSUMABLE
            = new ItemCreateEntitlementType("CONSUMABLE");


        public static implicit operator ItemCreateEntitlementType(string value)
        {
            return Create(value);
        }

        public ItemCreateEntitlementType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class ItemCreateItemType : StringEnum<ItemCreateItemType>
    {
        public static readonly ItemCreateItemType APP
            = new ItemCreateItemType("APP");

        public static readonly ItemCreateItemType COINS
            = new ItemCreateItemType("COINS");

        public static readonly ItemCreateItemType INGAMEITEM
            = new ItemCreateItemType("INGAMEITEM");

        public static readonly ItemCreateItemType BUNDLE
            = new ItemCreateItemType("BUNDLE");

        public static readonly ItemCreateItemType CODE
            = new ItemCreateItemType("CODE");

        public static readonly ItemCreateItemType SUBSCRIPTION
            = new ItemCreateItemType("SUBSCRIPTION");

        public static readonly ItemCreateItemType SEASON
            = new ItemCreateItemType("SEASON");

        public static readonly ItemCreateItemType MEDIA
            = new ItemCreateItemType("MEDIA");


        public static implicit operator ItemCreateItemType(string value)
        {
            return Create(value);
        }

        public ItemCreateItemType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class ItemCreateSeasonType : StringEnum<ItemCreateSeasonType>
    {
        public static readonly ItemCreateSeasonType PASS
            = new ItemCreateSeasonType("PASS");

        public static readonly ItemCreateSeasonType TIER
            = new ItemCreateSeasonType("TIER");


        public static implicit operator ItemCreateSeasonType(string value)
        {
            return Create(value);
        }

        public ItemCreateSeasonType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class ItemCreateStatus : StringEnum<ItemCreateStatus>
    {
        public static readonly ItemCreateStatus ACTIVE
            = new ItemCreateStatus("ACTIVE");

        public static readonly ItemCreateStatus INACTIVE
            = new ItemCreateStatus("INACTIVE");


        public static implicit operator ItemCreateStatus(string value)
        {
            return Create(value);
        }

        public ItemCreateStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}