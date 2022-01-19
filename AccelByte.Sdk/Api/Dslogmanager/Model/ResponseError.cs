using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dslogmanager.Model
{
    public class ResponseError : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }
        
        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }
        
    }
}