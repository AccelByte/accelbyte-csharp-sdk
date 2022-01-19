using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelUpdateTemplateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("templateContent")]
        public string? TemplateContent { get; set; }
        
    }
}