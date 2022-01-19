using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class EpicGamesReconcileResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("epicGamesItemId")]
        public string? EpicGamesItemId { get; set; }
        
        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }
        
        [JsonPropertyName("sku")]
        public string? Sku { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("transactionId")]
        public string? TransactionId { get; set; }
        
    }
}