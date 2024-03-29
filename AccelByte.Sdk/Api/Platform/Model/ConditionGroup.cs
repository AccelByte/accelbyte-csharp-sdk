// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ConditionGroup : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("operator")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ConditionGroupOperator? Operator { get; set; }

        [JsonPropertyName("predicates")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Predicate>? Predicates { get; set; }

    }



    public class ConditionGroupOperator : StringEnum<ConditionGroupOperator>
    {
        public static readonly ConditionGroupOperator And
            = new ConditionGroupOperator("and");

        public static readonly ConditionGroupOperator Or
            = new ConditionGroupOperator("or");


        public static implicit operator ConditionGroupOperator(string value)
        {
            return NewValue(value);
        }

        public ConditionGroupOperator(string enumValue)
            : base(enumValue)
        {

        }
    }
}