using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class EntitlementHistoryInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("action")]
        public string? Action { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("entitlementId")]
        public string? EntitlementId { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("operator")]
        public string? Operator { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
        [JsonPropertyName("useCount")]
        public int? UseCount { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}