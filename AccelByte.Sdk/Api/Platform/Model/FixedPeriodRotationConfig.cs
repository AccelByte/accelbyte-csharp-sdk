// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FixedPeriodRotationConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("duration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Duration { get; set; }

        [JsonPropertyName("itemCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? ItemCount { get; set; }

        [JsonPropertyName("rule")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public FixedPeriodRotationConfigRule? Rule { get; set; }

    }

    public class FixedPeriodRotationConfigRule : StringEnum<FixedPeriodRotationConfigRule>
    {
        public static readonly FixedPeriodRotationConfigRule SEQUENCE
            = new FixedPeriodRotationConfigRule("SEQUENCE");


        public static implicit operator FixedPeriodRotationConfigRule(string value)
        {
            return NewValue(value);
        }

        public FixedPeriodRotationConfigRule(string enumValue)
            : base(enumValue)
        {

        }
    }    
}