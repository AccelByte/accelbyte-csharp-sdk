using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class TestResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("msg")]
        public string? Msg { get; set; }
        
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        
    }
}