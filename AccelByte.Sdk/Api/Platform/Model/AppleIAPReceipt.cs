using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class AppleIAPReceipt : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("excludeOldTransactions")]
        public bool? ExcludeOldTransactions { get; set; }
        
        [JsonPropertyName("language")]
        public string? Language { get; set; }
        
        [JsonPropertyName("productId")]
        public string? ProductId { get; set; }
        
        [JsonPropertyName("receiptData")]
        public string? ReceiptData { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
        [JsonPropertyName("transactionId")]
        public string? TransactionId { get; set; }
        
    }
}