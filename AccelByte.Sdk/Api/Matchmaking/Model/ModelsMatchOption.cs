using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsMatchOption : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
    }
}