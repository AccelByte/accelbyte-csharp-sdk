using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Achievement.Model
{
    public class ModelsPaginatedUserAchievementResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("countInfo")]
        public ModelsAdditionalInfo? CountInfo { get; set; }
        
        [JsonPropertyName("data")]
        public List<ModelsUserAchievementResponse>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelsPagination? Paging { get; set; }
        
    }
}