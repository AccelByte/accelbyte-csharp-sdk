using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsBlockedPlayerData : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("blockedAt")]
        public DateTime? BlockedAt { get; set; }
        
        [JsonPropertyName("blockedUserId")]
        public string? BlockedUserId { get; set; }
        
    }
}