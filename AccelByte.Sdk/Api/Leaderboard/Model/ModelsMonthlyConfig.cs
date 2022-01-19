using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsMonthlyConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("resetDate")]
        public long? ResetDate { get; set; }
        
        [JsonPropertyName("resetTime")]
        public string? ResetTime { get; set; }
        
    }
}