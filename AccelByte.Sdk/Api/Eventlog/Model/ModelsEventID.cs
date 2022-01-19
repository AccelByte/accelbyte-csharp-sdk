using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsEventID : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("EventID")]
        public int? EventID { get; set; }
        
    }
}