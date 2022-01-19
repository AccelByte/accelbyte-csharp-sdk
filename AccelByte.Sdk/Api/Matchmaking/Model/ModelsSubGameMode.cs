using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsSubGameMode : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("alliance")]
        public ModelsAllianceRule? Alliance { get; set; }
        
        [JsonPropertyName("alliance_flexing_rule")]
        public List<ModelsAllianceFlexingRule>? AllianceFlexingRule { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
    }
}