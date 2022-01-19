using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelForgotPasswordRequestV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("emailAddress")]
        public string? EmailAddress { get; set; }
        
        [JsonPropertyName("languageTag")]
        public string? LanguageTag { get; set; }
        
    }
}