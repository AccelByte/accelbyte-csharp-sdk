// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class TimeLimitedBalance : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("balance")]
        public long? Balance { get; set; }

        [JsonPropertyName("balanceSource")]
        public string? BalanceSource { get; set; }

        [JsonPropertyName("expireAt")]
        public DateTime? ExpireAt { get; set; }

    }
}