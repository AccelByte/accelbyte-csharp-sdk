// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsRuleInformation : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ruleAttribute")]
        public string? RuleAttribute { get; set; }

        [JsonPropertyName("ruleCriteria")]
        [JsonStringEnum]
        public ModelsRuleInformationRuleCriteria? RuleCriteria { get; set; }

        [JsonPropertyName("ruleValue")]
        public double? RuleValue { get; set; }

    }



    public class ModelsRuleInformationRuleCriteria : StringEnum<ModelsRuleInformationRuleCriteria>
    {
        public static readonly ModelsRuleInformationRuleCriteria EQUAL
            = new ModelsRuleInformationRuleCriteria("EQUAL");

        public static readonly ModelsRuleInformationRuleCriteria MAXIMUM
            = new ModelsRuleInformationRuleCriteria("MAXIMUM");

        public static readonly ModelsRuleInformationRuleCriteria MINIMUM
            = new ModelsRuleInformationRuleCriteria("MINIMUM");


        public static implicit operator ModelsRuleInformationRuleCriteria(string value)
        {
            return NewValue(value);
        }

        public ModelsRuleInformationRuleCriteria(string enumValue)
            : base(enumValue)
        {

        }
    }
}