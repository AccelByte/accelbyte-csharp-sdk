using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsSession : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Server")]
        public ModelsServer? Server { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("provider")]
        public string? Provider { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
    }
}