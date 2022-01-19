using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsCreateSessionRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("game_session_setting")]
        public ModelsGameSessionSetting? GameSessionSetting { get; set; }
        
        [JsonPropertyName("game_version")]
        public string? GameVersion { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("session_type")]
        public string? SessionType { get; set; }
        
        [JsonPropertyName("username")]
        public string? Username { get; set; }
        
    }
}