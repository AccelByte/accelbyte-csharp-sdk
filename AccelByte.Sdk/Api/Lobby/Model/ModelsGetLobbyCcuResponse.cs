using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsGetLobbyCcuResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("countCurrentUsers")]
        public int? CountCurrentUsers { get; set; }
        
    }
}