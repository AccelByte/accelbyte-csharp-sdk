// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FullAppInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("carousel")]
        public List<Slide>? Carousel { get; set; }

        [JsonPropertyName("developer")]
        public string? Developer { get; set; }

        [JsonPropertyName("forumUrl")]
        public string? ForumUrl { get; set; }

        [JsonPropertyName("genres")]
        [JsonStringEnum]
        public List<FullAppInfoGenres>? Genres { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("localizations")]
        public Dictionary<string, AppLocalization>? Localizations { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("platformRequirements")]
        public Dictionary<string, object>? PlatformRequirements { get; set; }

        [JsonPropertyName("platforms")]
        [JsonStringEnum]
        public List<FullAppInfoPlatforms>? Platforms { get; set; }

        [JsonPropertyName("players")]
        [JsonStringEnum]
        public List<FullAppInfoPlayers>? Players { get; set; }

        [JsonPropertyName("primaryGenre")]
        [JsonStringEnum]
        public FullAppInfoPrimaryGenre? PrimaryGenre { get; set; }

        [JsonPropertyName("publisher")]
        public string? Publisher { get; set; }

        [JsonPropertyName("releaseDate")]
        public DateTime? ReleaseDate { get; set; }

        [JsonPropertyName("websiteUrl")]
        public string? WebsiteUrl { get; set; }

    }

    public class FullAppInfoGenres : StringEnum<FullAppInfoGenres>
    {
        public static readonly FullAppInfoGenres Action
            = new FullAppInfoGenres("Action");

        public static readonly FullAppInfoGenres Adventure
            = new FullAppInfoGenres("Adventure");

        public static readonly FullAppInfoGenres Casual
            = new FullAppInfoGenres("Casual");

        public static readonly FullAppInfoGenres FreeToPlay
            = new FullAppInfoGenres("FreeToPlay");

        public static readonly FullAppInfoGenres Indie
            = new FullAppInfoGenres("Indie");

        public static readonly FullAppInfoGenres MassivelyMultiplayer
            = new FullAppInfoGenres("MassivelyMultiplayer");

        public static readonly FullAppInfoGenres Racing
            = new FullAppInfoGenres("Racing");

        public static readonly FullAppInfoGenres RPG
            = new FullAppInfoGenres("RPG");

        public static readonly FullAppInfoGenres Simulation
            = new FullAppInfoGenres("Simulation");

        public static readonly FullAppInfoGenres Sports
            = new FullAppInfoGenres("Sports");

        public static readonly FullAppInfoGenres Strategy
            = new FullAppInfoGenres("Strategy");


        public static implicit operator FullAppInfoGenres(string value)
        {
            return Create(value);
        }

        public FullAppInfoGenres(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class FullAppInfoPlatforms : StringEnum<FullAppInfoPlatforms>
    {
        public static readonly FullAppInfoPlatforms Windows
            = new FullAppInfoPlatforms("Windows");

        public static readonly FullAppInfoPlatforms MacOS
            = new FullAppInfoPlatforms("MacOS");

        public static readonly FullAppInfoPlatforms Linux
            = new FullAppInfoPlatforms("Linux");

        public static readonly FullAppInfoPlatforms IOS
            = new FullAppInfoPlatforms("IOS");

        public static readonly FullAppInfoPlatforms Android
            = new FullAppInfoPlatforms("Android");


        public static implicit operator FullAppInfoPlatforms(string value)
        {
            return Create(value);
        }

        public FullAppInfoPlatforms(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class FullAppInfoPlayers : StringEnum<FullAppInfoPlayers>
    {
        public static readonly FullAppInfoPlayers Single
            = new FullAppInfoPlayers("Single");

        public static readonly FullAppInfoPlayers Multi
            = new FullAppInfoPlayers("Multi");

        public static readonly FullAppInfoPlayers CrossPlatformMulti
            = new FullAppInfoPlayers("CrossPlatformMulti");

        public static readonly FullAppInfoPlayers MMO
            = new FullAppInfoPlayers("MMO");

        public static readonly FullAppInfoPlayers Coop
            = new FullAppInfoPlayers("Coop");

        public static readonly FullAppInfoPlayers LocalCoop
            = new FullAppInfoPlayers("LocalCoop");


        public static implicit operator FullAppInfoPlayers(string value)
        {
            return Create(value);
        }

        public FullAppInfoPlayers(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class FullAppInfoPrimaryGenre : StringEnum<FullAppInfoPrimaryGenre>
    {
        public static readonly FullAppInfoPrimaryGenre Action
            = new FullAppInfoPrimaryGenre("Action");

        public static readonly FullAppInfoPrimaryGenre Adventure
            = new FullAppInfoPrimaryGenre("Adventure");

        public static readonly FullAppInfoPrimaryGenre Casual
            = new FullAppInfoPrimaryGenre("Casual");

        public static readonly FullAppInfoPrimaryGenre FreeToPlay
            = new FullAppInfoPrimaryGenre("FreeToPlay");

        public static readonly FullAppInfoPrimaryGenre Indie
            = new FullAppInfoPrimaryGenre("Indie");

        public static readonly FullAppInfoPrimaryGenre MassivelyMultiplayer
            = new FullAppInfoPrimaryGenre("MassivelyMultiplayer");

        public static readonly FullAppInfoPrimaryGenre Racing
            = new FullAppInfoPrimaryGenre("Racing");

        public static readonly FullAppInfoPrimaryGenre RPG
            = new FullAppInfoPrimaryGenre("RPG");

        public static readonly FullAppInfoPrimaryGenre Simulation
            = new FullAppInfoPrimaryGenre("Simulation");

        public static readonly FullAppInfoPrimaryGenre Sports
            = new FullAppInfoPrimaryGenre("Sports");

        public static readonly FullAppInfoPrimaryGenre Strategy
            = new FullAppInfoPrimaryGenre("Strategy");


        public static implicit operator FullAppInfoPrimaryGenre(string value)
        {
            return Create(value);
        }

        public FullAppInfoPrimaryGenre(string enumValue)
            : base(enumValue)
        {

        }
    }    
}