using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsUserRankingResponseDetail : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalData")]
        public Dictionary<string, object>? AdditionalData { get; set; }
        
        [JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }
        
        [JsonPropertyName("point")]
        public double? Point { get; set; }
        
        [JsonPropertyName("rank")]
        public long? Rank { get; set; }
        
    }
}