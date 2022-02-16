// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class AppInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("announcement")]
        public string? Announcement { get; set; }
        
        [JsonPropertyName("carousel")]
        public List<Slide>? Carousel { get; set; }
        
        [JsonPropertyName("developer")]
        public string? Developer { get; set; }
        
        [JsonPropertyName("forumUrl")]
        public string? ForumUrl { get; set; }
        
        [JsonPropertyName("genres")]
        public List<string>? Genres { get; set; }
        
        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }
        
        [JsonPropertyName("language")]
        public string? Language { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("platformRequirements")]
        public Dictionary<string, object>? PlatformRequirements { get; set; }
        
        [JsonPropertyName("platforms")]
        public List<string>? Platforms { get; set; }
        
        [JsonPropertyName("players")]
        public List<string>? Players { get; set; }
        
        [JsonPropertyName("primaryGenre")]
        public string? PrimaryGenre { get; set; }
        
        [JsonPropertyName("publisher")]
        public string? Publisher { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
        [JsonPropertyName("releaseDate")]
        public DateTime? ReleaseDate { get; set; }
        
        [JsonPropertyName("slogan")]
        public string? Slogan { get; set; }
        
        [JsonPropertyName("websiteUrl")]
        public string? WebsiteUrl { get; set; }
        
    }
}