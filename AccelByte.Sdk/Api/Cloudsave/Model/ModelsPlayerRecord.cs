using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Cloudsave.Model
{
    public class ModelsPlayerRecord : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("is_public")]
        public bool? IsPublic { get; set; }
        
        [JsonPropertyName("key")]
        public string? Key { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
        
        [JsonPropertyName("value")]
        public Dictionary<object, object>? Value { get; set; }
        
    }
}