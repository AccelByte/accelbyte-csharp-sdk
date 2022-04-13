// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

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
        [JsonStringEnum]
        public List<AppInfoGenres>? Genres { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("platformRequirements")]
        public Dictionary<string, object>? PlatformRequirements { get; set; }

        [JsonPropertyName("platforms")]
        [JsonStringEnum]
        public List<AppInfoPlatforms>? Platforms { get; set; }

        [JsonPropertyName("players")]
        [JsonStringEnum]
        public List<AppInfoPlayers>? Players { get; set; }

        [JsonPropertyName("primaryGenre")]
        [JsonStringEnum]
        public AppInfoPrimaryGenre? PrimaryGenre { get; set; }

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

    public class AppInfoGenres : StringEnum<AppInfoGenres>
    {
        public static readonly AppInfoGenres Action
            = new AppInfoGenres("Action");

        public static readonly AppInfoGenres Adventure
            = new AppInfoGenres("Adventure");

        public static readonly AppInfoGenres Casual
            = new AppInfoGenres("Casual");

        public static readonly AppInfoGenres FreeToPlay
            = new AppInfoGenres("FreeToPlay");

        public static readonly AppInfoGenres Indie
            = new AppInfoGenres("Indie");

        public static readonly AppInfoGenres MassivelyMultiplayer
            = new AppInfoGenres("MassivelyMultiplayer");

        public static readonly AppInfoGenres Racing
            = new AppInfoGenres("Racing");

        public static readonly AppInfoGenres RPG
            = new AppInfoGenres("RPG");

        public static readonly AppInfoGenres Simulation
            = new AppInfoGenres("Simulation");

        public static readonly AppInfoGenres Sports
            = new AppInfoGenres("Sports");

        public static readonly AppInfoGenres Strategy
            = new AppInfoGenres("Strategy");


        public static implicit operator AppInfoGenres(string value)
        {
            return Create(value);
        }

        public AppInfoGenres(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class AppInfoPlatforms : StringEnum<AppInfoPlatforms>
    {
        public static readonly AppInfoPlatforms Windows
            = new AppInfoPlatforms("Windows");

        public static readonly AppInfoPlatforms MacOS
            = new AppInfoPlatforms("MacOS");

        public static readonly AppInfoPlatforms Linux
            = new AppInfoPlatforms("Linux");

        public static readonly AppInfoPlatforms IOS
            = new AppInfoPlatforms("IOS");

        public static readonly AppInfoPlatforms Android
            = new AppInfoPlatforms("Android");


        public static implicit operator AppInfoPlatforms(string value)
        {
            return Create(value);
        }

        public AppInfoPlatforms(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class AppInfoPlayers : StringEnum<AppInfoPlayers>
    {
        public static readonly AppInfoPlayers Single
            = new AppInfoPlayers("Single");

        public static readonly AppInfoPlayers Multi
            = new AppInfoPlayers("Multi");

        public static readonly AppInfoPlayers CrossPlatformMulti
            = new AppInfoPlayers("CrossPlatformMulti");

        public static readonly AppInfoPlayers MMO
            = new AppInfoPlayers("MMO");

        public static readonly AppInfoPlayers Coop
            = new AppInfoPlayers("Coop");

        public static readonly AppInfoPlayers LocalCoop
            = new AppInfoPlayers("LocalCoop");


        public static implicit operator AppInfoPlayers(string value)
        {
            return Create(value);
        }

        public AppInfoPlayers(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class AppInfoPrimaryGenre : StringEnum<AppInfoPrimaryGenre>
    {
        public static readonly AppInfoPrimaryGenre Action
            = new AppInfoPrimaryGenre("Action");

        public static readonly AppInfoPrimaryGenre Adventure
            = new AppInfoPrimaryGenre("Adventure");

        public static readonly AppInfoPrimaryGenre Casual
            = new AppInfoPrimaryGenre("Casual");

        public static readonly AppInfoPrimaryGenre FreeToPlay
            = new AppInfoPrimaryGenre("FreeToPlay");

        public static readonly AppInfoPrimaryGenre Indie
            = new AppInfoPrimaryGenre("Indie");

        public static readonly AppInfoPrimaryGenre MassivelyMultiplayer
            = new AppInfoPrimaryGenre("MassivelyMultiplayer");

        public static readonly AppInfoPrimaryGenre Racing
            = new AppInfoPrimaryGenre("Racing");

        public static readonly AppInfoPrimaryGenre RPG
            = new AppInfoPrimaryGenre("RPG");

        public static readonly AppInfoPrimaryGenre Simulation
            = new AppInfoPrimaryGenre("Simulation");

        public static readonly AppInfoPrimaryGenre Sports
            = new AppInfoPrimaryGenre("Sports");

        public static readonly AppInfoPrimaryGenre Strategy
            = new AppInfoPrimaryGenre("Strategy");


        public static implicit operator AppInfoPrimaryGenre(string value)
        {
            return Create(value);
        }

        public AppInfoPrimaryGenre(string enumValue)
            : base(enumValue)
        {

        }
    }    
}