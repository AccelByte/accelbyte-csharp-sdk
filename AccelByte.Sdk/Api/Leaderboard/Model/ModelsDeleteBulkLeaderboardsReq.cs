using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsDeleteBulkLeaderboardsReq : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("leaderboardCodes")]
        public List<string>? LeaderboardCodes { get; set; }
        
    }
}