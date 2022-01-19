using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserUpdateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Country")]
        public string? Country { get; set; }
        
        [JsonPropertyName("DateOfBirth")]
        public string? DateOfBirth { get; set; }
        
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("LanguageTag")]
        public string? LanguageTag { get; set; }
        
    }
}