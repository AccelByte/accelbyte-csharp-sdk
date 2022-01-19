using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsListServerResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("paging")]
        public ModelsPagingCursor? Paging { get; set; }
        
        [JsonPropertyName("servers")]
        public List<ModelsServer>? Servers { get; set; }
        
    }
}