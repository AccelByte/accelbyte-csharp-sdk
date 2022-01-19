using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsConfigList : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("configs")]
        public List<ModelsConfig>? Configs { get; set; }
        
    }
}