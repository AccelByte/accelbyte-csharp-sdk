using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserPasswordUpdateV3Request : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("languageTag")]
        public string? LanguageTag { get; set; }
        
        [JsonPropertyName("newPassword")]
        public string? NewPassword { get; set; }
        
        [JsonPropertyName("oldPassword")]
        public string? OldPassword { get; set; }
        
    }
}