using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Cloudsave.Model
{
    public class ModelsBulkGetPlayerRecordResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelsPlayerRecord>? Data { get; set; }
        
    }
}