using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillCodeRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }
        
        [JsonPropertyName("language")]
        public string? Language { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
    }
}