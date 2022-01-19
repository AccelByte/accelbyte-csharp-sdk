using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsAllianceFlexingRule : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("duration")]
        public long? Duration { get; set; }
        
        [JsonPropertyName("max_number")]
        public int? MaxNumber { get; set; }
        
        [JsonPropertyName("min_number")]
        public int? MinNumber { get; set; }
        
        [JsonPropertyName("player_max_number")]
        public int? PlayerMaxNumber { get; set; }
        
        [JsonPropertyName("player_min_number")]
        public int? PlayerMinNumber { get; set; }
        
    }
}