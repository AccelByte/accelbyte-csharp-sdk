// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class RewardCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("currency")]
        public RewardCurrency? Currency { get; set; }

        [JsonPropertyName("image")]
        public Image? Image { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public RewardCreateType? Type { get; set; }

    }

    public class RewardCreateType : StringEnum<RewardCreateType>
    {
        public static readonly RewardCreateType ITEM
            = new RewardCreateType("ITEM");

        public static readonly RewardCreateType CURRENCY
            = new RewardCreateType("CURRENCY");


        public static implicit operator RewardCreateType(string value)
        {
            return Create(value);
        }

        public RewardCreateType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}