using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class OrderSyncResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("nextEvaluatedKey")]
        public string? NextEvaluatedKey { get; set; }
        
        [JsonPropertyName("orders")]
        public List<Order>? Orders { get; set; }
        
    }
}