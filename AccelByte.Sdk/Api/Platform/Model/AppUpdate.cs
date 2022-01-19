using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class AppUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("carousel")]
        public List<Slide>? Carousel { get; set; }
        
        [JsonPropertyName("developer")]
        public string? Developer { get; set; }
        
        [JsonPropertyName("forumUrl")]
        public string? ForumUrl { get; set; }
        
        [JsonPropertyName("genres")]
        public List<string>? Genres { get; set; }
        
        [JsonPropertyName("localizations")]
        public Dictionary<string, AppLocalization>? Localizations { get; set; }
        
        [JsonPropertyName("platformRequirements")]
        public Dictionary<object, object>? PlatformRequirements { get; set; }
        
        [JsonPropertyName("platforms")]
        public List<string>? Platforms { get; set; }
        
        [JsonPropertyName("players")]
        public List<string>? Players { get; set; }
        
        [JsonPropertyName("primaryGenre")]
        public string? PrimaryGenre { get; set; }
        
        [JsonPropertyName("publisher")]
        public string? Publisher { get; set; }
        
        [JsonPropertyName("releaseDate")]
        public DateTime? ReleaseDate { get; set; }
        
        [JsonPropertyName("websiteUrl")]
        public string? WebsiteUrl { get; set; }
        
    }
}