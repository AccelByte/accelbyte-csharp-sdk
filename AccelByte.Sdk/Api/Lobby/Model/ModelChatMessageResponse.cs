using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelChatMessageResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("from")]
        public string? From { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("payload")]
        public string? Payload { get; set; }
        
        [JsonPropertyName("receivedAt")]
        public long? ReceivedAt { get; set; }
        
        [JsonPropertyName("to")]
        public string? To { get; set; }
        
    }
}