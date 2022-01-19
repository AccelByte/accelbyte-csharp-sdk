using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsGetAllPlayerSessionAttributeResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("attributes")]
        public Dictionary<string, string>? Attributes { get; set; }
        
    }
}