using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class Slide : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("alt")]
        public string? Alt { get; set; }
        
        [JsonPropertyName("previewUrl")]
        public string? PreviewUrl { get; set; }
        
        [JsonPropertyName("thumbnailUrl")]
        public string? ThumbnailUrl { get; set; }
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
        [JsonPropertyName("url")]
        public string? Url { get; set; }
        
        [JsonPropertyName("videoSource")]
        public string? VideoSource { get; set; }
        
    }
}