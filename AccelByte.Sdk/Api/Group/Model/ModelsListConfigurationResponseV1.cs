using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsListConfigurationResponseV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelsGetGroupConfigurationResponseV1>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelsPagination? Paging { get; set; }
        
    }
}