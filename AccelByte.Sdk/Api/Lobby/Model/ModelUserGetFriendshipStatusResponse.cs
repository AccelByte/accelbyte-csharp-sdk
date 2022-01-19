using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelUserGetFriendshipStatusResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        public int? Code { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
    }
}