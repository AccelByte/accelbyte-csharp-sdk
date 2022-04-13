// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class WalletTransactionInfo : AccelByte.Sdk.Core.Model
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
        public WalletTransactionInfoWalletAction? WalletAction { get; set; }

        [JsonPropertyName("walletId")]
        public string? WalletId { get; set; }

    }

    public class WalletTransactionInfoWalletAction : StringEnum<WalletTransactionInfoWalletAction>
    {
        public static readonly WalletTransactionInfoWalletAction CREDIT
            = new WalletTransactionInfoWalletAction("CREDIT");

        public static readonly WalletTransactionInfoWalletAction PAYMENT
            = new WalletTransactionInfoWalletAction("PAYMENT");

        public static readonly WalletTransactionInfoWalletAction DEBIT
            = new WalletTransactionInfoWalletAction("DEBIT");


        public static implicit operator WalletTransactionInfoWalletAction(string value)
        {
            return Create(value);
        }

        public WalletTransactionInfoWalletAction(string enumValue)
            : base(enumValue)
        {

        }
    }    
}