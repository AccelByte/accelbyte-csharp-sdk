using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelUserUnfriendRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("friendId")]
        public string? FriendId { get; set; }
        
    }
}