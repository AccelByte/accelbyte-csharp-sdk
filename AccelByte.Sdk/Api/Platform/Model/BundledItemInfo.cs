// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class BundledItemInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonStringEnum]
        public BundledItemInfoAppType? AppType { get; set; }

        [JsonPropertyName("baseAppId")]
        public string? BaseAppId { get; set; }

        [JsonPropertyName("boothName")]
        public string? BoothName { get; set; }

        [JsonPropertyName("boundItemIds")]
        public List<string>? BoundItemIds { get; set; }

        [JsonPropertyName("bundledQty")]
        public int? BundledQty { get; set; }

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
        public BundledItemInfoEntitlementType? EntitlementType { get; set; }

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
        public BundledItemInfoItemType? ItemType { get; set; }

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
        public BundledItemInfoSeasonType? SeasonType { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("stackable")]
        public bool? Stackable { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public BundledItemInfoStatus? Status { get; set; }

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

    public class BundledItemInfoAppType : StringEnum<BundledItemInfoAppType>
    {
        public static readonly BundledItemInfoAppType DEMO
            = new BundledItemInfoAppType("DEMO");

        public static readonly BundledItemInfoAppType DLC
            = new BundledItemInfoAppType("DLC");

        public static readonly BundledItemInfoAppType GAME
            = new BundledItemInfoAppType("GAME");

        public static readonly BundledItemInfoAppType SOFTWARE
            = new BundledItemInfoAppType("SOFTWARE");


        public static implicit operator BundledItemInfoAppType(string value)
        {
            return NewValue(value);
        }

        public BundledItemInfoAppType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class BundledItemInfoEntitlementType : StringEnum<BundledItemInfoEntitlementType>
    {
        public static readonly BundledItemInfoEntitlementType CONSUMABLE
            = new BundledItemInfoEntitlementType("CONSUMABLE");

        public static readonly BundledItemInfoEntitlementType DURABLE
            = new BundledItemInfoEntitlementType("DURABLE");


        public static implicit operator BundledItemInfoEntitlementType(string value)
        {
            return NewValue(value);
        }

        public BundledItemInfoEntitlementType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class BundledItemInfoItemType : StringEnum<BundledItemInfoItemType>
    {
        public static readonly BundledItemInfoItemType APP
            = new BundledItemInfoItemType("APP");

        public static readonly BundledItemInfoItemType BUNDLE
            = new BundledItemInfoItemType("BUNDLE");

        public static readonly BundledItemInfoItemType CODE
            = new BundledItemInfoItemType("CODE");

        public static readonly BundledItemInfoItemType COINS
            = new BundledItemInfoItemType("COINS");

        public static readonly BundledItemInfoItemType INGAMEITEM
            = new BundledItemInfoItemType("INGAMEITEM");

        public static readonly BundledItemInfoItemType MEDIA
            = new BundledItemInfoItemType("MEDIA");

        public static readonly BundledItemInfoItemType SEASON
            = new BundledItemInfoItemType("SEASON");

        public static readonly BundledItemInfoItemType SUBSCRIPTION
            = new BundledItemInfoItemType("SUBSCRIPTION");


        public static implicit operator BundledItemInfoItemType(string value)
        {
            return NewValue(value);
        }

        public BundledItemInfoItemType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class BundledItemInfoSeasonType : StringEnum<BundledItemInfoSeasonType>
    {
        public static readonly BundledItemInfoSeasonType PASS
            = new BundledItemInfoSeasonType("PASS");

        public static readonly BundledItemInfoSeasonType TIER
            = new BundledItemInfoSeasonType("TIER");


        public static implicit operator BundledItemInfoSeasonType(string value)
        {
            return NewValue(value);
        }

        public BundledItemInfoSeasonType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class BundledItemInfoStatus : StringEnum<BundledItemInfoStatus>
    {
        public static readonly BundledItemInfoStatus ACTIVE
            = new BundledItemInfoStatus("ACTIVE");

        public static readonly BundledItemInfoStatus INACTIVE
            = new BundledItemInfoStatus("INACTIVE");


        public static implicit operator BundledItemInfoStatus(string value)
        {
            return NewValue(value);
        }

        public BundledItemInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}