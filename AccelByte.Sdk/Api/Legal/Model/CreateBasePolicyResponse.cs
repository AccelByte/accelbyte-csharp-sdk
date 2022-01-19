using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class CreateBasePolicyResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("affectedClientIds")]
        public List<string>? AffectedClientIds { get; set; }
        
        [JsonPropertyName("affectedCountries")]
        public List<string>? AffectedCountries { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("globalPolicyName")]
        public string? GlobalPolicyName { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("policyId")]
        public string? PolicyId { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
        [JsonPropertyName("typeId")]
        public string? TypeId { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
    }
}