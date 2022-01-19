using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsBlockedByPlayerData : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("blockedAt")]
        public DateTime? BlockedAt { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}