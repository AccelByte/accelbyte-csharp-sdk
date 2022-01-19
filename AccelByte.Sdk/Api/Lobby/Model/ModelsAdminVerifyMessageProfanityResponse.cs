using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsAdminVerifyMessageProfanityResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("filteredMessage")]
        public string? FilteredMessage { get; set; }
        
        [JsonPropertyName("hasProfanity")]
        public bool? HasProfanity { get; set; }
        
    }
}