// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsUpdateRuleset : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("alliance")]
        public ModelsUpdateAllianceRule? Alliance { get; set; }

        [JsonPropertyName("alliance_flexing_rule")]
        public List<ModelsAllianceFlexingRule>? AllianceFlexingRule { get; set; }

        [JsonPropertyName("flexingRules")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ModelsFlexingRule>? FlexingRules { get; set; }

        [JsonPropertyName("match_options")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsMatchOptionRule? MatchOptions { get; set; }

        [JsonPropertyName("matchingRules")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ModelsMatchingRule>? MatchingRules { get; set; }

        [JsonPropertyName("sub_game_modes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsUpdateRulesetSubGameModes? SubGameModes { get; set; }

    }


}