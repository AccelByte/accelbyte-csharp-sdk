// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class SteamIAPConfigRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }

        [JsonPropertyName("env")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public SteamIAPConfigRequestEnv? Env { get; set; }

        [JsonPropertyName("publisherAuthenticationKey")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PublisherAuthenticationKey { get; set; }

        [JsonPropertyName("syncMode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public SteamIAPConfigRequestSyncMode? SyncMode { get; set; }

    }



    public class SteamIAPConfigRequestEnv : StringEnum<SteamIAPConfigRequestEnv>
    {
        public static readonly SteamIAPConfigRequestEnv LIVE
            = new SteamIAPConfigRequestEnv("LIVE");

        public static readonly SteamIAPConfigRequestEnv SANDBOX
            = new SteamIAPConfigRequestEnv("SANDBOX");


        public static implicit operator SteamIAPConfigRequestEnv(string value)
        {
            return NewValue(value);
        }

        public SteamIAPConfigRequestEnv(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class SteamIAPConfigRequestSyncMode : StringEnum<SteamIAPConfigRequestSyncMode>
    {
        public static readonly SteamIAPConfigRequestSyncMode INVENTORY
            = new SteamIAPConfigRequestSyncMode("INVENTORY");

        public static readonly SteamIAPConfigRequestSyncMode TRANSACTION
            = new SteamIAPConfigRequestSyncMode("TRANSACTION");


        public static implicit operator SteamIAPConfigRequestSyncMode(string value)
        {
            return NewValue(value);
        }

        public SteamIAPConfigRequestSyncMode(string enumValue)
            : base(enumValue)
        {

        }
    }
}