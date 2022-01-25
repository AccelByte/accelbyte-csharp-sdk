using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelRoleResponseWithManagersV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("adminRole")]
        public bool? AdminRole { get; set; }
        
        [JsonPropertyName("isWildcard")]
        public bool? IsWildcard { get; set; }
        
        [JsonPropertyName("managers")]
        public List<AccountcommonRoleManagerV3>? Managers { get; set; }
        
        [JsonPropertyName("permissions")]
        public List<AccountcommonPermissionV3>? Permissions { get; set; }
        
        [JsonPropertyName("roleId")]
        public string? RoleId { get; set; }
        
        [JsonPropertyName("roleName")]
        public string? RoleName { get; set; }
        
    }
}