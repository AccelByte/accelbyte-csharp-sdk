using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class IAPOrderInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("credits")]
        public List<CreditSummary>? Credits { get; set; }
        
        [JsonPropertyName("entitlements")]
        public List<EntitlementSummary>? Entitlements { get; set; }
        
        [JsonPropertyName("fulfilledTime")]
        public DateTime? FulfilledTime { get; set; }
        
        [JsonPropertyName("iapOrderNo")]
        public string? IapOrderNo { get; set; }
        
        [JsonPropertyName("language")]
        public string? Language { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("productId")]
        public string? ProductId { get; set; }
        
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }
        
        [JsonPropertyName("receiptData")]
        public string? ReceiptData { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
        [JsonPropertyName("retryCount")]
        public int? RetryCount { get; set; }
        
        [JsonPropertyName("sandbox")]
        public bool? Sandbox { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("statusReason")]
        public string? StatusReason { get; set; }
        
        [JsonPropertyName("transactionId")]
        public string? TransactionId { get; set; }
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}