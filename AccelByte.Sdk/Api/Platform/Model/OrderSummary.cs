using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class OrderSummary : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currency")]
        public CurrencySummary? Currency { get; set; }
        
        [JsonPropertyName("ext")]
        public Dictionary<object, object>? Ext { get; set; }
        
        [JsonPropertyName("free")]
        public bool? Free { get; set; }
        
    }
}