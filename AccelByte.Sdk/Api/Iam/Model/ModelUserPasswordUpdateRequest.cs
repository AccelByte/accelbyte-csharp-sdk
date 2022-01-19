using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserPasswordUpdateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("LanguageTag")]
        public string? LanguageTag { get; set; }
        
        [JsonPropertyName("NewPassword")]
        public string? NewPassword { get; set; }
        
        [JsonPropertyName("OldPassword")]
        public string? OldPassword { get; set; }
        
    }
}