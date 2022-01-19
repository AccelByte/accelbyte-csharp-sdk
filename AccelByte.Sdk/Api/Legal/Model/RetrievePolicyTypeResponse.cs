using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class RetrievePolicyTypeResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("isNeedDocument")]
        public bool? IsNeedDocument { get; set; }
        
        [JsonPropertyName("policyTypeName")]
        public string? PolicyTypeName { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
    }
}