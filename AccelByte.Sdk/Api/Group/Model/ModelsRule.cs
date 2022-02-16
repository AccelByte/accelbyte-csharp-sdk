// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsRule : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allowedAction")]
        public string? AllowedAction { get; set; }
        
        [JsonPropertyName("ruleDetail")]
        public List<ModelsRuleInformation>? RuleDetail { get; set; }
        
    }
}