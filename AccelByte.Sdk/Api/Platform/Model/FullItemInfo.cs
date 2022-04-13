// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FullItemInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonStringEnum]
        public FullItemInfoAppType? AppType { get; set; }

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

        [JsonPropertyName("displayOrder")]
        public int? DisplayOrder { get; set; }

        [JsonPropertyName("entitlementType")]
        [JsonStringEnum]
        public FullItemInfoEntitlementType? EntitlementType { get; set; }

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
        public FullItemInfoItemType? ItemType { get; set; }

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

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("purchasable")]
        public bool? Purchasable { get; set; }

        [JsonPropertyName("recurring")]
        public Recurring? Recurring { get; set; }

        [JsonPropertyName("regionData")]
        public Dictionary<string, object>? RegionData { get; set; }

        [JsonPropertyName("seasonType")]
        [JsonStringEnum]
        public FullItemInfoSeasonType? SeasonType { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("stackable")]
        public bool? Stackable { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public FullItemInfoStatus? Status { get; set; }

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

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("useCount")]
        public int? UseCount { get; set; }

    }

    public class FullItemInfoAppType : StringEnum<FullItemInfoAppType>
    {
        public static readonly FullItemInfoAppType GAME
            = new FullItemInfoAppType("GAME");

        public static readonly FullItemInfoAppType SOFTWARE
            = new FullItemInfoAppType("SOFTWARE");

        public static readonly FullItemInfoAppType DLC
            = new FullItemInfoAppType("DLC");

        public static readonly FullItemInfoAppType DEMO
            = new FullItemInfoAppType("DEMO");


        public static implicit operator FullItemInfoAppType(string value)
        {
            return Create(value);
        }

        public FullItemInfoAppType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class FullItemInfoEntitlementType : StringEnum<FullItemInfoEntitlementType>
    {
        public static readonly FullItemInfoEntitlementType DURABLE
            = new FullItemInfoEntitlementType("DURABLE");

        public static readonly FullItemInfoEntitlementType CONSUMABLE
            = new FullItemInfoEntitlementType("CONSUMABLE");


        public static implicit operator FullItemInfoEntitlementType(string value)
        {
            return Create(value);
        }

        public FullItemInfoEntitlementType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class FullItemInfoItemType : StringEnum<FullItemInfoItemType>
    {
        public static readonly FullItemInfoItemType APP
            = new FullItemInfoItemType("APP");

        public static readonly FullItemInfoItemType COINS
            = new FullItemInfoItemType("COINS");

        public static readonly FullItemInfoItemType INGAMEITEM
            = new FullItemInfoItemType("INGAMEITEM");

        public static readonly FullItemInfoItemType BUNDLE
            = new FullItemInfoItemType("BUNDLE");

        public static readonly FullItemInfoItemType CODE
            = new FullItemInfoItemType("CODE");

        public static readonly FullItemInfoItemType SUBSCRIPTION
            = new FullItemInfoItemType("SUBSCRIPTION");

        public static readonly FullItemInfoItemType SEASON
            = new FullItemInfoItemType("SEASON");

        public static readonly FullItemInfoItemType MEDIA
            = new FullItemInfoItemType("MEDIA");


        public static implicit operator FullItemInfoItemType(string value)
        {
            return Create(value);
        }

        public FullItemInfoItemType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class FullItemInfoSeasonType : StringEnum<FullItemInfoSeasonType>
    {
        public static readonly FullItemInfoSeasonType PASS
            = new FullItemInfoSeasonType("PASS");

        public static readonly FullItemInfoSeasonType TIER
            = new FullItemInfoSeasonType("TIER");


        public static implicit operator FullItemInfoSeasonType(string value)
        {
            return Create(value);
        }

        public FullItemInfoSeasonType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class FullItemInfoStatus : StringEnum<FullItemInfoStatus>
    {
        public static readonly FullItemInfoStatus ACTIVE
            = new FullItemInfoStatus("ACTIVE");

        public static readonly FullItemInfoStatus INACTIVE
            = new FullItemInfoStatus("INACTIVE");


        public static implicit operator FullItemInfoStatus(string value)
        {
            return Create(value);
        }

        public FullItemInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}