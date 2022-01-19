using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Achievement.Model
{
    public class ModelsAchievementOrderUpdateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("targetOrder")]
        public int? TargetOrder { get; set; }
        
    }
}