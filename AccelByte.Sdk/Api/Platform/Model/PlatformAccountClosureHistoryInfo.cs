// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PlatformAccountClosureHistoryInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("entitlements")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<SimpleEntitlement>? Entitlements { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("platform")]
        public string? Platform { get; set; }

        [JsonPropertyName("progression")]
        [JsonStringEnum]
        public PlatformAccountClosureHistoryInfoProgression? Progression { get; set; }

        [JsonPropertyName("userDlcS")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<SimpleUserDLC>? UserDlcS { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

        [JsonPropertyName("wallets")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<SimpleWallet>? Wallets { get; set; }

    }



    public class PlatformAccountClosureHistoryInfoProgression : StringEnum<PlatformAccountClosureHistoryInfoProgression>
    {
        public static readonly PlatformAccountClosureHistoryInfoProgression INPROGRESS
            = new PlatformAccountClosureHistoryInfoProgression("IN_PROGRESS");

        public static readonly PlatformAccountClosureHistoryInfoProgression SUCCESS
            = new PlatformAccountClosureHistoryInfoProgression("SUCCESS");


        public static implicit operator PlatformAccountClosureHistoryInfoProgression(string value)
        {
            return NewValue(value);
        }

        public PlatformAccountClosureHistoryInfoProgression(string enumValue)
            : base(enumValue)
        {

        }
    }
}