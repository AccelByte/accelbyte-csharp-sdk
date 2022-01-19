using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsGetImageLimitResponseData : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("image_count")]
        public int? ImageCount { get; set; }
        
        [JsonPropertyName("image_limit")]
        public int? ImageLimit { get; set; }
        
    }
}