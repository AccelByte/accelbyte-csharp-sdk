using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class StadiaSyncRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }
        
        [JsonPropertyName("language")]
        public string? Language { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
        [JsonPropertyName("stadiaPlayerId")]
        public string? StadiaPlayerId { get; set; }
        
    }
}