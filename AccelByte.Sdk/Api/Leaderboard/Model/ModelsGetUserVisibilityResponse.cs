using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsGetUserVisibilityResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
        [JsonPropertyName("visibility")]
        public bool? Visibility { get; set; }
        
    }
}