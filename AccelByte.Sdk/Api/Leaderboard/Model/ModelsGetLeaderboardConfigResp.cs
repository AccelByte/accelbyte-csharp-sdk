using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsGetLeaderboardConfigResp : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("daily")]
        public ModelsDailyConfig? Daily { get; set; }
        
        [JsonPropertyName("deletedAt")]
        public DateTime? DeletedAt { get; set; }
        
        [JsonPropertyName("descending")]
        public bool? Descending { get; set; }
        
        [JsonPropertyName("iconURL")]
        public string? IconURL { get; set; }
        
        [JsonPropertyName("isArchived")]
        public bool? IsArchived { get; set; }
        
        [JsonPropertyName("isDeleted")]
        public bool? IsDeleted { get; set; }
        
        [JsonPropertyName("leaderboardCode")]
        public string? LeaderboardCode { get; set; }
        
        [JsonPropertyName("monthly")]
        public ModelsMonthlyConfig? Monthly { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("seasonPeriod")]
        public int? SeasonPeriod { get; set; }
        
        [JsonPropertyName("startTime")]
        public string? StartTime { get; set; }
        
        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }
        
        [JsonPropertyName("weekly")]
        public ModelsWeeklyConfig? Weekly { get; set; }
        
    }
}