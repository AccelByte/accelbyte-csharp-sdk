using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsCreateGroupRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("contents")]
        public List<string>? Contents { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
    }
}