using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class ExcessStrategy : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("method")]
        public string? Method { get; set; }
        
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }
        
        [JsonPropertyName("percentPerExp")]
        public int? PercentPerExp { get; set; }
        
    }
}