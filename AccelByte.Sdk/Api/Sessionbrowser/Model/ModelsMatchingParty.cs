using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsMatchingParty : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("party_attributes")]
        public Dictionary<object, object>? PartyAttributes { get; set; }
        
        [JsonPropertyName("party_id")]
        public string? PartyId { get; set; }
        
        [JsonPropertyName("party_members")]
        public List<ModelsPartyMember>? PartyMembers { get; set; }
        
    }
}