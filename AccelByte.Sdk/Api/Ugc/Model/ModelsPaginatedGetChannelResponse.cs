using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsPaginatedGetChannelResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelsChannelResponse>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelsPagingCursor? Paging { get; set; }
        
    }
}