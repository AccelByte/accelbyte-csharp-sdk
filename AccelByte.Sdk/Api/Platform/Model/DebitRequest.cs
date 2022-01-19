using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class DebitRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }
        
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }
        
    }
}