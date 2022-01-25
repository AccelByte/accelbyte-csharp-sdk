using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsEvent : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("AgentType")]
        public long? AgentType { get; set; }
        
        [JsonPropertyName("ClientID")]
        public string? ClientID { get; set; }
        
        [JsonPropertyName("ComponentID")]
        public long? ComponentID { get; set; }
        
        [JsonPropertyName("EventID")]
        public long? EventID { get; set; }
        
        [JsonPropertyName("EventLevel")]
        public long? EventLevel { get; set; }
        
        [JsonPropertyName("EventType")]
        public long? EventType { get; set; }
        
        [JsonPropertyName("IPAddress")]
        public string? IPAddress { get; set; }
        
        [JsonPropertyName("Namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("Realm")]
        public string? Realm { get; set; }
        
        [JsonPropertyName("TargetNamespace")]
        public string? TargetNamespace { get; set; }
        
        [JsonPropertyName("TargetUserID")]
        public string? TargetUserID { get; set; }
        
        [JsonPropertyName("Time")]
        public string? Time { get; set; }
        
        [JsonPropertyName("UX")]
        public long? UX { get; set; }
        
        [JsonPropertyName("UserID")]
        public string? UserID { get; set; }
        
    }
}