using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsProfanityFilter : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("filter")]
        public string? Filter { get; set; }
        
        [JsonPropertyName("listName")]
        public string? ListName { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("note")]
        public string? Note { get; set; }
        
    }
}