using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelNotificationTopicResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public long? CreatedAt { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("topic")]
        public string? Topic { get; set; }
        
    }
}