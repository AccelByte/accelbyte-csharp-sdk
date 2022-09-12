// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class AvailableComparisonObject : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("comparison")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public AvailableComparisonObjectComparison? Comparison { get; set; }

        [JsonPropertyName("text")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Text { get; set; }

    }

    public class AvailableComparisonObjectComparison : StringEnum<AvailableComparisonObjectComparison>
    {
        public static readonly AvailableComparisonObjectComparison Excludes
            = new AvailableComparisonObjectComparison("excludes");

        public static readonly AvailableComparisonObjectComparison Includes
            = new AvailableComparisonObjectComparison("includes");

        public static readonly AvailableComparisonObjectComparison Is
            = new AvailableComparisonObjectComparison("is");

        public static readonly AvailableComparisonObjectComparison IsGreaterThan
            = new AvailableComparisonObjectComparison("isGreaterThan");

        public static readonly AvailableComparisonObjectComparison IsGreaterThanOrEqual
            = new AvailableComparisonObjectComparison("isGreaterThanOrEqual");

        public static readonly AvailableComparisonObjectComparison IsLessThan
            = new AvailableComparisonObjectComparison("isLessThan");

        public static readonly AvailableComparisonObjectComparison IsLessThanOrEqual
            = new AvailableComparisonObjectComparison("isLessThanOrEqual");

        public static readonly AvailableComparisonObjectComparison IsNot
            = new AvailableComparisonObjectComparison("isNot");


        public static implicit operator AvailableComparisonObjectComparison(string value)
        {
            return NewValue(value);
        }

        public AvailableComparisonObjectComparison(string enumValue)
            : base(enumValue)
        {

        }
    }
}