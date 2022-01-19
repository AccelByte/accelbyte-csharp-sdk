using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsDailyConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("resetTime")]
        public string? ResetTime { get; set; }
        
    }
}