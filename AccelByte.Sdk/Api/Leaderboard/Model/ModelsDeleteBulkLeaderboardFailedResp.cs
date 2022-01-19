using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsDeleteBulkLeaderboardFailedResp : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("error")]
        public string? Error { get; set; }
        
        [JsonPropertyName("leaderboardCode")]
        public string? LeaderboardCode { get; set; }
        
    }
}