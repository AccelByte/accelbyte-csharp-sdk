using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CreditRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }
        
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }
        
        [JsonPropertyName("source")]
        public string? Source { get; set; }
        
    }
}