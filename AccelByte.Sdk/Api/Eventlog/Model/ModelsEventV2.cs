using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsEventV2 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("clientId")]
        public string? ClientId { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("payload")]
        public Dictionary<object, object>? Payload { get; set; }
        
        [JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }
        
        [JsonPropertyName("timestamp")]
        public DateTime? Timestamp { get; set; }
        
        [JsonPropertyName("traceId")]
        public string? TraceId { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
        [JsonPropertyName("version")]
        public int? Version { get; set; }
        
    }
}