using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelGetAllNotificationTopicsResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelNotificationTopicResponseV1>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelPagination? Paging { get; set; }
        
    }
}