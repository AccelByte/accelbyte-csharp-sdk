using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsGetHiddenUserResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<string>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelsPagination? Paging { get; set; }
        
    }
}