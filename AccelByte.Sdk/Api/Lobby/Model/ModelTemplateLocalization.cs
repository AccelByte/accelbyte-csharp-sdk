using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelTemplateLocalization : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("lastDraftAt")]
        public string? LastDraftAt { get; set; }
        
        [JsonPropertyName("lastPublishedAt")]
        public string? LastPublishedAt { get; set; }
        
        [JsonPropertyName("templateContent")]
        public ModelTemplateContent? TemplateContent { get; set; }
        
        [JsonPropertyName("templateLanguage")]
        public string? TemplateLanguage { get; set; }
        
        [JsonPropertyName("templateSlug")]
        public string? TemplateSlug { get; set; }
        
    }
}