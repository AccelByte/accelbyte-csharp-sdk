using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class RetrieveBasePolicyResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("affectedClientIds")]
        public List<string>? AffectedClientIds { get; set; }
        
        [JsonPropertyName("basePolicyName")]
        public string? BasePolicyName { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("policies")]
        public List<PolicyObject>? Policies { get; set; }
        
        [JsonPropertyName("policyTypeId")]
        public string? PolicyTypeId { get; set; }
        
        [JsonPropertyName("policyTypeName")]
        public string? PolicyTypeName { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
    }
}