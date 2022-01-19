using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelBulkAddFriendsRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("friendIds")]
        public List<string>? FriendIds { get; set; }
        
    }
}