// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class RewardInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("currency")]
        public RewardCurrency? Currency { get; set; }

        [JsonPropertyName("image")]
        public Image? Image { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemName")]
        public string? ItemName { get; set; }

        [JsonPropertyName("itemSku")]
        public string? ItemSku { get; set; }

        [JsonPropertyName("itemType")]
        [JsonStringEnum]
        public RewardInfoItemType? ItemType { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("seasonId")]
        public string? SeasonId { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public RewardInfoType? Type { get; set; }

    }

    public class RewardInfoItemType : StringEnum<RewardInfoItemType>
    {
        public static readonly RewardInfoItemType APP
            = new RewardInfoItemType("APP");

        public static readonly RewardInfoItemType COINS
            = new RewardInfoItemType("COINS");

        public static readonly RewardInfoItemType INGAMEITEM
            = new RewardInfoItemType("INGAMEITEM");

        public static readonly RewardInfoItemType BUNDLE
            = new RewardInfoItemType("BUNDLE");

        public static readonly RewardInfoItemType CODE
            = new RewardInfoItemType("CODE");

        public static readonly RewardInfoItemType SUBSCRIPTION
            = new RewardInfoItemType("SUBSCRIPTION");

        public static readonly RewardInfoItemType SEASON
            = new RewardInfoItemType("SEASON");


        public static implicit operator RewardInfoItemType(string value)
        {
            return Create(value);
        }

        public RewardInfoItemType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class RewardInfoType : StringEnum<RewardInfoType>
    {
        public static readonly RewardInfoType ITEM
            = new RewardInfoType("ITEM");

        public static readonly RewardInfoType CURRENCY
            = new RewardInfoType("CURRENCY");


        public static implicit operator RewardInfoType(string value)
        {
            return Create(value);
        }

        public RewardInfoType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}