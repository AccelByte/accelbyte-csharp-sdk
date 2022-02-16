// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsRuleInformation : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ruleAttribute")]
        public string? RuleAttribute { get; set; }
        
        [JsonPropertyName("ruleCriteria")]
        public string? RuleCriteria { get; set; }
        
        [JsonPropertyName("ruleValue")]
        public double? RuleValue { get; set; }
        
    }
}