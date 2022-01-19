using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class Localization : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
    }
}