using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsDeleteBulkLeaderboardsResp : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("failed")]
        public List<ModelsDeleteBulkLeaderboardFailedResp>? Failed { get; set; }
        
    }
}