using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class RetrieveAcceptedAgreementResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("countryCode")]
        public string? CountryCode { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("displayVersion")]
        public string? DisplayVersion { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("isAccepted")]
        public bool? IsAccepted { get; set; }
        
        [JsonPropertyName("localizedPolicyVersion")]
        public LocalizedPolicyVersionObject? LocalizedPolicyVersion { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("policyId")]
        public string? PolicyId { get; set; }
        
        [JsonPropertyName("policyName")]
        public string? PolicyName { get; set; }
        
        [JsonPropertyName("policyType")]
        public string? PolicyType { get; set; }
        
        [JsonPropertyName("signingDate")]
        public DateTime? SigningDate { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}