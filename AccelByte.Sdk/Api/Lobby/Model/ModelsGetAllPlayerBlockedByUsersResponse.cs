using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsGetAllPlayerBlockedByUsersResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelsBlockedByPlayerData>? Data { get; set; }
        
    }
}