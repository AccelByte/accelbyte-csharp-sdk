using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class SeasonCloneRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("start")]
        public DateTime? Start { get; set; }
        
        [JsonPropertyName("end")]
        public DateTime? End { get; set; }
        
    }
}