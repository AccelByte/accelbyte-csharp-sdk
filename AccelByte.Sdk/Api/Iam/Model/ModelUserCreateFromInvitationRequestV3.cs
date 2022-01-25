using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserCreateFromInvitationRequestV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("acceptedPolicies")]
        public List<LegalAcceptedPoliciesRequest>? AcceptedPolicies { get; set; }
        
        [JsonPropertyName("authType")]
        public string? AuthType { get; set; }
        
        [JsonPropertyName("country")]
        public string? Country { get; set; }
        
        [JsonPropertyName("dateOfBirth")]
        public string? DateOfBirth { get; set; }
        
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("password")]
        public string? Password { get; set; }
        
    }
}