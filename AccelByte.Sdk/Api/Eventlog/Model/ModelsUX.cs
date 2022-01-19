using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsUX : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("UX")]
        public int? UX { get; set; }
        
    }
}