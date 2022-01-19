using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsSessionResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("all_players")]
        public List<string>? AllPlayers { get; set; }
        
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("game_session_setting")]
        public ModelsGameSessionSetting? GameSessionSetting { get; set; }
        
        [JsonPropertyName("game_version")]
        public string? GameVersion { get; set; }
        
        [JsonPropertyName("joinable")]
        public bool? Joinable { get; set; }
        
        [JsonPropertyName("match")]
        public ModelsMatchMaking? Match { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("players")]
        public List<string>? Players { get; set; }
        
        [JsonPropertyName("server")]
        public ModelsServer? Server { get; set; }
        
        [JsonPropertyName("session_id")]
        public string? SessionId { get; set; }
        
        [JsonPropertyName("session_type")]
        public string? SessionType { get; set; }
        
        [JsonPropertyName("spectators")]
        public List<string>? Spectators { get; set; }
        
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
        
        [JsonPropertyName("username")]
        public string? Username { get; set; }
        
    }
}