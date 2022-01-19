using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class UserProfilePublicInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("avatarLargeUrl")]
        public string? AvatarLargeUrl { get; set; }
        
        [JsonPropertyName("avatarSmallUrl")]
        public string? AvatarSmallUrl { get; set; }
        
        [JsonPropertyName("avatarUrl")]
        public string? AvatarUrl { get; set; }
        
        [JsonPropertyName("customAttributes")]
        public Dictionary<object, object>? CustomAttributes { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("timeZone")]
        public string? TimeZone { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}