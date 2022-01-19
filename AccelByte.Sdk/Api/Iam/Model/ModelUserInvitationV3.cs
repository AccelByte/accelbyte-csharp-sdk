using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserInvitationV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("email")]
        public string? Email { get; set; }
        
        [JsonPropertyName("expiredAt")]
        public DateTime? ExpiredAt { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("roles")]
        public List<AccountcommonNamespaceRole>? Roles { get; set; }
        
    }
}