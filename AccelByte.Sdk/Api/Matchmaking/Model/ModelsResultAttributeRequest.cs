using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsResultAttributeRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("attribute")]
        public string? Attribute { get; set; }
        
        [JsonPropertyName("value")]
        public double? Value { get; set; }
        
    }
}