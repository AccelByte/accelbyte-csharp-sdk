using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ItemAcquireResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("maxCount")]
        public int? MaxCount { get; set; }
        
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        
    }
}