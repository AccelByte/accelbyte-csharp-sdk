// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class StatItemUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalData")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? AdditionalData { get; set; }

        [JsonPropertyName("updateStrategy")]
        [JsonStringEnum]
        public StatItemUpdateUpdateStrategy? UpdateStrategy { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }

    }

    public class StatItemUpdate<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalData")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? AdditionalData { get; set; }

        [JsonPropertyName("updateStrategy")]
        [JsonStringEnum]
        public StatItemUpdateUpdateStrategy? UpdateStrategy { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }

    }


    public class StatItemUpdateUpdateStrategy : StringEnum<StatItemUpdateUpdateStrategy>
    {
        public static readonly StatItemUpdateUpdateStrategy INCREMENT
            = new StatItemUpdateUpdateStrategy("INCREMENT");

        public static readonly StatItemUpdateUpdateStrategy MAX
            = new StatItemUpdateUpdateStrategy("MAX");

        public static readonly StatItemUpdateUpdateStrategy MIN
            = new StatItemUpdateUpdateStrategy("MIN");

        public static readonly StatItemUpdateUpdateStrategy OVERRIDE
            = new StatItemUpdateUpdateStrategy("OVERRIDE");


        public static implicit operator StatItemUpdateUpdateStrategy(string value)
        {
            return NewValue(value);
        }

        public StatItemUpdateUpdateStrategy(string enumValue)
            : base(enumValue)
        {

        }
    }
}