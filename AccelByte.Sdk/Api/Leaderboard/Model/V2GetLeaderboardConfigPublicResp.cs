using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class V2GetLeaderboardConfigPublicResp : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("iconURL")]
        public string? IconURL { get; set; }
        
        [JsonPropertyName("leaderboardCode")]
        public string? LeaderboardCode { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }
        
    }
}