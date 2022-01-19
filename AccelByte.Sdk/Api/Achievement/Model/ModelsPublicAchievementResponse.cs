using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Achievement.Model
{
    public class ModelsPublicAchievementResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("achievementCode")]
        public string? AchievementCode { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("goalValue")]
        public double? GoalValue { get; set; }
        
        [JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }
        
        [JsonPropertyName("incremental")]
        public bool? Incremental { get; set; }
        
        [JsonPropertyName("listOrder")]
        public int? ListOrder { get; set; }
        
        [JsonPropertyName("lockedIcons")]
        public List<ModelsIcon>? LockedIcons { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
        [JsonPropertyName("unlockedIcons")]
        public List<ModelsIcon>? UnlockedIcons { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
    }
}