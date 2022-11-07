// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FullItemInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public FullItemInfoAppType? AppType { get; set; }

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

        [JsonPropertyName("displayOrder")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? DisplayOrder { get; set; }

        [JsonPropertyName("entitlementType")]
        [JsonStringEnum]
        public FullItemInfoEntitlementType? EntitlementType { get; set; }

        [JsonPropertyName("ext")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? Ext { get; set; }

        [JsonPropertyName("features")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Features { get; set; }

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
        public FullItemInfoItemType? ItemType { get; set; }

        [JsonPropertyName("listable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Listable { get; set; }

        [JsonPropertyName("localizations")]
        public Dictionary<string, Localization>? Localizations { get; set; }

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

        [JsonPropertyName("regionData")]
        public Dictionary<string, object>? RegionData { get; set; }

        [JsonPropertyName("seasonType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public FullItemInfoSeasonType? SeasonType { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("stackable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Stackable { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public FullItemInfoStatus? Status { get; set; }

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

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("useCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? UseCount { get; set; }

    }

    public class FullItemInfoAppType : StringEnum<FullItemInfoAppType>
    {
        public static readonly FullItemInfoAppType DEMO
            = new FullItemInfoAppType("DEMO");

        public static readonly FullItemInfoAppType DLC
            = new FullItemInfoAppType("DLC");

        public static readonly FullItemInfoAppType GAME
            = new FullItemInfoAppType("GAME");

        public static readonly FullItemInfoAppType SOFTWARE
            = new FullItemInfoAppType("SOFTWARE");


        public static implicit operator FullItemInfoAppType(string value)
        {
            return NewValue(value);
        }

        public FullItemInfoAppType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class FullItemInfoEntitlementType : StringEnum<FullItemInfoEntitlementType>
    {
        public static readonly FullItemInfoEntitlementType CONSUMABLE
            = new FullItemInfoEntitlementType("CONSUMABLE");

        public static readonly FullItemInfoEntitlementType DURABLE
            = new FullItemInfoEntitlementType("DURABLE");


        public static implicit operator FullItemInfoEntitlementType(string value)
        {
            return NewValue(value);
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

        public static readonly FullItemInfoItemType BUNDLE
            = new FullItemInfoItemType("BUNDLE");

        public static readonly FullItemInfoItemType CODE
            = new FullItemInfoItemType("CODE");

        public static readonly FullItemInfoItemType COINS
            = new FullItemInfoItemType("COINS");

        public static readonly FullItemInfoItemType EXTENSION
            = new FullItemInfoItemType("EXTENSION");

        public static readonly FullItemInfoItemType INGAMEITEM
            = new FullItemInfoItemType("INGAMEITEM");

        public static readonly FullItemInfoItemType MEDIA
            = new FullItemInfoItemType("MEDIA");

        public static readonly FullItemInfoItemType OPTIONBOX
            = new FullItemInfoItemType("OPTIONBOX");

        public static readonly FullItemInfoItemType SEASON
            = new FullItemInfoItemType("SEASON");

        public static readonly FullItemInfoItemType SUBSCRIPTION
            = new FullItemInfoItemType("SUBSCRIPTION");


        public static implicit operator FullItemInfoItemType(string value)
        {
            return NewValue(value);
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
            return NewValue(value);
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
            return NewValue(value);
        }

        public FullItemInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}