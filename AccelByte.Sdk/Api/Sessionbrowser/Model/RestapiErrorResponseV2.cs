using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class RestapiErrorResponseV2 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("attributes")]
        public Dictionary<string, string>? Attributes { get; set; }
        
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }
        
        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }
        
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
    }
}