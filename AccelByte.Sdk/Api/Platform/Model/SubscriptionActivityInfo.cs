using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class SubscriptionActivityInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("action")]
        public string? Action { get; set; }
        
        [JsonPropertyName("chargedCycles")]
        public int? ChargedCycles { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("currentCycle")]
        public int? CurrentCycle { get; set; }
        
        [JsonPropertyName("grantDays")]
        public int? GrantDays { get; set; }
        
        [JsonPropertyName("inFixedCycleTrial")]
        public bool? InFixedCycleTrial { get; set; }
        
        [JsonPropertyName("inFixedFreeDays")]
        public bool? InFixedFreeDays { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("operator")]
        public string? Operator { get; set; }
        
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }
        
        [JsonPropertyName("subscribedBy")]
        public string? SubscribedBy { get; set; }
        
        [JsonPropertyName("subscriptionId")]
        public string? SubscriptionId { get; set; }
        
        [JsonPropertyName("trialedCycles")]
        public int? TrialedCycles { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}