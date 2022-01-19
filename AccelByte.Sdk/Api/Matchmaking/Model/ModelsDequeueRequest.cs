using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsDequeueRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("match_id")]
        public string? MatchId { get; set; }
        
    }
}