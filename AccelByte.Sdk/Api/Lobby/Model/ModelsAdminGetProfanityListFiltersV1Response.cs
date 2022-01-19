using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsAdminGetProfanityListFiltersV1Response : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("filters")]
        public List<ModelsProfanityFilter>? Filters { get; set; }
        
    }
}