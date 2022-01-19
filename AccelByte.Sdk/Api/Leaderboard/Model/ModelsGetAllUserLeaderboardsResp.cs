using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsGetAllUserLeaderboardsResp : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelsUserLeaderboardRanking>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelsPagination? Paging { get; set; }
        
    }
}