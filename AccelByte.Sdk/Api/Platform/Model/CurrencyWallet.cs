// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CurrencyWallet : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("balance")]
        public long? Balance { get; set; }

        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonPropertyName("currencySymbol")]
        public string? CurrencySymbol { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("totalPermanentBalance")]
        public long? TotalPermanentBalance { get; set; }

        [JsonPropertyName("totalTimeLimitedBalance")]
        public long? TotalTimeLimitedBalance { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

        [JsonPropertyName("walletInfos")]
        public List<WalletInfo>? WalletInfos { get; set; }

    }
}