using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsCreateDSMConfigRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("claim_timeout")]
        public int? ClaimTimeout { get; set; }
        
        [JsonPropertyName("creation_timeout")]
        public int? CreationTimeout { get; set; }
        
        [JsonPropertyName("default_version")]
        public string? DefaultVersion { get; set; }
        
        [JsonPropertyName("port")]
        public int? Port { get; set; }
        
        [JsonPropertyName("ports")]
        public Dictionary<string, long>? Ports { get; set; }
        
        [JsonPropertyName("protocol")]
        public string? Protocol { get; set; }
        
        [JsonPropertyName("providers")]
        public List<string>? Providers { get; set; }
        
        [JsonPropertyName("session_timeout")]
        public int? SessionTimeout { get; set; }
        
        [JsonPropertyName("unreachable_timeout")]
        public int? UnreachableTimeout { get; set; }
        
    }
}