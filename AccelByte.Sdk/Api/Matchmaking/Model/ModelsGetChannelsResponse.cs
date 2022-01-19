using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsGetChannelsResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelsChannel>? Data { get; set; }
        
        [JsonPropertyName("pagination")]
        public ModelsPagination? Pagination { get; set; }
        
    }
}