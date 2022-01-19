using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class ValidationErrorEntity : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }
        
        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }
        
        [JsonPropertyName("errors")]
        public List<FieldValidationError>? Errors { get; set; }
        
    }
}