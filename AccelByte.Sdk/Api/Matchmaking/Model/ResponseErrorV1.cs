using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ResponseErrorV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }
        
        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }
        
    }
}