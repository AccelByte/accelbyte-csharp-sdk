using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PlayStationReconcileResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }
        
        [JsonPropertyName("psnItemId")]
        public string? PsnItemId { get; set; }
        
        [JsonPropertyName("sku")]
        public string? Sku { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("transactionId")]
        public string? TransactionId { get; set; }
        
    }
}