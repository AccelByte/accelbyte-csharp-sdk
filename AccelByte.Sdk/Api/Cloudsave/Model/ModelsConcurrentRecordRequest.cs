using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Cloudsave.Model
{
    public class ModelsConcurrentRecordRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }
        
        [JsonPropertyName("value")]
        public Dictionary<object, object>? Value { get; set; }
        
    }
}