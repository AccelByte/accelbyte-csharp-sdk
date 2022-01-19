using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class RecurringChargeResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }
        
        [JsonPropertyName("detail")]
        public string? Detail { get; set; }
        
        [JsonPropertyName("triggered")]
        public bool? Triggered { get; set; }
        
    }
}