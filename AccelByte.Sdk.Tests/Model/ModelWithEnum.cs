// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Tests.Model
{
    public class ModelWithEnum
    {
        public string? RuleAttribute { get; set; }

        [JsonStringEnum]
        public ModelWithEnumRuleCriteria? RuleCriteria { get; set; }

        public double? RuleValue { get; set; }
    }

    public class ModelWithEnumRuleCriteria : StringEnum<ModelWithEnumRuleCriteria>
    {
        public static readonly ModelWithEnumRuleCriteria EQUAL
            = new ModelWithEnumRuleCriteria("EQUAL");

        public static readonly ModelWithEnumRuleCriteria MINIMUM
            = new ModelWithEnumRuleCriteria("MINIMUM");

        public static readonly ModelWithEnumRuleCriteria MAXIMUM
            = new ModelWithEnumRuleCriteria("MAXIMUM");

        public static implicit operator ModelWithEnumRuleCriteria(string value)
        {
            return NewValue(value);
        }

        public ModelWithEnumRuleCriteria(string enumValue)
            : base(enumValue)
        {

        }
    }
}