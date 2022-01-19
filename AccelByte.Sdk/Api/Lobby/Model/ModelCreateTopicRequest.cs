using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelCreateTopicRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("topic")]
        public string? Topic { get; set; }
        
    }
}