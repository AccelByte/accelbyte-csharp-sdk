using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class UserReportRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("category")]
        public string? Category { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("gameSessionId")]
        public string? GameSessionId { get; set; }
        
        [JsonPropertyName("subcategory")]
        public string? Subcategory { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}