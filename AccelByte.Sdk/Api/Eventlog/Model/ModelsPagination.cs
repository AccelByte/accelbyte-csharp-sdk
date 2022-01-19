using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsPagination : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Next")]
        public string? Next { get; set; }
        
        [JsonPropertyName("Previous")]
        public string? Previous { get; set; }
        
    }
}