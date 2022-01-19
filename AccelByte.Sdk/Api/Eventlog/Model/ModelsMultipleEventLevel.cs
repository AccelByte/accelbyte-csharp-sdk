using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsMultipleEventLevel : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("EventLevel")]
        public List<ModelsEventLevel>? EventLevel { get; set; }
        
    }
}