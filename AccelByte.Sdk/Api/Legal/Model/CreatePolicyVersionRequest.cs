using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class CreatePolicyVersionRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("displayVersion")]
        public string? DisplayVersion { get; set; }
        
        [JsonPropertyName("isCommitted")]
        public bool? IsCommitted { get; set; }
        
    }
}