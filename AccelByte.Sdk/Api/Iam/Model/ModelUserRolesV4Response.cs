using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserRolesV4Response : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("assignedNamespaces")]
        public List<string>? AssignedNamespaces { get; set; }
        
        [JsonPropertyName("roleId")]
        public string? RoleId { get; set; }
        
        [JsonPropertyName("roleName")]
        public string? RoleName { get; set; }
        
    }
}