using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ServiceGetSessionHistorySearchResponseItem : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("_id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("channel")]
        public string? Channel { get; set; }
        
        [JsonPropertyName("client_version")]
        public string? ClientVersion { get; set; }
        
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("event_description")]
        public string? EventDescription { get; set; }
        
        [JsonPropertyName("event_name")]
        public string? EventName { get; set; }
        
        [JsonPropertyName("game_mode")]
        public string? GameMode { get; set; }
        
        [JsonPropertyName("joinable")]
        public bool? Joinable { get; set; }
        
        [JsonPropertyName("match_id")]
        public string? MatchId { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("party_id")]
        public string? PartyId { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
        [JsonPropertyName("server_name")]
        public string? ServerName { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
    }
}