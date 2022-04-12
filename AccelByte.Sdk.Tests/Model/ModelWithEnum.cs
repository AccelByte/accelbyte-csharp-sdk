// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Tests.Model
{
    public class ModelWithEnum
    {
        [JsonPropertyName("ruleAttribute")]
        public string? RuleAttribute { get; set; }

        [JsonPropertyName("ruleCriteria")]
        [JsonStringEnum]
        public ModelWithEnumRuleCriteria? RuleCriteria { get; set; }

        [JsonPropertyName("ruleValue")]
        public double? RuleValue { get; set; }
    }

    public class ModelWithEnumRuleCriteria : StringEnum
    {
        public static readonly ModelWithEnumRuleCriteria EQUAL
            = new ModelWithEnumRuleCriteria("EQUAL");

        public static readonly ModelWithEnumRuleCriteria MINIMUM
            = new ModelWithEnumRuleCriteria("MINIMUM");

        public static readonly ModelWithEnumRuleCriteria MAXIMUM
            = new ModelWithEnumRuleCriteria("MAXIMUM");


        public static implicit operator ModelWithEnumRuleCriteria(string value)
        {
            return StringEnum.Create<ModelWithEnumRuleCriteria>(value);
        }

        public ModelWithEnumRuleCriteria(string enumValue)
            : base(enumValue)
        {

        }
    }
}