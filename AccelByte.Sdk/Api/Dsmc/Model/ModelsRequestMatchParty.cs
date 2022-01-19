using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsRequestMatchParty : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("party_attributes")]
        public Dictionary<object, object>? PartyAttributes { get; set; }
        
        [JsonPropertyName("party_id")]
        public string? PartyId { get; set; }
        
        [JsonPropertyName("party_members")]
        public List<ModelsRequestMatchMember>? PartyMembers { get; set; }
        
    }
}