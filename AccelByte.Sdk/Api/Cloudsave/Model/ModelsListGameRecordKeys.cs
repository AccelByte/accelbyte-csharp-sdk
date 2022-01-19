using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Cloudsave.Model
{
    public class ModelsListGameRecordKeys : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<string>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelsPagination? Paging { get; set; }
        
    }
}