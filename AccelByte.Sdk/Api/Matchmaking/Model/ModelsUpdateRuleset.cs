// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
        public List<ModelsFlexingRule>? FlexingRules { get; set; }
        
        [JsonPropertyName("match_options")]
        public ModelsMatchOptionRule? MatchOptions { get; set; }
        
        [JsonPropertyName("matchingRules")]
        public List<ModelsMatchingRule>? MatchingRules { get; set; }
        
        [JsonPropertyName("sub_game_modes")]
        public ModelsUpdateRulesetSubGameModes? SubGameModes { get; set; }
        
    }
}