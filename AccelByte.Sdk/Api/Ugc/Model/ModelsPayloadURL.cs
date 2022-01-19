using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsPayloadURL : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("source")]
        public string? Source { get; set; }
        
        [JsonPropertyName("url")]
        public string? Url { get; set; }
        
    }
}