using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsDebugProfanityFilterRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("text")]
        public string? Text { get; set; }
        
    }
}