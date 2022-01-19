using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelGetAllNotificationTemplateSlugResp : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelLocalization>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelPagination? Paging { get; set; }
        
    }
}