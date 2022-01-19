using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dslogmanager.Model
{
    public class ModelsRequestMatchingAlly : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("matching_parties")]
        public List<ModelsRequestMatchParty>? MatchingParties { get; set; }
        
    }
}