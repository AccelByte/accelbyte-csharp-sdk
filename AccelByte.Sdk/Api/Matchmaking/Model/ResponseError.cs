using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ResponseError : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ErrorCode")]
        public int? ErrorCode { get; set; }
        
        [JsonPropertyName("ErrorMessage")]
        public string? ErrorMessage { get; set; }
        
    }
}