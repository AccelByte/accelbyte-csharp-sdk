using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserVerificationRequestV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }
        
        [JsonPropertyName("contactType")]
        public string? ContactType { get; set; }
        
        [JsonPropertyName("languageTag")]
        public string? LanguageTag { get; set; }
        
    }
}