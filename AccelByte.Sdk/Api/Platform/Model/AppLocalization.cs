using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class AppLocalization : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("announcement")]
        public string? Announcement { get; set; }
        
        [JsonPropertyName("slogan")]
        public string? Slogan { get; set; }
        
    }
}