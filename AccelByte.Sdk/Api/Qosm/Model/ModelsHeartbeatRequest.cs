using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Qosm.Model
{
    public class ModelsHeartbeatRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ip")]
        public string? Ip { get; set; }
        
        [JsonPropertyName("port")]
        public int? Port { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
    }
}