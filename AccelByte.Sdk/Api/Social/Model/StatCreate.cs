// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class StatCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("cycleIds")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? CycleIds { get; set; }

        [JsonPropertyName("defaultValue")]
        public double? DefaultValue { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("globalAggregationMethod")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public StatCreateGlobalAggregationMethod? GlobalAggregationMethod { get; set; }

        [JsonPropertyName("ignoreAdditionalDataOnValueRejected")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IgnoreAdditionalDataOnValueRejected { get; set; }

        [JsonPropertyName("incrementOnly")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IncrementOnly { get; set; }

        [JsonPropertyName("isPublic")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsPublic { get; set; }

        [JsonPropertyName("maximum")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? Maximum { get; set; }

        [JsonPropertyName("minimum")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? Minimum { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("setAsGlobal")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? SetAsGlobal { get; set; }

        [JsonPropertyName("setBy")]
        [JsonStringEnum]
        public StatCreateSetBy? SetBy { get; set; }

        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }

        [JsonPropertyName("tags")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Tags { get; set; }

    }



    public class StatCreateGlobalAggregationMethod : StringEnum<StatCreateGlobalAggregationMethod>
    {
        public static readonly StatCreateGlobalAggregationMethod LAST
            = new StatCreateGlobalAggregationMethod("LAST");

        public static readonly StatCreateGlobalAggregationMethod MAX
            = new StatCreateGlobalAggregationMethod("MAX");

        public static readonly StatCreateGlobalAggregationMethod MIN
            = new StatCreateGlobalAggregationMethod("MIN");

        public static readonly StatCreateGlobalAggregationMethod TOTAL
            = new StatCreateGlobalAggregationMethod("TOTAL");


        public static implicit operator StatCreateGlobalAggregationMethod(string value)
        {
            return NewValue(value);
        }

        public StatCreateGlobalAggregationMethod(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class StatCreateSetBy : StringEnum<StatCreateSetBy>
    {
        public static readonly StatCreateSetBy CLIENT
            = new StatCreateSetBy("CLIENT");

        public static readonly StatCreateSetBy SERVER
            = new StatCreateSetBy("SERVER");


        public static implicit operator StatCreateSetBy(string value)
        {
            return NewValue(value);
        }

        public StatCreateSetBy(string enumValue)
            : base(enumValue)
        {

        }
    }
}