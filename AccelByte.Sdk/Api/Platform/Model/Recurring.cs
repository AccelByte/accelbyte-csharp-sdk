using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class Recurring : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("cycle")]
        public string? Cycle { get; set; }
        
        [JsonPropertyName("fixedFreeDays")]
        public int? FixedFreeDays { get; set; }
        
        [JsonPropertyName("fixedTrialCycles")]
        public int? FixedTrialCycles { get; set; }
        
        [JsonPropertyName("graceDays")]
        public int? GraceDays { get; set; }
        
    }
}