using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelBulkUsersFreeFormNotificationRequestV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        
        [JsonPropertyName("topicName")]
        public string? TopicName { get; set; }
        
        [JsonPropertyName("userIds")]
        public List<string>? UserIds { get; set; }
        
    }
}