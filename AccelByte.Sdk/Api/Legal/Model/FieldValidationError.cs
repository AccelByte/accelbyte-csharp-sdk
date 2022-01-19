using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class FieldValidationError : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("errorCode")]
        public string? ErrorCode { get; set; }
        
        [JsonPropertyName("errorField")]
        public string? ErrorField { get; set; }
        
        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }
        
        [JsonPropertyName("errorValue")]
        public string? ErrorValue { get; set; }
        
        [JsonPropertyName("messageVariables")]
        public Dictionary<string, string>? MessageVariables { get; set; }
        
    }
}