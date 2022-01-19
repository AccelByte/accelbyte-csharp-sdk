using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelRemoveUserRoleV4Request : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("assignedNamespaces")]
        public List<string>? AssignedNamespaces { get; set; }
        
        [JsonPropertyName("roleId")]
        public string? RoleId { get; set; }
        
    }
}