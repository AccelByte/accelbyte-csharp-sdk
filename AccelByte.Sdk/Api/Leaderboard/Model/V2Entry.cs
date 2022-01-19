using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class V2Entry : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalData")]
        public Dictionary<object, object>? AdditionalData { get; set; }
        
        [JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }
        
        [JsonPropertyName("point")]
        public double? Point { get; set; }
        
    }
}