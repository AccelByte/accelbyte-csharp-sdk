using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsCountActiveSessionResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("custom_game")]
        public long? CustomGame { get; set; }
        
        [JsonPropertyName("matchmaking_game")]
        public long? MatchmakingGame { get; set; }
        
        [JsonPropertyName("total")]
        public long? Total { get; set; }
        
    }
}