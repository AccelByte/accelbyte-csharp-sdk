using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsGroupMember : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("memberRoleId")]
        public List<string>? MemberRoleId { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}