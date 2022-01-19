using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsListPodConfigResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("paging")]
        public ModelsPagingCursor? Paging { get; set; }
        
        [JsonPropertyName("pod_configs")]
        public List<ModelsPodConfigRecord>? PodConfigs { get; set; }
        
    }
}