using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserBaseInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("avatarUrl")]
        public string? AvatarUrl { get; set; }
        
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}