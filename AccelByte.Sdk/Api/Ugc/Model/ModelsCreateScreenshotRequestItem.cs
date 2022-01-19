using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsCreateScreenshotRequestItem : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("contentType")]
        public string? ContentType { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("fileExtension")]
        public string? FileExtension { get; set; }
        
    }
}