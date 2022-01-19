using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsMultipleEventID : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("EventIDs")]
        public List<ModelsEventID>? EventIDs { get; set; }
        
    }
}