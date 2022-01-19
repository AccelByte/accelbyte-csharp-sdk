using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class LogAppMessageDeclaration : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Attributes")]
        public List<string>? Attributes { get; set; }
        
        [JsonPropertyName("Code")]
        public string? Code { get; set; }
        
        [JsonPropertyName("CodeName")]
        public string? CodeName { get; set; }
        
        [JsonPropertyName("Section")]
        public string? Section { get; set; }
        
        [JsonPropertyName("Service")]
        public string? Service { get; set; }
        
        [JsonPropertyName("Text")]
        public string? Text { get; set; }
        
    }
}