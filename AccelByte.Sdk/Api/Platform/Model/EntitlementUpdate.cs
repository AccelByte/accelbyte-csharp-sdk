using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class EntitlementUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }
        
        [JsonPropertyName("nullFieldList")]
        public List<string>? NullFieldList { get; set; }
        
        [JsonPropertyName("startDate")]
        public DateTime? StartDate { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("useCount")]
        public int? UseCount { get; set; }
        
    }
}