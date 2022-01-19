using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelSendVerificationCodeRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Context")]
        public string? Context { get; set; }
        
        [JsonPropertyName("LanguageTag")]
        public string? LanguageTag { get; set; }
        
        [JsonPropertyName("LoginID")]
        public string? LoginID { get; set; }
        
    }
}