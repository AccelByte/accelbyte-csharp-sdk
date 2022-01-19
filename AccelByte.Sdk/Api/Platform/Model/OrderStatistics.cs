using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class OrderStatistics : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("statusCount")]
        public Dictionary<string, long>? StatusCount { get; set; }
        
        [JsonPropertyName("total")]
        public long? Total { get; set; }
        
    }
}