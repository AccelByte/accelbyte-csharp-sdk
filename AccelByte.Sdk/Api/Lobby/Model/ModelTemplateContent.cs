using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelTemplateContent : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("draft")]
        public string? Draft { get; set; }
        
        [JsonPropertyName("published")]
        public string? Published { get; set; }
        
    }
}