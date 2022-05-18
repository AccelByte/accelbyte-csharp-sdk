// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class DetailedWalletTransactionInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonPropertyName("balanceSource")]
        public string? BalanceSource { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("operator")]
        public string? Operator { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

        [JsonPropertyName("walletAction")]
        [JsonStringEnum]
        public DetailedWalletTransactionInfoWalletAction? WalletAction { get; set; }

        [JsonPropertyName("walletId")]
        public string? WalletId { get; set; }

    }

    public class DetailedWalletTransactionInfoWalletAction : StringEnum<DetailedWalletTransactionInfoWalletAction>
    {
        public static readonly DetailedWalletTransactionInfoWalletAction CREDIT
            = new DetailedWalletTransactionInfoWalletAction("CREDIT");

        public static readonly DetailedWalletTransactionInfoWalletAction PAYMENT
            = new DetailedWalletTransactionInfoWalletAction("PAYMENT");

        public static readonly DetailedWalletTransactionInfoWalletAction DEBIT
            = new DetailedWalletTransactionInfoWalletAction("DEBIT");


        public static implicit operator DetailedWalletTransactionInfoWalletAction(string value)
        {
            return NewValue(value);
        }

        public DetailedWalletTransactionInfoWalletAction(string enumValue)
            : base(enumValue)
        {

        }
    }    
}