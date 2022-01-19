using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsCreateContentRequestS3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("contentType")]
        public string? ContentType { get; set; }
        
        [JsonPropertyName("fileExtension")]
        public string? FileExtension { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("preview")]
        public string? Preview { get; set; }
        
        [JsonPropertyName("subType")]
        public string? SubType { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
    }
}