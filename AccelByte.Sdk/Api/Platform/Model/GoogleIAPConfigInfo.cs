using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class GoogleIAPConfigInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("applicationName")]
        public string? ApplicationName { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("p12FileName")]
        public string? P12FileName { get; set; }
        
        [JsonPropertyName("serviceAccountId")]
        public string? ServiceAccountId { get; set; }
        
    }
}