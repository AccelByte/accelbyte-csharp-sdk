using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class Paging : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("previous")]
        public string? Previous { get; set; }
        
        [JsonPropertyName("next")]
        public string? Next { get; set; }
        
    }
}