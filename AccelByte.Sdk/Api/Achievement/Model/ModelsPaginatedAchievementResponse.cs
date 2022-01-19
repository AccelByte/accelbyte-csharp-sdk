using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Achievement.Model
{
    public class ModelsPaginatedAchievementResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelsAchievementResponse>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelsPagination? Paging { get; set; }
        
    }
}