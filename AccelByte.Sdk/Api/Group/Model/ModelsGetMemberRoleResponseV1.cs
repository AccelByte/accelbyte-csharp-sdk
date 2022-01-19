using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsGetMemberRoleResponseV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("memberRoleId")]
        public string? MemberRoleId { get; set; }
        
        [JsonPropertyName("memberRoleName")]
        public string? MemberRoleName { get; set; }
        
        [JsonPropertyName("memberRolePermissions")]
        public List<ModelsRolePermission>? MemberRolePermissions { get; set; }
        
    }
}