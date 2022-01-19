using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelAssignedUserV4Response : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("assignedNamespaces")]
        public List<string>? AssignedNamespaces { get; set; }
        
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("email")]
        public string? Email { get; set; }
        
        [JsonPropertyName("roleId")]
        public string? RoleId { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}