using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsPaginatedContentDownloadResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelsContentDownloadResponse>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelsPagingCursor? Paging { get; set; }
        
    }
}