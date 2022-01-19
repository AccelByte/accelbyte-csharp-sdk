using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Achievement.Model
{
    public class ModelsIcon : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("slug")]
        public string? Slug { get; set; }
        
        [JsonPropertyName("url")]
        public string? Url { get; set; }
        
    }
}