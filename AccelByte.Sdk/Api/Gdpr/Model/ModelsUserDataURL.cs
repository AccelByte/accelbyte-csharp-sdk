using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Gdpr.Model
{
    public class ModelsUserDataURL : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("URL")]
        public string? URL { get; set; }
        
    }
}