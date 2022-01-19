using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class V2GetAllLeaderboardConfigsPublicResp : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<V2GetLeaderboardConfigPublicResp>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public V2Pagination? Paging { get; set; }
        
    }
}