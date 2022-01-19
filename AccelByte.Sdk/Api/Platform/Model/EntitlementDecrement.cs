using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class EntitlementDecrement : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("useCount")]
        public int? UseCount { get; set; }
        
    }
}