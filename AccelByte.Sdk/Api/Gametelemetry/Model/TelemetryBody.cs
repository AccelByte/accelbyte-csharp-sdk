using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Gametelemetry.Model
{
    public class TelemetryBody : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("EventId")]
        public string? EventId { get; set; }
        
        [JsonPropertyName("EventName")]
        public string? EventName { get; set; }
        
        [JsonPropertyName("EventNamespace")]
        public string? EventNamespace { get; set; }
        
        [JsonPropertyName("EventTimestamp")]
        public DateTime? EventTimestamp { get; set; }
        
        [JsonPropertyName("Payload")]
        public Dictionary<string, object>? Payload { get; set; }
        
    }
}