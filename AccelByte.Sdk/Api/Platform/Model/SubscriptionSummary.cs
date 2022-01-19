using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class SubscriptionSummary : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currentPeriodEnd")]
        public DateTime? CurrentPeriodEnd { get; set; }
        
        [JsonPropertyName("currentPeriodStart")]
        public DateTime? CurrentPeriodStart { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("sku")]
        public string? Sku { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("subscribedBy")]
        public string? SubscribedBy { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}