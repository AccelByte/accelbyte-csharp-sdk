using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class XblReconcileResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("iapOrderStatus")]
        public string? IapOrderStatus { get; set; }
        
        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }
        
        [JsonPropertyName("sku")]
        public string? Sku { get; set; }
        
        [JsonPropertyName("transactionId")]
        public string? TransactionId { get; set; }
        
        [JsonPropertyName("xboxProductId")]
        public string? XboxProductId { get; set; }
        
    }
}