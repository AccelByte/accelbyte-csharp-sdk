using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUpgradeHeadlessAccountWithVerificationCodeRequestV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }
        
        [JsonPropertyName("country")]
        public string? Country { get; set; }
        
        [JsonPropertyName("dateOfBirth")]
        public string? DateOfBirth { get; set; }
        
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("emailAddress")]
        public string? EmailAddress { get; set; }
        
        [JsonPropertyName("password")]
        public string? Password { get; set; }
        
    }
}