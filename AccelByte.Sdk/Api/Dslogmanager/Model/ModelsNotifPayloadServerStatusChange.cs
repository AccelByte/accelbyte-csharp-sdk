using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dslogmanager.Model
{
    public class ModelsNotifPayloadServerStatusChange : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("match")]
        public ModelsMatchResult? Match { get; set; }
        
        [JsonPropertyName("server")]
        public ModelsServer? Server { get; set; }
        
    }
}