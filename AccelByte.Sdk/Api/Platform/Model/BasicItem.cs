// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class BasicItem : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonStringEnum]
        public BasicItemAppType? AppType { get; set; }

        [JsonPropertyName("baseAppId")]
        public string? BaseAppId { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("entitlementType")]
        [JsonStringEnum]
        public BasicItemEntitlementType? EntitlementType { get; set; }

        [JsonPropertyName("features")]
        public List<string>? Features { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemType")]
        [JsonStringEnum]
        public BasicItemItemType? ItemType { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("seasonType")]
        [JsonStringEnum]
        public BasicItemSeasonType? SeasonType { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public BasicItemStatus? Status { get; set; }

        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("useCount")]
        public int? UseCount { get; set; }

    }

    public class BasicItemAppType : StringEnum<BasicItemAppType>
    {
        public static readonly BasicItemAppType DEMO
            = new BasicItemAppType("DEMO");

        public static readonly BasicItemAppType DLC
            = new BasicItemAppType("DLC");

        public static readonly BasicItemAppType GAME
            = new BasicItemAppType("GAME");

        public static readonly BasicItemAppType SOFTWARE
            = new BasicItemAppType("SOFTWARE");


        public static implicit operator BasicItemAppType(string value)
        {
            return NewValue(value);
        }

        public BasicItemAppType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class BasicItemEntitlementType : StringEnum<BasicItemEntitlementType>
    {
        public static readonly BasicItemEntitlementType CONSUMABLE
            = new BasicItemEntitlementType("CONSUMABLE");

        public static readonly BasicItemEntitlementType DURABLE
            = new BasicItemEntitlementType("DURABLE");


        public static implicit operator BasicItemEntitlementType(string value)
        {
            return NewValue(value);
        }

        public BasicItemEntitlementType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class BasicItemItemType : StringEnum<BasicItemItemType>
    {
        public static readonly BasicItemItemType APP
            = new BasicItemItemType("APP");

        public static readonly BasicItemItemType BUNDLE
            = new BasicItemItemType("BUNDLE");

        public static readonly BasicItemItemType CODE
            = new BasicItemItemType("CODE");

        public static readonly BasicItemItemType COINS
            = new BasicItemItemType("COINS");

        public static readonly BasicItemItemType INGAMEITEM
            = new BasicItemItemType("INGAMEITEM");

        public static readonly BasicItemItemType MEDIA
            = new BasicItemItemType("MEDIA");

        public static readonly BasicItemItemType OPTIONBOX
            = new BasicItemItemType("OPTIONBOX");

        public static readonly BasicItemItemType SEASON
            = new BasicItemItemType("SEASON");

        public static readonly BasicItemItemType SUBSCRIPTION
            = new BasicItemItemType("SUBSCRIPTION");


        public static implicit operator BasicItemItemType(string value)
        {
            return NewValue(value);
        }

        public BasicItemItemType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class BasicItemSeasonType : StringEnum<BasicItemSeasonType>
    {
        public static readonly BasicItemSeasonType PASS
            = new BasicItemSeasonType("PASS");

        public static readonly BasicItemSeasonType TIER
            = new BasicItemSeasonType("TIER");


        public static implicit operator BasicItemSeasonType(string value)
        {
            return NewValue(value);
        }

        public BasicItemSeasonType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class BasicItemStatus : StringEnum<BasicItemStatus>
    {
        public static readonly BasicItemStatus ACTIVE
            = new BasicItemStatus("ACTIVE");

        public static readonly BasicItemStatus INACTIVE
            = new BasicItemStatus("INACTIVE");


        public static implicit operator BasicItemStatus(string value)
        {
            return NewValue(value);
        }

        public BasicItemStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}