using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserUpdateRequestV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("country")]
        public string? Country { get; set; }
        
        [JsonPropertyName("dateOfBirth")]
        public string? DateOfBirth { get; set; }
        
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("languageTag")]
        public string? LanguageTag { get; set; }
        
        [JsonPropertyName("userName")]
        public string? UserName { get; set; }
        
    }
}