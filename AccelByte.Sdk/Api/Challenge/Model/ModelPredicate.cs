// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Challenge.Model
{
    public class ModelPredicate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("matcher")]
        [JsonStringEnum]
        public ModelPredicateMatcher? Matcher { get; set; }

        [JsonPropertyName("parameterName")]
        public string? ParameterName { get; set; }

        [JsonPropertyName("parameterType")]
        [JsonStringEnum]
        public ModelPredicateParameterType? ParameterType { get; set; }

        [JsonPropertyName("statCycleId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? StatCycleId { get; set; }

        [JsonPropertyName("targetValue")]
        public double? TargetValue { get; set; }

    }



    public class ModelPredicateMatcher : StringEnum<ModelPredicateMatcher>
    {
        public static readonly ModelPredicateMatcher EQUAL
            = new ModelPredicateMatcher("EQUAL");

        public static readonly ModelPredicateMatcher GREATERTHAN
            = new ModelPredicateMatcher("GREATER_THAN");

        public static readonly ModelPredicateMatcher GREATERTHANEQUAL
            = new ModelPredicateMatcher("GREATER_THAN_EQUAL");

        public static readonly ModelPredicateMatcher LESSTHAN
            = new ModelPredicateMatcher("LESS_THAN");

        public static readonly ModelPredicateMatcher LESSTHANEQUAL
            = new ModelPredicateMatcher("LESS_THAN_EQUAL");


        public static implicit operator ModelPredicateMatcher(string value)
        {
            return NewValue(value);
        }

        public ModelPredicateMatcher(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ModelPredicateParameterType : StringEnum<ModelPredicateParameterType>
    {
        public static readonly ModelPredicateParameterType ACHIEVEMENT
            = new ModelPredicateParameterType("ACHIEVEMENT");

        public static readonly ModelPredicateParameterType STATISTIC
            = new ModelPredicateParameterType("STATISTIC");

        public static readonly ModelPredicateParameterType STATISTICCYCLE
            = new ModelPredicateParameterType("STATISTIC_CYCLE");

        public static readonly ModelPredicateParameterType USERACCOUNT
            = new ModelPredicateParameterType("USERACCOUNT");


        public static implicit operator ModelPredicateParameterType(string value)
        {
            return NewValue(value);
        }

        public ModelPredicateParameterType(string enumValue)
            : base(enumValue)
        {

        }
    }
}