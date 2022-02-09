using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class NotificationProcessResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }
        
        [JsonPropertyName("customParam")]
        public Dictionary<string, object>? CustomParam { get; set; }
        
        [JsonPropertyName("severity")]
        public int? Severity { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
    }
}