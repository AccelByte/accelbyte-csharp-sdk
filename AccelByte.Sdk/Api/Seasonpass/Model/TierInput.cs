using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class TierInput : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("requiredExp")]
        public int? RequiredExp { get; set; }
        
        [JsonPropertyName("rewards")]
        public Dictionary<string, object>? Rewards { get; set; }
        
    }
}