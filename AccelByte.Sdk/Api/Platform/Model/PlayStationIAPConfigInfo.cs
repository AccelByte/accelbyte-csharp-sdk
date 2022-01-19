using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PlayStationIAPConfigInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("environment")]
        public string? Environment { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
    }
}