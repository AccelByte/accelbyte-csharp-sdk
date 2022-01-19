using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class WalletTransactionInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }
        
        [JsonPropertyName("balanceSource")]
        public string? BalanceSource { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("operator")]
        public string? Operator { get; set; }
        
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
        [JsonPropertyName("walletAction")]
        public string? WalletAction { get; set; }
        
        [JsonPropertyName("walletId")]
        public string? WalletId { get; set; }
        
    }
}