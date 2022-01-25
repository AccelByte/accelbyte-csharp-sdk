using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Achievement.Model
{
    public class ModelsAchievement : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("AchievementCode")]
        public string? AchievementCode { get; set; }
        
        [JsonPropertyName("CreatedAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("DefaultLanguage")]
        public string? DefaultLanguage { get; set; }
        
        [JsonPropertyName("Description")]
        public Dictionary<string, string>? Description { get; set; }
        
        [JsonPropertyName("GoalValue")]
        public double? GoalValue { get; set; }
        
        [JsonPropertyName("Hidden")]
        public bool? Hidden { get; set; }
        
        [JsonPropertyName("ID")]
        public string? ID { get; set; }
        
        [JsonPropertyName("Incremental")]
        public bool? Incremental { get; set; }
        
        [JsonPropertyName("ListOrder")]
        public int? ListOrder { get; set; }
        
        [JsonPropertyName("LockedIcons")]
        public List<ModelsIcon>? LockedIcons { get; set; }
        
        [JsonPropertyName("Name")]
        public Dictionary<string, string>? Name { get; set; }
        
        [JsonPropertyName("Namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("StatCode")]
        public string? StatCode { get; set; }
        
        [JsonPropertyName("Tags")]
        public List<string>? Tags { get; set; }
        
        [JsonPropertyName("UnlockedIcons")]
        public List<ModelsIcon>? UnlockedIcons { get; set; }
        
        [JsonPropertyName("UpdatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
    }
}