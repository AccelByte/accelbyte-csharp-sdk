using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsEventRegistry : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("EventID")]
        public int? EventID { get; set; }
        
        [JsonPropertyName("EventLevel")]
        public int? EventLevel { get; set; }
        
        [JsonPropertyName("EventType")]
        public int? EventType { get; set; }
        
        [JsonPropertyName("UX")]
        public int? UX { get; set; }
        
    }
}