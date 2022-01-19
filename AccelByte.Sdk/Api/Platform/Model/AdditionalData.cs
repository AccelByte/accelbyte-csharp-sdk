using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class AdditionalData : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("cardSummary")]
        public string? CardSummary { get; set; }
        
    }
}