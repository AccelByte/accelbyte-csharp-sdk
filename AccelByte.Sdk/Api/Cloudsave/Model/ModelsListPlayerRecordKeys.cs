using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Cloudsave.Model
{
    public class ModelsListPlayerRecordKeys : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelsPlayerRecordKey>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelsPagination? Paging { get; set; }
        
    }
}