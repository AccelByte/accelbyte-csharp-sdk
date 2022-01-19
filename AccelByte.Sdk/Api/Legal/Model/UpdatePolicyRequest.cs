using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class UpdatePolicyRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("isDefaultOpted")]
        public bool? IsDefaultOpted { get; set; }
        
        [JsonPropertyName("isMandatory")]
        public bool? IsMandatory { get; set; }
        
        [JsonPropertyName("policyName")]
        public string? PolicyName { get; set; }
        
        [JsonPropertyName("readableId")]
        public string? ReadableId { get; set; }
        
        [JsonPropertyName("shouldNotifyOnUpdate")]
        public bool? ShouldNotifyOnUpdate { get; set; }
        
    }
}