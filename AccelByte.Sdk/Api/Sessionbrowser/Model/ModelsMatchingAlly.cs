using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsMatchingAlly : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("matching_parties")]
        public List<ModelsMatchingParty>? MatchingParties { get; set; }
        
    }
}