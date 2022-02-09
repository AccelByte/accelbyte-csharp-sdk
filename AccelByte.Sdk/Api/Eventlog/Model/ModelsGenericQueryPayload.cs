using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsGenericQueryPayload : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("clientId")]
        public string? ClientId { get; set; }
        
        [JsonPropertyName("eventName")]
        public string? EventName { get; set; }
        
        [JsonPropertyName("payloadQuery")]
        public Dictionary<string, object>? PayloadQuery { get; set; }
        
        [JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }
        
        [JsonPropertyName("traceId")]
        public string? TraceId { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
        [JsonPropertyName("version")]
        public int? Version { get; set; }
        
    }
}