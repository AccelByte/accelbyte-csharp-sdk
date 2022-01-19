using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelResetPasswordRequestV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }
        
        [JsonPropertyName("emailAddress")]
        public string? EmailAddress { get; set; }
        
        [JsonPropertyName("newPassword")]
        public string? NewPassword { get; set; }
        
    }
}