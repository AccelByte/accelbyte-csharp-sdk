using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Qosm.Model
{
    public class ModelsListServerResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("servers")]
        public List<ModelsServer>? Servers { get; set; }
        
    }
}