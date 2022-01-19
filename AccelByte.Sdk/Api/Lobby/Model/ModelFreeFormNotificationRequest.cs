using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelFreeFormNotificationRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        
        [JsonPropertyName("topic")]
        public string? Topic { get; set; }
        
    }
}