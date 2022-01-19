using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentScriptEvalTestRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("context")]
        public FulfillmentScriptContext? Context { get; set; }
        
        [JsonPropertyName("script")]
        public string? Script { get; set; }
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
    }
}