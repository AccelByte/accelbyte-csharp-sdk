using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Cloudsave.Model
{
    public class ModelsResponseError : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }
        
        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }
        
    }
}