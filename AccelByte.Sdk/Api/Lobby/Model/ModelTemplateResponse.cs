using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelTemplateResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("localizations")]
        public List<ModelLocalization>? Localizations { get; set; }
        
        [JsonPropertyName("templateSlug")]
        public string? TemplateSlug { get; set; }
        
    }
}