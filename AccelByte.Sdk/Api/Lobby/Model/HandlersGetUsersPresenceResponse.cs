using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class HandlersGetUsersPresenceResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("busy")]
        public int? Busy { get; set; }
        
        [JsonPropertyName("data")]
        public List<HandlersUserPresence>? Data { get; set; }
        
        [JsonPropertyName("invisible")]
        public int? Invisible { get; set; }
        
        [JsonPropertyName("offline")]
        public int? Offline { get; set; }
        
        [JsonPropertyName("online")]
        public int? Online { get; set; }
        
    }
}