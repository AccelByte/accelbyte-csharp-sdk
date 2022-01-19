using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsImportConfigResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("failedConfigs")]
        public List<string>? FailedConfigs { get; set; }
        
        [JsonPropertyName("ignoredConfigs")]
        public List<string>? IgnoredConfigs { get; set; }
        
        [JsonPropertyName("newConfigs")]
        public List<string>? NewConfigs { get; set; }
        
        [JsonPropertyName("replacedConfigs")]
        public List<string>? ReplacedConfigs { get; set; }
        
    }
}