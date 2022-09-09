// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class AvailablePredicateObject : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("availableComparisons")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<AvailableComparisonObject>? AvailableComparisons { get; set; }

        [JsonPropertyName("predicateType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public AvailablePredicateObjectPredicateType? PredicateType { get; set; }

        [JsonPropertyName("showAnyOf")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ShowAnyOf { get; set; }

        [JsonPropertyName("valueType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public AvailablePredicateObjectValueType? ValueType { get; set; }

    }

    public class AvailablePredicateObjectPredicateType : StringEnum<AvailablePredicateObjectPredicateType>
    {
        public static readonly AvailablePredicateObjectPredicateType EntitlementPredicate
            = new AvailablePredicateObjectPredicateType("EntitlementPredicate");

        public static readonly AvailablePredicateObjectPredicateType SeasonPassPredicate
            = new AvailablePredicateObjectPredicateType("SeasonPassPredicate");

        public static readonly AvailablePredicateObjectPredicateType SeasonTierPredicate
            = new AvailablePredicateObjectPredicateType("SeasonTierPredicate");


        public static implicit operator AvailablePredicateObjectPredicateType(string value)
        {
            return NewValue(value);
        }

        public AvailablePredicateObjectPredicateType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class AvailablePredicateObjectValueType : StringEnum<AvailablePredicateObjectValueType>
    {
        public static readonly AvailablePredicateObjectValueType List
            = new AvailablePredicateObjectValueType("List");

        public static readonly AvailablePredicateObjectValueType Number
            = new AvailablePredicateObjectValueType("Number");

        public static readonly AvailablePredicateObjectValueType String
            = new AvailablePredicateObjectValueType("String");


        public static implicit operator AvailablePredicateObjectValueType(string value)
        {
            return NewValue(value);
        }

        public AvailablePredicateObjectValueType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}