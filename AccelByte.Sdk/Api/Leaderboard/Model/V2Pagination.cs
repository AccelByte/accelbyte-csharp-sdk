using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class V2Pagination : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("first")]
        public string? First { get; set; }
        
        [JsonPropertyName("last")]
        public string? Last { get; set; }
        
        [JsonPropertyName("next")]
        public string? Next { get; set; }
        
        [JsonPropertyName("previous")]
        public string? Previous { get; set; }
        
    }
}