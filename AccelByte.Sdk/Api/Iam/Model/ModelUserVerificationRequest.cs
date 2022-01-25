using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserVerificationRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Code")]
        public string? Code { get; set; }
        
        [JsonPropertyName("ContactType")]
        public string? ContactType { get; set; }
        
        [JsonPropertyName("LanguageTag")]
        public string? LanguageTag { get; set; }
        
    }
}