using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PlaystationIAPConfigRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("environment")]
        public string? Environment { get; set; }
        
    }
}