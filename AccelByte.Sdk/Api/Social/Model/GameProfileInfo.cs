using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class GameProfileInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("achievements")]
        public List<string>? Achievements { get; set; }
        
        [JsonPropertyName("attributes")]
        public Dictionary<string, string>? Attributes { get; set; }
        
        [JsonPropertyName("avatarUrl")]
        public string? AvatarUrl { get; set; }
        
        [JsonPropertyName("inventories")]
        public List<string>? Inventories { get; set; }
        
        [JsonPropertyName("label")]
        public string? Label { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("profileId")]
        public string? ProfileId { get; set; }
        
        [JsonPropertyName("profileName")]
        public string? ProfileName { get; set; }
        
        [JsonPropertyName("statistics")]
        public List<string>? Statistics { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}