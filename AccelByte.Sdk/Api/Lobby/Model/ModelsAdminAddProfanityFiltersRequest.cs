using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsAdminAddProfanityFiltersRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("filters")]
        public List<ModelsAdminAddProfanityFiltersFilterRequest>? Filters { get; set; }
        
    }
}