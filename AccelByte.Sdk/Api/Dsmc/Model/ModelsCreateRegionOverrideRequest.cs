using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsCreateRegionOverrideRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("buffer_count")]
        public int? BufferCount { get; set; }
        
        [JsonPropertyName("buffer_percent")]
        public int? BufferPercent { get; set; }
        
        [JsonPropertyName("max_count")]
        public int? MaxCount { get; set; }
        
        [JsonPropertyName("min_count")]
        public int? MinCount { get; set; }
        
        [JsonPropertyName("use_buffer_percent")]
        public bool? UseBufferPercent { get; set; }
        
    }
}