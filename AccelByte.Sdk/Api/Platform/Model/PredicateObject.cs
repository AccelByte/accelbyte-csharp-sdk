// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PredicateObject : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("anyOf")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? AnyOf { get; set; }

        [JsonPropertyName("comparison")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PredicateObjectComparison? Comparison { get; set; }

        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }

        [JsonPropertyName("predicateType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PredicateObjectPredicateType? PredicateType { get; set; }

        [JsonPropertyName("value")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Value { get; set; }

        [JsonPropertyName("values")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Values { get; set; }

    }



    public class PredicateObjectComparison : StringEnum<PredicateObjectComparison>
    {
        public static readonly PredicateObjectComparison Excludes
            = new PredicateObjectComparison("excludes");

        public static readonly PredicateObjectComparison Includes
            = new PredicateObjectComparison("includes");

        public static readonly PredicateObjectComparison Is
            = new PredicateObjectComparison("is");

        public static readonly PredicateObjectComparison IsGreaterThan
            = new PredicateObjectComparison("isGreaterThan");

        public static readonly PredicateObjectComparison IsGreaterThanOrEqual
            = new PredicateObjectComparison("isGreaterThanOrEqual");

        public static readonly PredicateObjectComparison IsLessThan
            = new PredicateObjectComparison("isLessThan");

        public static readonly PredicateObjectComparison IsLessThanOrEqual
            = new PredicateObjectComparison("isLessThanOrEqual");

        public static readonly PredicateObjectComparison IsNot
            = new PredicateObjectComparison("isNot");


        public static implicit operator PredicateObjectComparison(string value)
        {
            return NewValue(value);
        }

        public PredicateObjectComparison(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class PredicateObjectPredicateType : StringEnum<PredicateObjectPredicateType>
    {
        public static readonly PredicateObjectPredicateType EntitlementPredicate
            = new PredicateObjectPredicateType("EntitlementPredicate");

        public static readonly PredicateObjectPredicateType SeasonPassPredicate
            = new PredicateObjectPredicateType("SeasonPassPredicate");

        public static readonly PredicateObjectPredicateType SeasonTierPredicate
            = new PredicateObjectPredicateType("SeasonTierPredicate");


        public static implicit operator PredicateObjectPredicateType(string value)
        {
            return NewValue(value);
        }

        public PredicateObjectPredicateType(string enumValue)
            : base(enumValue)
        {

        }
    }
}