using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class ListUserSeasonInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
        [JsonPropertyName("seasonId")]
        public string? SeasonId { get; set; }
        
        [JsonPropertyName("enrolledAt")]
        public DateTime? EnrolledAt { get; set; }
        
        [JsonPropertyName("currentTierIndex")]
        public int? CurrentTierIndex { get; set; }
        
        [JsonPropertyName("lastTierIndex")]
        public int? LastTierIndex { get; set; }
        
        [JsonPropertyName("cleared")]
        public bool? Cleared { get; set; }
        
        [JsonPropertyName("season")]
        public SeasonSummary? Season { get; set; }
        
    }
}