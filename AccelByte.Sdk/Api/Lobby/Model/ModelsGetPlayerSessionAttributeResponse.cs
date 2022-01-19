using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsGetPlayerSessionAttributeResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("key")]
        public string? Key { get; set; }
        
        [JsonPropertyName("value")]
        public string? Value { get; set; }
        
    }
}