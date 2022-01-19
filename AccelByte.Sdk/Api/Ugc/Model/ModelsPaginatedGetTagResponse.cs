using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsPaginatedGetTagResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelsCreateTagResponse>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelsPagingCursor? Paging { get; set; }
        
    }
}