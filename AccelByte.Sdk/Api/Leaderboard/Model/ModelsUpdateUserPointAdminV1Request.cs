using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsUpdateUserPointAdminV1Request : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("inc")]
        public double? Inc { get; set; }
        
        [JsonPropertyName("latestValue")]
        public double? LatestValue { get; set; }
        
    }
}