using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsProfanityRule : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("Rule")]
        public string? Rule { get; set; }
        
    }
}