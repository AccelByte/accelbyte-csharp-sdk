using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class MockIAPReceipt : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("language")]
        public string? Language { get; set; }
        
        [JsonPropertyName("productId")]
        public string? ProductId { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
    }
}