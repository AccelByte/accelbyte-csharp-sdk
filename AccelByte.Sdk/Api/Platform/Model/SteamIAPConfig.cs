// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class SteamIAPConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AppId { get; set; }

        [JsonPropertyName("createdAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("env")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public SteamIAPConfigEnv? Env { get; set; }

        [JsonPropertyName("namespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Namespace { get; set; }

        [JsonPropertyName("publisherAuthenticationKey")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PublisherAuthenticationKey { get; set; }

        [JsonPropertyName("rvn")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Rvn { get; set; }

        [JsonPropertyName("syncMode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public SteamIAPConfigSyncMode? SyncMode { get; set; }

        [JsonPropertyName("updatedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? UpdatedAt { get; set; }

    }



    public class SteamIAPConfigEnv : StringEnum<SteamIAPConfigEnv>
    {
        public static readonly SteamIAPConfigEnv LIVE
            = new SteamIAPConfigEnv("LIVE");

        public static readonly SteamIAPConfigEnv SANDBOX
            = new SteamIAPConfigEnv("SANDBOX");


        public static implicit operator SteamIAPConfigEnv(string value)
        {
            return NewValue(value);
        }

        public SteamIAPConfigEnv(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class SteamIAPConfigSyncMode : StringEnum<SteamIAPConfigSyncMode>
    {
        public static readonly SteamIAPConfigSyncMode INVENTORY
            = new SteamIAPConfigSyncMode("INVENTORY");

        public static readonly SteamIAPConfigSyncMode TRANSACTION
            = new SteamIAPConfigSyncMode("TRANSACTION");


        public static implicit operator SteamIAPConfigSyncMode(string value)
        {
            return NewValue(value);
        }

        public SteamIAPConfigSyncMode(string enumValue)
            : base(enumValue)
        {

        }
    }
}