using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class EventPayload : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("payload")]
        public Dictionary<object, object>? Payload { get; set; }
        
    }
}