using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsPlayerResultRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("results")]
        public List<ModelsResultAttributeRequest>? Results { get; set; }
        
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
        
    }
}