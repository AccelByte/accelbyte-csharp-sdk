using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsEventType : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("EventType")]
        public int? EventType { get; set; }
        
    }
}