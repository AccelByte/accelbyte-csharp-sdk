using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonRoleMember : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("Namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("UserId")]
        public string? UserId { get; set; }
        
    }
}