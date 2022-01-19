using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsUpdateUserPointAdminV1Response : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("point")]
        public double? Point { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}