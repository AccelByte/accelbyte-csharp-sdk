using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsScreenshotResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("contentType")]
        public string? ContentType { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("fileExtension")]
        public string? FileExtension { get; set; }
        
        [JsonPropertyName("screenshotId")]
        public string? ScreenshotId { get; set; }
        
        [JsonPropertyName("source")]
        public string? Source { get; set; }
        
        [JsonPropertyName("url")]
        public string? Url { get; set; }
        
    }
}