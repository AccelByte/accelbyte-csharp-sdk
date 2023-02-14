// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ItemNaming : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("categoryPath")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CategoryPath { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemType")]
        [JsonStringEnum]
        public ItemNamingItemType? ItemType { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("seasonType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ItemNamingSeasonType? SeasonType { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ItemNamingStatus? Status { get; set; }

    }



    public class ItemNamingItemType : StringEnum<ItemNamingItemType>
    {
        public static readonly ItemNamingItemType APP
            = new ItemNamingItemType("APP");

        public static readonly ItemNamingItemType BUNDLE
            = new ItemNamingItemType("BUNDLE");

        public static readonly ItemNamingItemType CODE
            = new ItemNamingItemType("CODE");

        public static readonly ItemNamingItemType COINS
            = new ItemNamingItemType("COINS");

        public static readonly ItemNamingItemType EXTENSION
            = new ItemNamingItemType("EXTENSION");

        public static readonly ItemNamingItemType INGAMEITEM
            = new ItemNamingItemType("INGAMEITEM");

        public static readonly ItemNamingItemType LOOTBOX
            = new ItemNamingItemType("LOOTBOX");

        public static readonly ItemNamingItemType MEDIA
            = new ItemNamingItemType("MEDIA");

        public static readonly ItemNamingItemType OPTIONBOX
            = new ItemNamingItemType("OPTIONBOX");

        public static readonly ItemNamingItemType SEASON
            = new ItemNamingItemType("SEASON");

        public static readonly ItemNamingItemType SUBSCRIPTION
            = new ItemNamingItemType("SUBSCRIPTION");


        public static implicit operator ItemNamingItemType(string value)
        {
            return NewValue(value);
        }

        public ItemNamingItemType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ItemNamingSeasonType : StringEnum<ItemNamingSeasonType>
    {
        public static readonly ItemNamingSeasonType PASS
            = new ItemNamingSeasonType("PASS");

        public static readonly ItemNamingSeasonType TIER
            = new ItemNamingSeasonType("TIER");


        public static implicit operator ItemNamingSeasonType(string value)
        {
            return NewValue(value);
        }

        public ItemNamingSeasonType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ItemNamingStatus : StringEnum<ItemNamingStatus>
    {
        public static readonly ItemNamingStatus ACTIVE
            = new ItemNamingStatus("ACTIVE");

        public static readonly ItemNamingStatus INACTIVE
            = new ItemNamingStatus("INACTIVE");


        public static implicit operator ItemNamingStatus(string value)
        {
            return NewValue(value);
        }

        public ItemNamingStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}