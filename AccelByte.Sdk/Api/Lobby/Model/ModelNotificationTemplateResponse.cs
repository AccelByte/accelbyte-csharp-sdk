using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelNotificationTemplateResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("templateLocalizations")]
        public List<ModelLocalization>? TemplateLocalizations { get; set; }
        
        [JsonPropertyName("templateSlug")]
        public string? TemplateSlug { get; set; }
        
    }
}