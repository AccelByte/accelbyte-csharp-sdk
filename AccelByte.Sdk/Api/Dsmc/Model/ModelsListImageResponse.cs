using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsListImageResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("images")]
        public List<ModelsImageRecord>? Images { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelsPagingCursor? Paging { get; set; }
        
    }
}