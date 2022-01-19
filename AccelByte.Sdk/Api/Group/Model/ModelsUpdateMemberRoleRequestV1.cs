using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsUpdateMemberRoleRequestV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("memberRoleName")]
        public string? MemberRoleName { get; set; }
        
    }
}