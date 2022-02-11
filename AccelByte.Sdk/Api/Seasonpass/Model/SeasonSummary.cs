using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class SeasonSummary : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("end")]
        public DateTime? End { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("passCodes")]
        public List<string>? PassCodes { get; set; }
        
        [JsonPropertyName("previous")]
        public SeasonSummary? Previous { get; set; }
        
        [JsonPropertyName("publishedAt")]
        public DateTime? PublishedAt { get; set; }
        
        [JsonPropertyName("start")]
        public DateTime? Start { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
    }
}