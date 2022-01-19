using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsGetLeaderboardRankingResp : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelsUserPoint>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelsPagination? Paging { get; set; }
        
    }
}