using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsUpdateMemberRolePermissionsRequestV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("memberRolePermissions")]
        public List<ModelsRolePermission>? MemberRolePermissions { get; set; }
        
    }
}