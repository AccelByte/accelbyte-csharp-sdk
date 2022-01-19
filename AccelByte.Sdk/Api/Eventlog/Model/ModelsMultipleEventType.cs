using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsMultipleEventType : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("EventType")]
        public List<ModelsEventType>? EventType { get; set; }
        
    }
}