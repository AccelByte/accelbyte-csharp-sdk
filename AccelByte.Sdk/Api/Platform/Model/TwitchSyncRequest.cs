using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class TwitchSyncRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("gameId")]
        public string? GameId { get; set; }
        
        [JsonPropertyName("language")]
        public string? Language { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
    }
}