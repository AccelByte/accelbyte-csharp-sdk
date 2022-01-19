using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class RetrieveUserEligibilitiesResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("baseUrls")]
        public List<string>? BaseUrls { get; set; }
        
        [JsonPropertyName("countryCode")]
        public string? CountryCode { get; set; }
        
        [JsonPropertyName("countryGroupCode")]
        public string? CountryGroupCode { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("isAccepted")]
        public bool? IsAccepted { get; set; }
        
        [JsonPropertyName("isMandatory")]
        public bool? IsMandatory { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("policyId")]
        public string? PolicyId { get; set; }
        
        [JsonPropertyName("policyName")]
        public string? PolicyName { get; set; }
        
        [JsonPropertyName("policyType")]
        public string? PolicyType { get; set; }
        
        [JsonPropertyName("policyVersions")]
        public List<PolicyVersionWithLocalizedVersionObject>? PolicyVersions { get; set; }
        
        [JsonPropertyName("readableId")]
        public string? ReadableId { get; set; }
        
    }
}