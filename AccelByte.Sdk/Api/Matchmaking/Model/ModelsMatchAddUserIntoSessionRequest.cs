using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsMatchAddUserIntoSessionRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("blocked_players")]
        public List<string>? BlockedPlayers { get; set; }
        
        [JsonPropertyName("party_id")]
        public string? PartyId { get; set; }
        
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
        
    }
}