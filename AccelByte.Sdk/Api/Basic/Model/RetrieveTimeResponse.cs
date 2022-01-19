using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class RetrieveTimeResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currentTime")]
        public string? CurrentTime { get; set; }
        
    }
}