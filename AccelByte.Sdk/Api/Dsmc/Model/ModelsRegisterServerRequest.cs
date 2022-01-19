using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsRegisterServerRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("custom_attribute")]
        public string? CustomAttribute { get; set; }
        
        [JsonPropertyName("pod_name")]
        public string? PodName { get; set; }
        
    }
}