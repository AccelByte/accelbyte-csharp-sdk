using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class UserGameProfiles : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("gameProfiles")]
        public List<GameProfilePublicInfo>? GameProfiles { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}