// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class RewardUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currency")]
        public RewardCurrency? Currency { get; set; }

        [JsonPropertyName("image")]
        public Image? Image { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("nullFields")]
        public List<string>? NullFields { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public RewardUpdateType? Type { get; set; }

    }

    public class RewardUpdateType : StringEnum<RewardUpdateType>
    {
        public static readonly RewardUpdateType ITEM
            = new RewardUpdateType("ITEM");

        public static readonly RewardUpdateType CURRENCY
            = new RewardUpdateType("CURRENCY");


        public static implicit operator RewardUpdateType(string value)
        {
            return NewValue(value);
        }

        public RewardUpdateType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}