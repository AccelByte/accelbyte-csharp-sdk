using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Achievement.Model
{
    public class ModelsAdditionalInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("numberOfAchievements")]
        public long? NumberOfAchievements { get; set; }
        
        [JsonPropertyName("numberOfHiddenAchievements")]
        public long? NumberOfHiddenAchievements { get; set; }
        
        [JsonPropertyName("numberOfVisibleAchievements")]
        public long? NumberOfVisibleAchievements { get; set; }
        
    }
}