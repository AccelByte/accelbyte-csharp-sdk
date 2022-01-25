using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsEventResponseV2 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelsEventV2>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelsPaging? Paging { get; set; }
        
    }
}