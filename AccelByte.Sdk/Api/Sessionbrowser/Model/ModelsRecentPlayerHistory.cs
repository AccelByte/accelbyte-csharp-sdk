using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsRecentPlayerHistory : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("other_display_name")]
        public string? OtherDisplayName { get; set; }
        
        [JsonPropertyName("other_id")]
        public string? OtherId { get; set; }
        
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
        
    }
}