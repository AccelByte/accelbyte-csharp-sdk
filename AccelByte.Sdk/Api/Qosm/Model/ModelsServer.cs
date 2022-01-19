using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Qosm.Model
{
    public class ModelsServer : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("alias")]
        public string? Alias { get; set; }
        
        [JsonPropertyName("ip")]
        public string? Ip { get; set; }
        
        [JsonPropertyName("last_update")]
        public DateTime? LastUpdate { get; set; }
        
        [JsonPropertyName("port")]
        public int? Port { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
    }
}