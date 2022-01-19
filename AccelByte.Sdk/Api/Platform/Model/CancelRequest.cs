using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CancelRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("immediate")]
        public bool? Immediate { get; set; }
        
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }
        
    }
}