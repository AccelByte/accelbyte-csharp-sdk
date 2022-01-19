using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsMatchResultRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("match_id")]
        public string? MatchId { get; set; }
        
        [JsonPropertyName("players")]
        public List<ModelsPlayerResultRequest>? Players { get; set; }
        
    }
}