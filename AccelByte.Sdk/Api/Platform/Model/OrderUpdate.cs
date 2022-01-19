using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class OrderUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("statusReason")]
        public string? StatusReason { get; set; }
        
    }
}