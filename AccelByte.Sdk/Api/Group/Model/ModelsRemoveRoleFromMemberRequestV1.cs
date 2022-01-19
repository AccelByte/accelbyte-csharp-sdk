using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsRemoveRoleFromMemberRequestV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}