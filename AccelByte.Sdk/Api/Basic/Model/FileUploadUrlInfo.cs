using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class FileUploadUrlInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("accessUrl")]
        public string? AccessUrl { get; set; }
        
        [JsonPropertyName("contentType")]
        public string? ContentType { get; set; }
        
        [JsonPropertyName("method")]
        public string? Method { get; set; }
        
        [JsonPropertyName("url")]
        public string? Url { get; set; }
        
    }
}