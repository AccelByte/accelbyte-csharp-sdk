using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsShutdownServerRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("kill_me")]
        public bool? KillMe { get; set; }
        
        [JsonPropertyName("pod_name")]
        public string? PodName { get; set; }
        
    }
}