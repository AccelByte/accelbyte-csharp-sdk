using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsRuleSet : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("alliance")]
        public ModelsAllianceRule? Alliance { get; set; }
        
        [JsonPropertyName("alliance_flexing_rule")]
        public List<ModelsAllianceFlexingRule>? AllianceFlexingRule { get; set; }
        
        [JsonPropertyName("flexing_rule")]
        public List<ModelsFlexingRule>? FlexingRule { get; set; }
        
        [JsonPropertyName("match_options")]
        public ModelsMatchOptionRule? MatchOptions { get; set; }
        
        [JsonPropertyName("matching_rule")]
        public List<ModelsMatchingRule>? MatchingRule { get; set; }
        
        [JsonPropertyName("sub_game_modes")]
        public Dictionary<string, ModelsSubGameMode>? SubGameModes { get; set; }
        
    }
}