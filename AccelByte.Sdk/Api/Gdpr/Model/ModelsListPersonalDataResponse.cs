using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Gdpr.Model
{
    public class ModelsListPersonalDataResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Data")]
        public List<ModelsPersonalData>? Data { get; set; }
        
        [JsonPropertyName("Paging")]
        public ModelsPagination? Paging { get; set; }
        
    }
}