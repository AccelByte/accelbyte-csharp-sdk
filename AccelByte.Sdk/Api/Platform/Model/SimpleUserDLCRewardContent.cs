// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class SimpleUserDLCRewardContent : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currency")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PlatformRewardCurrency? Currency { get; set; }

        [JsonPropertyName("item")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public SimpleDLCRewardItem? Item { get; set; }

        [JsonPropertyName("obtainedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ObtainedAt { get; set; }

        [JsonPropertyName("quantity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Quantity { get; set; }

        [JsonPropertyName("type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public SimpleUserDLCRewardContentType? Type { get; set; }

    }



    public class SimpleUserDLCRewardContentType : StringEnum<SimpleUserDLCRewardContentType>
    {
        public static readonly SimpleUserDLCRewardContentType CURRENCY
            = new SimpleUserDLCRewardContentType("CURRENCY");

        public static readonly SimpleUserDLCRewardContentType ITEM
            = new SimpleUserDLCRewardContentType("ITEM");


        public static implicit operator SimpleUserDLCRewardContentType(string value)
        {
            return NewValue(value);
        }

        public SimpleUserDLCRewardContentType(string enumValue)
            : base(enumValue)
        {

        }
    }
}