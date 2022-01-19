using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsAdminGetProfanityListsListResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }
        
        [JsonPropertyName("isMandatory")]
        public bool? IsMandatory { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
    }
}