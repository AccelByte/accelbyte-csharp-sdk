using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelPlatformDomainUpdateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("affectedClientIDs")]
        public List<string>? AffectedClientIDs { get; set; }
        
        [JsonPropertyName("assignedNamespaces")]
        public List<string>? AssignedNamespaces { get; set; }
        
        [JsonPropertyName("domain")]
        public string? Domain { get; set; }
        
        [JsonPropertyName("roleId")]
        public string? RoleId { get; set; }
        
    }
}