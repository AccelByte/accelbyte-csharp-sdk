using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsAdminDeleteProfanityFilterRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("filter")]
        public string? Filter { get; set; }
        
    }
}