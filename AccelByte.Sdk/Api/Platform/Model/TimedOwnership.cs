using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class TimedOwnership : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }
        
        [JsonPropertyName("owned")]
        public bool? Owned { get; set; }
        
    }
}