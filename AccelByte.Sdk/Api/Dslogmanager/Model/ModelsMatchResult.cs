using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dslogmanager.Model
{
    public class ModelsMatchResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("game_mode")]
        public string? GameMode { get; set; }
        
        [JsonPropertyName("matching_allies")]
        public List<ModelsRequestMatchingAlly>? MatchingAllies { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("session_id")]
        public string? SessionId { get; set; }
        
    }
}