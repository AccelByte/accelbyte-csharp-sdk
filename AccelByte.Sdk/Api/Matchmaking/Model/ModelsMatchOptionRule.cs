using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsMatchOptionRule : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("options")]
        public List<ModelsMatchOption>? Options { get; set; }
        
    }
}