using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelPagination : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("first")]
        public string? First { get; set; }
        
        [JsonPropertyName("last")]
        public string? Last { get; set; }
        
        [JsonPropertyName("next")]
        public string? Next { get; set; }
        
        [JsonPropertyName("previous")]
        public string? Previous { get; set; }
        
    }
}