using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsAdminAddProfanityFiltersFilterRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("filter")]
        public string? Filter { get; set; }
        
        [JsonPropertyName("note")]
        public string? Note { get; set; }
        
    }
}