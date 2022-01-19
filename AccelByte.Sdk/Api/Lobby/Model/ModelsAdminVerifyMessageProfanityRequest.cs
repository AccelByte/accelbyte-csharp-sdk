using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsAdminVerifyMessageProfanityRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        
        [JsonPropertyName("profanityLevel")]
        public string? ProfanityLevel { get; set; }
        
    }
}