using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsListBlockedPlayerRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("listBlockedUserId")]
        public List<string>? ListBlockedUserId { get; set; }
        
    }
}