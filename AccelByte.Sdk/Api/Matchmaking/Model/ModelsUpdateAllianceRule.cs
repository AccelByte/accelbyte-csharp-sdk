using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsUpdateAllianceRule : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("maxNumber")]
        public int? MaxNumber { get; set; }
        
        [JsonPropertyName("minNumber")]
        public int? MinNumber { get; set; }
        
        [JsonPropertyName("playerMaxNumber")]
        public int? PlayerMaxNumber { get; set; }
        
        [JsonPropertyName("playerMinNumber")]
        public int? PlayerMinNumber { get; set; }
        
    }
}