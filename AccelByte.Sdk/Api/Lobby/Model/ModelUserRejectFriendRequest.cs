using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelUserRejectFriendRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("friendId")]
        public string? FriendId { get; set; }
        
    }
}