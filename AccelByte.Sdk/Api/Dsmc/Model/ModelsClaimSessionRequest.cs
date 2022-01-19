using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsClaimSessionRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("session_id")]
        public string? SessionId { get; set; }
        
    }
}