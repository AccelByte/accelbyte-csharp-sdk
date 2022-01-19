using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class Equ8Config : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("apiKey")]
        public string? ApiKey { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
    }
}