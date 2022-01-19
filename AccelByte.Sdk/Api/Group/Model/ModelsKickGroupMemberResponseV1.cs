using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsKickGroupMemberResponseV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("groupId")]
        public string? GroupId { get; set; }
        
        [JsonPropertyName("kickedUserId")]
        public string? KickedUserId { get; set; }
        
    }
}