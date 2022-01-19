using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsPagingCursor : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("next")]
        public string? Next { get; set; }
        
        [JsonPropertyName("previous")]
        public string? Previous { get; set; }
        
    }
}