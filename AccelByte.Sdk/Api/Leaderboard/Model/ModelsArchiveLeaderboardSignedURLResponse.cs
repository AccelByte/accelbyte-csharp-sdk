using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsArchiveLeaderboardSignedURLResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("leaderboardCode")]
        public string? LeaderboardCode { get; set; }
        
        [JsonPropertyName("url")]
        public string? Url { get; set; }
        
    }
}