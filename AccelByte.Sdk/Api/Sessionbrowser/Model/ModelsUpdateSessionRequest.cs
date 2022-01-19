using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsUpdateSessionRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("game_current_player")]
        public int? GameCurrentPlayer { get; set; }
        
        [JsonPropertyName("game_max_player")]
        public int? GameMaxPlayer { get; set; }
        
    }
}