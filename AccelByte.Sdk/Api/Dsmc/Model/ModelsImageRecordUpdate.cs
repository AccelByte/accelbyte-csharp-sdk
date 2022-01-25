using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsImageRecordUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("artifactPath")]
        public string? ArtifactPath { get; set; }
        
        [JsonPropertyName("image")]
        public string? Image { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("persistent")]
        public bool? Persistent { get; set; }
        
        [JsonPropertyName("version")]
        public string? Version { get; set; }
        
    }
}