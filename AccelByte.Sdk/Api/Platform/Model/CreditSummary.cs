using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CreditSummary : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
        [JsonPropertyName("walletId")]
        public string? WalletId { get; set; }
        
    }
}