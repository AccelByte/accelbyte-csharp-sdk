using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsCreateConfigRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("apiKey")]
        public string? ApiKey { get; set; }
        
    }
}