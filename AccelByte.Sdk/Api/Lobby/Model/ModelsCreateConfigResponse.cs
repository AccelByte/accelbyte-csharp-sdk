using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsCreateConfigResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("apiKey")]
        public string? ApiKey { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
    }
}