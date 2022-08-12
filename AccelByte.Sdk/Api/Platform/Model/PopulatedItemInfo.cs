// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PopulatedItemInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PopulatedItemInfoAppType? AppType { get; set; }

        [JsonPropertyName("baseAppId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BaseAppId { get; set; }

        [JsonPropertyName("boothName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BoothName { get; set; }

        [JsonPropertyName("boundItemIds")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? BoundItemIds { get; set; }

        [JsonPropertyName("categoryPath")]
        public string? CategoryPath { get; set; }

        [JsonPropertyName("clazz")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Clazz { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("displayOrder")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? DisplayOrder { get; set; }

        [JsonPropertyName("entitlementType")]
        [JsonStringEnum]
        public PopulatedItemInfoEntitlementType? EntitlementType { get; set; }

        [JsonPropertyName("ext")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? Ext { get; set; }

        [JsonPropertyName("features")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Features { get; set; }

        [JsonPropertyName("fresh")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Fresh { get; set; }

        [JsonPropertyName("images")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Image>? Images { get; set; }

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
        public PopulatedItemInfoItemType? ItemType { get; set; }

        [JsonPropertyName("items")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<BundledItemInfo>? Items { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("listable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Listable { get; set; }

        [JsonPropertyName("localExt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? LocalExt { get; set; }

        [JsonPropertyName("longDescription")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? LongDescription { get; set; }

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

        [JsonPropertyName("purchaseCondition")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PurchaseCondition? PurchaseCondition { get; set; }

        [JsonPropertyName("recurring")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Recurring? Recurring { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("regionData")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<RegionDataItem>? RegionData { get; set; }

        [JsonPropertyName("seasonType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PopulatedItemInfoSeasonType? SeasonType { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("stackable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Stackable { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public PopulatedItemInfoStatus? Status { get; set; }

        [JsonPropertyName("tags")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Tags { get; set; }

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
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("useCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? UseCount { get; set; }

    }

    public class PopulatedItemInfoAppType : StringEnum<PopulatedItemInfoAppType>
    {
        public static readonly PopulatedItemInfoAppType DEMO
            = new PopulatedItemInfoAppType("DEMO");

        public static readonly PopulatedItemInfoAppType DLC
            = new PopulatedItemInfoAppType("DLC");

        public static readonly PopulatedItemInfoAppType GAME
            = new PopulatedItemInfoAppType("GAME");

        public static readonly PopulatedItemInfoAppType SOFTWARE
            = new PopulatedItemInfoAppType("SOFTWARE");


        public static implicit operator PopulatedItemInfoAppType(string value)
        {
            return NewValue(value);
        }

        public PopulatedItemInfoAppType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class PopulatedItemInfoEntitlementType : StringEnum<PopulatedItemInfoEntitlementType>
    {
        public static readonly PopulatedItemInfoEntitlementType CONSUMABLE
            = new PopulatedItemInfoEntitlementType("CONSUMABLE");

        public static readonly PopulatedItemInfoEntitlementType DURABLE
            = new PopulatedItemInfoEntitlementType("DURABLE");


        public static implicit operator PopulatedItemInfoEntitlementType(string value)
        {
            return NewValue(value);
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

        public static readonly PopulatedItemInfoItemType BUNDLE
            = new PopulatedItemInfoItemType("BUNDLE");

        public static readonly PopulatedItemInfoItemType CODE
            = new PopulatedItemInfoItemType("CODE");

        public static readonly PopulatedItemInfoItemType COINS
            = new PopulatedItemInfoItemType("COINS");

        public static readonly PopulatedItemInfoItemType INGAMEITEM
            = new PopulatedItemInfoItemType("INGAMEITEM");

        public static readonly PopulatedItemInfoItemType MEDIA
            = new PopulatedItemInfoItemType("MEDIA");

        public static readonly PopulatedItemInfoItemType OPTIONBOX
            = new PopulatedItemInfoItemType("OPTIONBOX");

        public static readonly PopulatedItemInfoItemType SEASON
            = new PopulatedItemInfoItemType("SEASON");

        public static readonly PopulatedItemInfoItemType SUBSCRIPTION
            = new PopulatedItemInfoItemType("SUBSCRIPTION");


        public static implicit operator PopulatedItemInfoItemType(string value)
        {
            return NewValue(value);
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
            return NewValue(value);
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
            return NewValue(value);
        }

        public PopulatedItemInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}