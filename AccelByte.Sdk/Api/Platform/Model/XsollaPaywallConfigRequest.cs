// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class XsollaPaywallConfigRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("device")]
        [JsonStringEnum]
        public XsollaPaywallConfigRequestDevice? Device { get; set; }

        [JsonPropertyName("showCloseButton")]
        public bool? ShowCloseButton { get; set; }

        [JsonPropertyName("size")]
        [JsonStringEnum]
        public XsollaPaywallConfigRequestSize? Size { get; set; }

        [JsonPropertyName("theme")]
        [JsonStringEnum]
        public XsollaPaywallConfigRequestTheme? Theme { get; set; }

    }

    public class XsollaPaywallConfigRequestDevice : StringEnum<XsollaPaywallConfigRequestDevice>
    {
        public static readonly XsollaPaywallConfigRequestDevice DESKTOP
            = new XsollaPaywallConfigRequestDevice("DESKTOP");

        public static readonly XsollaPaywallConfigRequestDevice MOBILE
            = new XsollaPaywallConfigRequestDevice("MOBILE");


        public static implicit operator XsollaPaywallConfigRequestDevice(string value)
        {
            return Create(value);
        }

        public XsollaPaywallConfigRequestDevice(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class XsollaPaywallConfigRequestSize : StringEnum<XsollaPaywallConfigRequestSize>
    {
        public static readonly XsollaPaywallConfigRequestSize SMALL
            = new XsollaPaywallConfigRequestSize("SMALL");

        public static readonly XsollaPaywallConfigRequestSize MEDIUM
            = new XsollaPaywallConfigRequestSize("MEDIUM");

        public static readonly XsollaPaywallConfigRequestSize LARGE
            = new XsollaPaywallConfigRequestSize("LARGE");


        public static implicit operator XsollaPaywallConfigRequestSize(string value)
        {
            return Create(value);
        }

        public XsollaPaywallConfigRequestSize(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class XsollaPaywallConfigRequestTheme : StringEnum<XsollaPaywallConfigRequestTheme>
    {
        public static readonly XsollaPaywallConfigRequestTheme DEFAULT
            = new XsollaPaywallConfigRequestTheme("DEFAULT");

        public static readonly XsollaPaywallConfigRequestTheme DARK
            = new XsollaPaywallConfigRequestTheme("DARK");

        public static readonly XsollaPaywallConfigRequestTheme DEFAULTDARK
            = new XsollaPaywallConfigRequestTheme("DEFAULT_DARK");


        public static implicit operator XsollaPaywallConfigRequestTheme(string value)
        {
            return Create(value);
        }

        public XsollaPaywallConfigRequestTheme(string enumValue)
            : base(enumValue)
        {

        }
    }    
}