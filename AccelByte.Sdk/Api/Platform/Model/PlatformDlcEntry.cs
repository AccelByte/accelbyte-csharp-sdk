// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PlatformDlcEntry : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("platform")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PlatformDlcEntryPlatform? Platform { get; set; }

        [JsonPropertyName("platformDlcIdMap")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string>? PlatformDlcIdMap { get; set; }

    }



    public class PlatformDlcEntryPlatform : StringEnum<PlatformDlcEntryPlatform>
    {
        public static readonly PlatformDlcEntryPlatform EPICGAMES
            = new PlatformDlcEntryPlatform("EPICGAMES");

        public static readonly PlatformDlcEntryPlatform OCULUS
            = new PlatformDlcEntryPlatform("OCULUS");

        public static readonly PlatformDlcEntryPlatform PSN
            = new PlatformDlcEntryPlatform("PSN");

        public static readonly PlatformDlcEntryPlatform STEAM
            = new PlatformDlcEntryPlatform("STEAM");

        public static readonly PlatformDlcEntryPlatform XBOX
            = new PlatformDlcEntryPlatform("XBOX");


        public static implicit operator PlatformDlcEntryPlatform(string value)
        {
            return NewValue(value);
        }

        public PlatformDlcEntryPlatform(string enumValue)
            : base(enumValue)
        {

        }
    }
}