// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PlatformReward : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currency")]
        public PlatformRewardCurrency? Currency { get; set; }

        [JsonPropertyName("item")]
        public PlatformRewardItem? Item { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public PlatformRewardType? Type { get; set; }

    }

    public class PlatformRewardType : StringEnum<PlatformRewardType>
    {
        public static readonly PlatformRewardType ITEM
            = new PlatformRewardType("ITEM");

        public static readonly PlatformRewardType CURRENCY
            = new PlatformRewardType("CURRENCY");


        public static implicit operator PlatformRewardType(string value)
        {
            return Create(value);
        }

        public PlatformRewardType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}