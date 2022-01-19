using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsMemberRequestGroupResponseV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("groupId")]
        public string? GroupId { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}