using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Gdpr.Model
{
    public class ModelsListDeletionDataResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Data")]
        public List<ModelsDeletionData>? Data { get; set; }
        
        [JsonPropertyName("Paging")]
        public ModelsPagination? Paging { get; set; }
        
    }
}