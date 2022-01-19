using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class RestapiErrorResponseBody : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ErrorCode")]
        public int? ErrorCode { get; set; }
        
        [JsonPropertyName("ErrorMessage")]
        public string? ErrorMessage { get; set; }
        
    }
}