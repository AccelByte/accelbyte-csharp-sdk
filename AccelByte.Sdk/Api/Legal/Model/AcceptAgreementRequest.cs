using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class AcceptAgreementRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("isAccepted")]
        public bool? IsAccepted { get; set; }
        
        [JsonPropertyName("localizedPolicyVersionId")]
        public string? LocalizedPolicyVersionId { get; set; }
        
        [JsonPropertyName("policyId")]
        public string? PolicyId { get; set; }
        
        [JsonPropertyName("policyVersionId")]
        public string? PolicyVersionId { get; set; }
        
    }
}