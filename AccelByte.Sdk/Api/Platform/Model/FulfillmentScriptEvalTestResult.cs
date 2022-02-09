using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentScriptEvalTestResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("errorStackTrace")]
        public string? ErrorStackTrace { get; set; }
        
        [JsonPropertyName("result")]
        public Dictionary<string, object>? Result { get; set; }
        
    }
}