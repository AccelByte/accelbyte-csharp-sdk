using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsMemberRequestResponseV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("groupId")]
        public string? GroupId { get; set; }
        
        [JsonPropertyName("requestType")]
        public string? RequestType { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}