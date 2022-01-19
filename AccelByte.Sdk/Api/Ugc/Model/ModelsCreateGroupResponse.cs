using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsCreateGroupResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("contents")]
        public List<string>? Contents { get; set; }
        
        [JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}