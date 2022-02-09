using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class BulkStatItemOperationResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("details")]
        public Dictionary<string, object>? Details { get; set; }
        
        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }
        
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        
    }
}