using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsWeeklyConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("resetDay")]
        public long? ResetDay { get; set; }
        
        [JsonPropertyName("resetTime")]
        public string? ResetTime { get; set; }
        
    }
}