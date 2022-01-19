using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsEventLevel : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("EventLevel")]
        public int? EventLevel { get; set; }
        
    }
}