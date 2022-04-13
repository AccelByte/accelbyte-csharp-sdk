// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PopulatedItemInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonStringEnum]
        public PopulatedItemInfoAppType? AppType { get; set; }

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
        public PopulatedItemInfoEntitlementType? EntitlementType { get; set; }

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
        public PopulatedItemInfoItemType? ItemType { get; set; }

        [JsonPropertyName("items")]
        public List<BundledItemInfo>? Items { get; set; }

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
        public PopulatedItemInfoSeasonType? SeasonType { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("stackable")]
        public bool? Stackable { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public PopulatedItemInfoStatus? Status { get; set; }

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

    public class PopulatedItemInfoAppType : StringEnum<PopulatedItemInfoAppType>
    {
        public static readonly PopulatedItemInfoAppType GAME
            = new PopulatedItemInfoAppType("GAME");

        public static readonly PopulatedItemInfoAppType SOFTWARE
            = new PopulatedItemInfoAppType("SOFTWARE");

        public static readonly PopulatedItemInfoAppType DLC
            = new PopulatedItemInfoAppType("DLC");

        public static readonly PopulatedItemInfoAppType DEMO
            = new PopulatedItemInfoAppType("DEMO");


        public static implicit operator PopulatedItemInfoAppType(string value)
        {
            return Create(value);
        }

        public PopulatedItemInfoAppType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class PopulatedItemInfoEntitlementType : StringEnum<PopulatedItemInfoEntitlementType>
    {
        public static readonly PopulatedItemInfoEntitlementType DURABLE
            = new PopulatedItemInfoEntitlementType("DURABLE");

        public static readonly PopulatedItemInfoEntitlementType CONSUMABLE
            = new PopulatedItemInfoEntitlementType("CONSUMABLE");


        public static implicit operator PopulatedItemInfoEntitlementType(string value)
        {
            return Create(value);
        }

        public PopulatedItemInfoEntitlementType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class PopulatedItemInfoItemType : StringEnum<PopulatedItemInfoItemType>
    {
        public static readonly PopulatedItemInfoItemType APP
            = new PopulatedItemInfoItemType("APP");

        public static readonly PopulatedItemInfoItemType COINS
            = new PopulatedItemInfoItemType("COINS");

        public static readonly PopulatedItemInfoItemType INGAMEITEM
            = new PopulatedItemInfoItemType("INGAMEITEM");

        public static readonly PopulatedItemInfoItemType BUNDLE
            = new PopulatedItemInfoItemType("BUNDLE");

        public static readonly PopulatedItemInfoItemType CODE
            = new PopulatedItemInfoItemType("CODE");

        public static readonly PopulatedItemInfoItemType SUBSCRIPTION
            = new PopulatedItemInfoItemType("SUBSCRIPTION");

        public static readonly PopulatedItemInfoItemType SEASON
            = new PopulatedItemInfoItemType("SEASON");

        public static readonly PopulatedItemInfoItemType MEDIA
            = new PopulatedItemInfoItemType("MEDIA");


        public static implicit operator PopulatedItemInfoItemType(string value)
        {
            return Create(value);
        }

        public PopulatedItemInfoItemType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class PopulatedItemInfoSeasonType : StringEnum<PopulatedItemInfoSeasonType>
    {
        public static readonly PopulatedItemInfoSeasonType PASS
            = new PopulatedItemInfoSeasonType("PASS");

        public static readonly PopulatedItemInfoSeasonType TIER
            = new PopulatedItemInfoSeasonType("TIER");


        public static implicit operator PopulatedItemInfoSeasonType(string value)
        {
            return Create(value);
        }

        public PopulatedItemInfoSeasonType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class PopulatedItemInfoStatus : StringEnum<PopulatedItemInfoStatus>
    {
        public static readonly PopulatedItemInfoStatus ACTIVE
            = new PopulatedItemInfoStatus("ACTIVE");

        public static readonly PopulatedItemInfoStatus INACTIVE
            = new PopulatedItemInfoStatus("INACTIVE");


        public static implicit operator PopulatedItemInfoStatus(string value)
        {
            return Create(value);
        }

        public PopulatedItemInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}