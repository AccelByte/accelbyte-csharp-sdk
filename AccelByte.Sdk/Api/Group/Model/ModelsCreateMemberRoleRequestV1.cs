using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsCreateMemberRoleRequestV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("memberRoleName")]
        public string? MemberRoleName { get; set; }
        
        [JsonPropertyName("memberRolePermissions")]
        public List<ModelsRolePermission>? MemberRolePermissions { get; set; }
        
    }
}