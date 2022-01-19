using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelResetPasswordRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Code")]
        public string? Code { get; set; }
        
        [JsonPropertyName("LoginID")]
        public string? LoginID { get; set; }
        
        [JsonPropertyName("NewPassword")]
        public string? NewPassword { get; set; }
        
    }
}