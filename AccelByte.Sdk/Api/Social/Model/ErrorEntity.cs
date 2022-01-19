using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class ErrorEntity : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("devStackTrace")]
        public string? DevStackTrace { get; set; }
        
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }
        
        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }
        
        [JsonPropertyName("messageVariables")]
        public Dictionary<string, string>? MessageVariables { get; set; }
        
    }
}