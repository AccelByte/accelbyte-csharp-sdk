// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class EntitlementPlatformConfigUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allowedPlatformOrigins")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public List<EntitlementPlatformConfigUpdateAllowedPlatformOrigins>? AllowedPlatformOrigins { get; set; }

    }



    public class EntitlementPlatformConfigUpdateAllowedPlatformOrigins : StringEnum<EntitlementPlatformConfigUpdateAllowedPlatformOrigins>
    {
        public static readonly EntitlementPlatformConfigUpdateAllowedPlatformOrigins Epic
            = new EntitlementPlatformConfigUpdateAllowedPlatformOrigins("Epic");

        public static readonly EntitlementPlatformConfigUpdateAllowedPlatformOrigins GooglePlay
            = new EntitlementPlatformConfigUpdateAllowedPlatformOrigins("GooglePlay");

        public static readonly EntitlementPlatformConfigUpdateAllowedPlatformOrigins IOS
            = new EntitlementPlatformConfigUpdateAllowedPlatformOrigins("IOS");

        public static readonly EntitlementPlatformConfigUpdateAllowedPlatformOrigins Nintendo
            = new EntitlementPlatformConfigUpdateAllowedPlatformOrigins("Nintendo");

        public static readonly EntitlementPlatformConfigUpdateAllowedPlatformOrigins Oculus
            = new EntitlementPlatformConfigUpdateAllowedPlatformOrigins("Oculus");

        public static readonly EntitlementPlatformConfigUpdateAllowedPlatformOrigins Other
            = new EntitlementPlatformConfigUpdateAllowedPlatformOrigins("Other");

        public static readonly EntitlementPlatformConfigUpdateAllowedPlatformOrigins Playstation
            = new EntitlementPlatformConfigUpdateAllowedPlatformOrigins("Playstation");

        public static readonly EntitlementPlatformConfigUpdateAllowedPlatformOrigins Steam
            = new EntitlementPlatformConfigUpdateAllowedPlatformOrigins("Steam");

        public static readonly EntitlementPlatformConfigUpdateAllowedPlatformOrigins System
            = new EntitlementPlatformConfigUpdateAllowedPlatformOrigins("System");

        public static readonly EntitlementPlatformConfigUpdateAllowedPlatformOrigins Twitch
            = new EntitlementPlatformConfigUpdateAllowedPlatformOrigins("Twitch");

        public static readonly EntitlementPlatformConfigUpdateAllowedPlatformOrigins Xbox
            = new EntitlementPlatformConfigUpdateAllowedPlatformOrigins("Xbox");


        public static implicit operator EntitlementPlatformConfigUpdateAllowedPlatformOrigins(string value)
        {
            return NewValue(value);
        }

        public EntitlementPlatformConfigUpdateAllowedPlatformOrigins(string enumValue)
            : base(enumValue)
        {

        }
    }
}