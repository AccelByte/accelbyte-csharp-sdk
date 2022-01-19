using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsPartyData : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("custom_attribute")]
        public Dictionary<object, object>? CustomAttribute { get; set; }
        
        [JsonPropertyName("invitees")]
        public List<string>? Invitees { get; set; }
        
        [JsonPropertyName("leader")]
        public string? Leader { get; set; }
        
        [JsonPropertyName("members")]
        public List<string>? Members { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("partyId")]
        public string? PartyId { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public long? UpdatedAt { get; set; }
        
    }
}