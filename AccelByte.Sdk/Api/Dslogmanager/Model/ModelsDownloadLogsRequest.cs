using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dslogmanager.Model
{
    public class ModelsDownloadLogsRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("alloc_id")]
        public string? AllocId { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("pod_name")]
        public string? PodName { get; set; }
        
    }
}