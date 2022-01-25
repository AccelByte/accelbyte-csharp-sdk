using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelNotificationWithTemplateRequestV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("templateContext")]
        public Dictionary<string, string>? TemplateContext { get; set; }
        
        [JsonPropertyName("templateLanguage")]
        public string? TemplateLanguage { get; set; }
        
        [JsonPropertyName("templateSlug")]
        public string? TemplateSlug { get; set; }
        
        [JsonPropertyName("topicName")]
        public string? TopicName { get; set; }
        
    }
}