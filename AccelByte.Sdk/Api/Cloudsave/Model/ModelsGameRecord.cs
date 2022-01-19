using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Cloudsave.Model
{
    public class ModelsGameRecord : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("key")]
        public string? Key { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        
        [JsonPropertyName("value")]
        public Dictionary<object, object>? Value { get; set; }
        
    }
}