using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsCreatePodConfigRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("cpu_limit")]
        public int? CpuLimit { get; set; }
        
        [JsonPropertyName("mem_limit")]
        public int? MemLimit { get; set; }
        
        [JsonPropertyName("params")]
        public string? Params { get; set; }
        
    }
}