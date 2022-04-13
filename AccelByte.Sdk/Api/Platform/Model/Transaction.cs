// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class Transaction : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalData")]
        public AdditionalData? AdditionalData { get; set; }

        [JsonPropertyName("amount")]
        public int? Amount { get; set; }

        [JsonPropertyName("currency")]
        public CurrencySummary? Currency { get; set; }

        [JsonPropertyName("extMessage")]
        public string? ExtMessage { get; set; }

        [JsonPropertyName("extStatusCode")]
        public string? ExtStatusCode { get; set; }

        [JsonPropertyName("extTxId")]
        public string? ExtTxId { get; set; }

        [JsonPropertyName("merchantId")]
        public string? MerchantId { get; set; }

        [JsonPropertyName("notified")]
        public bool? Notified { get; set; }

        [JsonPropertyName("paymentMethod")]
        public string? PaymentMethod { get; set; }

        [JsonPropertyName("paymentMethodFee")]
        public int? PaymentMethodFee { get; set; }

        [JsonPropertyName("paymentProviderFee")]
        public int? PaymentProviderFee { get; set; }

        [JsonPropertyName("provider")]
        [JsonStringEnum]
        public TransactionProvider? Provider { get; set; }

        [JsonPropertyName("salesTax")]
        public int? SalesTax { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public TransactionStatus? Status { get; set; }

        [JsonPropertyName("tax")]
        public int? Tax { get; set; }

        [JsonPropertyName("txEndTime")]
        public DateTime? TxEndTime { get; set; }

        [JsonPropertyName("txId")]
        public string? TxId { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public TransactionType? Type { get; set; }

        [JsonPropertyName("vat")]
        public int? Vat { get; set; }

    }

    public class TransactionProvider : StringEnum<TransactionProvider>
    {
        public static readonly TransactionProvider WALLET
            = new TransactionProvider("WALLET");

        public static readonly TransactionProvider XSOLLA
            = new TransactionProvider("XSOLLA");

        public static readonly TransactionProvider ADYEN
            = new TransactionProvider("ADYEN");

        public static readonly TransactionProvider STRIPE
            = new TransactionProvider("STRIPE");

        public static readonly TransactionProvider CHECKOUT
            = new TransactionProvider("CHECKOUT");

        public static readonly TransactionProvider ALIPAY
            = new TransactionProvider("ALIPAY");

        public static readonly TransactionProvider WXPAY
            = new TransactionProvider("WXPAY");

        public static readonly TransactionProvider PAYPAL
            = new TransactionProvider("PAYPAL");


        public static implicit operator TransactionProvider(string value)
        {
            return Create(value);
        }

        public TransactionProvider(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class TransactionStatus : StringEnum<TransactionStatus>
    {
        public static readonly TransactionStatus FINISHED
            = new TransactionStatus("FINISHED");

        public static readonly TransactionStatus FAILED
            = new TransactionStatus("FAILED");


        public static implicit operator TransactionStatus(string value)
        {
            return Create(value);
        }

        public TransactionStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class TransactionType : StringEnum<TransactionType>
    {
        public static readonly TransactionType AUTHORISATION
            = new TransactionType("AUTHORISATION");

        public static readonly TransactionType CHARGE
            = new TransactionType("CHARGE");

        public static readonly TransactionType CHARGEFAILED
            = new TransactionType("CHARGE_FAILED");

        public static readonly TransactionType NOTIFICATIONOFCHARGEBACK
            = new TransactionType("NOTIFICATION_OF_CHARGEBACK");

        public static readonly TransactionType REQUESTFORINFORMATION
            = new TransactionType("REQUEST_FOR_INFORMATION");

        public static readonly TransactionType CHARGEBACK
            = new TransactionType("CHARGEBACK");

        public static readonly TransactionType CHARGEBACKREVERSED
            = new TransactionType("CHARGEBACK_REVERSED");

        public static readonly TransactionType REFUND
            = new TransactionType("REFUND");

        public static readonly TransactionType REFUNDFAILED
            = new TransactionType("REFUND_FAILED");


        public static implicit operator TransactionType(string value)
        {
            return Create(value);
        }

        public TransactionType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}