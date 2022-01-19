using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsGetAllLeaderboardConfigsPublicResp : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelsGetLeaderboardConfigPublicResp>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelsPagination? Paging { get; set; }
        
    }
}