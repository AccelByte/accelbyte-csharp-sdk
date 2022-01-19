using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsAdminUpdateProfanityList : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }
        
        [JsonPropertyName("isMandatory")]
        public bool? IsMandatory { get; set; }
        
        [JsonPropertyName("newName")]
        public string? NewName { get; set; }
        
    }
}