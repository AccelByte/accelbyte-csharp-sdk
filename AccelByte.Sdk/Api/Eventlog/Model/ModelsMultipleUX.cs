using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsMultipleUX : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("UX")]
        public List<ModelsUX>? UX { get; set; }
        
    }
}