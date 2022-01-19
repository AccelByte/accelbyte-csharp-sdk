using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelCreateTopicRequestV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("topicName")]
        public string? TopicName { get; set; }
        
    }
}