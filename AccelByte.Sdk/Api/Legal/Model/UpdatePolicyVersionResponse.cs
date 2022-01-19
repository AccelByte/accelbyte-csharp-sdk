using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class UpdatePolicyVersionResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("basePolicyId")]
        public string? BasePolicyId { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("displayVersion")]
        public string? DisplayVersion { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("isCommitted")]
        public bool? IsCommitted { get; set; }
        
        [JsonPropertyName("publishedDate")]
        public DateTime? PublishedDate { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
    }
}