using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class Image : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("as")]
        public string? As { get; set; }
        
        [JsonPropertyName("caption")]
        public string? Caption { get; set; }
        
        [JsonPropertyName("height")]
        public int? Height { get; set; }
        
        [JsonPropertyName("width")]
        public int? Width { get; set; }
        
        [JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }
        
        [JsonPropertyName("smallImageUrl")]
        public string? SmallImageUrl { get; set; }
        
    }
}