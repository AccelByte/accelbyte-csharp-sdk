// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

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
        [JsonStringEnum]
        public List<AppUpdateGenres>? Genres { get; set; }

        [JsonPropertyName("localizations")]
        public Dictionary<string, AppLocalization>? Localizations { get; set; }

        [JsonPropertyName("platformRequirements")]
        public Dictionary<string, object>? PlatformRequirements { get; set; }

        [JsonPropertyName("platforms")]
        [JsonStringEnum]
        public List<AppUpdatePlatforms>? Platforms { get; set; }

        [JsonPropertyName("players")]
        [JsonStringEnum]
        public List<AppUpdatePlayers>? Players { get; set; }

        [JsonPropertyName("primaryGenre")]
        [JsonStringEnum]
        public AppUpdatePrimaryGenre? PrimaryGenre { get; set; }

        [JsonPropertyName("publisher")]
        public string? Publisher { get; set; }

        [JsonPropertyName("releaseDate")]
        public DateTime? ReleaseDate { get; set; }

        [JsonPropertyName("websiteUrl")]
        public string? WebsiteUrl { get; set; }

    }

    public class AppUpdateGenres : StringEnum<AppUpdateGenres>
    {
        public static readonly AppUpdateGenres Action
            = new AppUpdateGenres("Action");

        public static readonly AppUpdateGenres Adventure
            = new AppUpdateGenres("Adventure");

        public static readonly AppUpdateGenres Casual
            = new AppUpdateGenres("Casual");

        public static readonly AppUpdateGenres FreeToPlay
            = new AppUpdateGenres("FreeToPlay");

        public static readonly AppUpdateGenres Indie
            = new AppUpdateGenres("Indie");

        public static readonly AppUpdateGenres MassivelyMultiplayer
            = new AppUpdateGenres("MassivelyMultiplayer");

        public static readonly AppUpdateGenres Racing
            = new AppUpdateGenres("Racing");

        public static readonly AppUpdateGenres RPG
            = new AppUpdateGenres("RPG");

        public static readonly AppUpdateGenres Simulation
            = new AppUpdateGenres("Simulation");

        public static readonly AppUpdateGenres Sports
            = new AppUpdateGenres("Sports");

        public static readonly AppUpdateGenres Strategy
            = new AppUpdateGenres("Strategy");


        public static implicit operator AppUpdateGenres(string value)
        {
            return Create(value);
        }

        public AppUpdateGenres(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class AppUpdatePlatforms : StringEnum<AppUpdatePlatforms>
    {
        public static readonly AppUpdatePlatforms Windows
            = new AppUpdatePlatforms("Windows");

        public static readonly AppUpdatePlatforms MacOS
            = new AppUpdatePlatforms("MacOS");

        public static readonly AppUpdatePlatforms Linux
            = new AppUpdatePlatforms("Linux");

        public static readonly AppUpdatePlatforms IOS
            = new AppUpdatePlatforms("IOS");

        public static readonly AppUpdatePlatforms Android
            = new AppUpdatePlatforms("Android");


        public static implicit operator AppUpdatePlatforms(string value)
        {
            return Create(value);
        }

        public AppUpdatePlatforms(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class AppUpdatePlayers : StringEnum<AppUpdatePlayers>
    {
        public static readonly AppUpdatePlayers Single
            = new AppUpdatePlayers("Single");

        public static readonly AppUpdatePlayers Multi
            = new AppUpdatePlayers("Multi");

        public static readonly AppUpdatePlayers CrossPlatformMulti
            = new AppUpdatePlayers("CrossPlatformMulti");

        public static readonly AppUpdatePlayers MMO
            = new AppUpdatePlayers("MMO");

        public static readonly AppUpdatePlayers Coop
            = new AppUpdatePlayers("Coop");

        public static readonly AppUpdatePlayers LocalCoop
            = new AppUpdatePlayers("LocalCoop");


        public static implicit operator AppUpdatePlayers(string value)
        {
            return Create(value);
        }

        public AppUpdatePlayers(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class AppUpdatePrimaryGenre : StringEnum<AppUpdatePrimaryGenre>
    {
        public static readonly AppUpdatePrimaryGenre Action
            = new AppUpdatePrimaryGenre("Action");

        public static readonly AppUpdatePrimaryGenre Adventure
            = new AppUpdatePrimaryGenre("Adventure");

        public static readonly AppUpdatePrimaryGenre Casual
            = new AppUpdatePrimaryGenre("Casual");

        public static readonly AppUpdatePrimaryGenre FreeToPlay
            = new AppUpdatePrimaryGenre("FreeToPlay");

        public static readonly AppUpdatePrimaryGenre Indie
            = new AppUpdatePrimaryGenre("Indie");

        public static readonly AppUpdatePrimaryGenre MassivelyMultiplayer
            = new AppUpdatePrimaryGenre("MassivelyMultiplayer");

        public static readonly AppUpdatePrimaryGenre Racing
            = new AppUpdatePrimaryGenre("Racing");

        public static readonly AppUpdatePrimaryGenre RPG
            = new AppUpdatePrimaryGenre("RPG");

        public static readonly AppUpdatePrimaryGenre Simulation
            = new AppUpdatePrimaryGenre("Simulation");

        public static readonly AppUpdatePrimaryGenre Sports
            = new AppUpdatePrimaryGenre("Sports");

        public static readonly AppUpdatePrimaryGenre Strategy
            = new AppUpdatePrimaryGenre("Strategy");


        public static implicit operator AppUpdatePrimaryGenre(string value)
        {
            return Create(value);
        }

        public AppUpdatePrimaryGenre(string enumValue)
            : base(enumValue)
        {

        }
    }    
}