using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class UserProfileUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("avatarLargeUrl")]
        public string? AvatarLargeUrl { get; set; }
        
        [JsonPropertyName("avatarSmallUrl")]
        public string? AvatarSmallUrl { get; set; }
        
        [JsonPropertyName("avatarUrl")]
        public string? AvatarUrl { get; set; }
        
        [JsonPropertyName("customAttributes")]
        public Dictionary<object, object>? CustomAttributes { get; set; }
        
        [JsonPropertyName("dateOfBirth")]
        public DateTime? DateOfBirth { get; set; }
        
        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }
        
        [JsonPropertyName("language")]
        public string? Language { get; set; }
        
        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }
        
        [JsonPropertyName("timeZone")]
        public string? TimeZone { get; set; }
        
        [JsonPropertyName("zipCode")]
        public string? ZipCode { get; set; }
        
    }
}