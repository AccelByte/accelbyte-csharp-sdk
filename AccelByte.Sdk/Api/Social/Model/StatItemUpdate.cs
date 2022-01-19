using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class StatItemUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalData")]
        public Dictionary<object, object>? AdditionalData { get; set; }
        
        [JsonPropertyName("updateStrategy")]
        public string? UpdateStrategy { get; set; }
        
        [JsonPropertyName("value")]
        public double? Value { get; set; }
        
    }
}