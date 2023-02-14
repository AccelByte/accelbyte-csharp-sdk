// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class TradeNotification : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalData")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public AdditionalData? AdditionalData { get; set; }

        [JsonPropertyName("authorisedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? AuthorisedTime { get; set; }

        [JsonPropertyName("chargebackReversedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ChargebackReversedTime { get; set; }

        [JsonPropertyName("chargebackTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ChargebackTime { get; set; }

        [JsonPropertyName("chargedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ChargedTime { get; set; }

        [JsonPropertyName("createdTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedTime { get; set; }

        [JsonPropertyName("currency")]
        public CurrencySummary? Currency { get; set; }

        [JsonPropertyName("customParameters")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? CustomParameters { get; set; }

        [JsonPropertyName("extOrderNo")]
        public string? ExtOrderNo { get; set; }

        [JsonPropertyName("extTxId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtTxId { get; set; }

        [JsonPropertyName("extUserId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtUserId { get; set; }

        [JsonPropertyName("issuedAt")]
        public DateTime? IssuedAt { get; set; }

        [JsonPropertyName("metadata")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string>? Metadata { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("nonceStr")]
        public string? NonceStr { get; set; }

        [JsonPropertyName("paymentMethod")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PaymentMethod { get; set; }

        [JsonPropertyName("paymentMethodFee")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? PaymentMethodFee { get; set; }

        [JsonPropertyName("paymentOrderNo")]
        public string? PaymentOrderNo { get; set; }

        [JsonPropertyName("paymentProvider")]
        [JsonStringEnum]
        public TradeNotificationPaymentProvider? PaymentProvider { get; set; }

        [JsonPropertyName("paymentProviderFee")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? PaymentProviderFee { get; set; }

        [JsonPropertyName("paymentStationUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PaymentStationUrl { get; set; }

        [JsonPropertyName("price")]
        public int? Price { get; set; }

        [JsonPropertyName("refundedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? RefundedTime { get; set; }

        [JsonPropertyName("salesTax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? SalesTax { get; set; }

        [JsonPropertyName("sandbox")]
        public bool? Sandbox { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public TradeNotificationStatus? Status { get; set; }

        [JsonPropertyName("statusReason")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? StatusReason { get; set; }

        [JsonPropertyName("subscriptionId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SubscriptionId { get; set; }

        [JsonPropertyName("subtotalPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? SubtotalPrice { get; set; }

        [JsonPropertyName("targetNamespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetNamespace { get; set; }

        [JsonPropertyName("targetUserId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetUserId { get; set; }

        [JsonPropertyName("tax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Tax { get; set; }

        [JsonPropertyName("totalPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TotalPrice { get; set; }

        [JsonPropertyName("totalTax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TotalTax { get; set; }

        [JsonPropertyName("txEndTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? TxEndTime { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("userId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? UserId { get; set; }

        [JsonPropertyName("vat")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Vat { get; set; }

    }

    public class TradeNotification<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalData")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public AdditionalData? AdditionalData { get; set; }

        [JsonPropertyName("authorisedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? AuthorisedTime { get; set; }

        [JsonPropertyName("chargebackReversedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ChargebackReversedTime { get; set; }

        [JsonPropertyName("chargebackTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ChargebackTime { get; set; }

        [JsonPropertyName("chargedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ChargedTime { get; set; }

        [JsonPropertyName("createdTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedTime { get; set; }

        [JsonPropertyName("currency")]
        public CurrencySummary? Currency { get; set; }

        [JsonPropertyName("customParameters")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? CustomParameters { get; set; }

        [JsonPropertyName("extOrderNo")]
        public string? ExtOrderNo { get; set; }

        [JsonPropertyName("extTxId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtTxId { get; set; }

        [JsonPropertyName("extUserId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtUserId { get; set; }

        [JsonPropertyName("issuedAt")]
        public DateTime? IssuedAt { get; set; }

        [JsonPropertyName("metadata")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string>? Metadata { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("nonceStr")]
        public string? NonceStr { get; set; }

        [JsonPropertyName("paymentMethod")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PaymentMethod { get; set; }

        [JsonPropertyName("paymentMethodFee")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? PaymentMethodFee { get; set; }

        [JsonPropertyName("paymentOrderNo")]
        public string? PaymentOrderNo { get; set; }

        [JsonPropertyName("paymentProvider")]
        [JsonStringEnum]
        public TradeNotificationPaymentProvider? PaymentProvider { get; set; }

        [JsonPropertyName("paymentProviderFee")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? PaymentProviderFee { get; set; }

        [JsonPropertyName("paymentStationUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PaymentStationUrl { get; set; }

        [JsonPropertyName("price")]
        public int? Price { get; set; }

        [JsonPropertyName("refundedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? RefundedTime { get; set; }

        [JsonPropertyName("salesTax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? SalesTax { get; set; }

        [JsonPropertyName("sandbox")]
        public bool? Sandbox { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public TradeNotificationStatus? Status { get; set; }

        [JsonPropertyName("statusReason")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? StatusReason { get; set; }

        [JsonPropertyName("subscriptionId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SubscriptionId { get; set; }

        [JsonPropertyName("subtotalPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? SubtotalPrice { get; set; }

        [JsonPropertyName("targetNamespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetNamespace { get; set; }

        [JsonPropertyName("targetUserId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetUserId { get; set; }

        [JsonPropertyName("tax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Tax { get; set; }

        [JsonPropertyName("totalPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TotalPrice { get; set; }

        [JsonPropertyName("totalTax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TotalTax { get; set; }

        [JsonPropertyName("txEndTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? TxEndTime { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("userId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? UserId { get; set; }

        [JsonPropertyName("vat")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Vat { get; set; }

    }


    public class TradeNotificationPaymentProvider : StringEnum<TradeNotificationPaymentProvider>
    {
        public static readonly TradeNotificationPaymentProvider ADYEN
            = new TradeNotificationPaymentProvider("ADYEN");

        public static readonly TradeNotificationPaymentProvider ALIPAY
            = new TradeNotificationPaymentProvider("ALIPAY");

        public static readonly TradeNotificationPaymentProvider CHECKOUT
            = new TradeNotificationPaymentProvider("CHECKOUT");

        public static readonly TradeNotificationPaymentProvider PAYPAL
            = new TradeNotificationPaymentProvider("PAYPAL");

        public static readonly TradeNotificationPaymentProvider STRIPE
            = new TradeNotificationPaymentProvider("STRIPE");

        public static readonly TradeNotificationPaymentProvider WALLET
            = new TradeNotificationPaymentProvider("WALLET");

        public static readonly TradeNotificationPaymentProvider WXPAY
            = new TradeNotificationPaymentProvider("WXPAY");

        public static readonly TradeNotificationPaymentProvider XSOLLA
            = new TradeNotificationPaymentProvider("XSOLLA");


        public static implicit operator TradeNotificationPaymentProvider(string value)
        {
            return NewValue(value);
        }

        public TradeNotificationPaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class TradeNotificationStatus : StringEnum<TradeNotificationStatus>
    {
        public static readonly TradeNotificationStatus AUTHORISED
            = new TradeNotificationStatus("AUTHORISED");

        public static readonly TradeNotificationStatus AUTHORISEFAILED
            = new TradeNotificationStatus("AUTHORISE_FAILED");

        public static readonly TradeNotificationStatus CHARGEBACK
            = new TradeNotificationStatus("CHARGEBACK");

        public static readonly TradeNotificationStatus CHARGEBACKREVERSED
            = new TradeNotificationStatus("CHARGEBACK_REVERSED");

        public static readonly TradeNotificationStatus CHARGED
            = new TradeNotificationStatus("CHARGED");

        public static readonly TradeNotificationStatus CHARGEFAILED
            = new TradeNotificationStatus("CHARGE_FAILED");

        public static readonly TradeNotificationStatus DELETED
            = new TradeNotificationStatus("DELETED");

        public static readonly TradeNotificationStatus INIT
            = new TradeNotificationStatus("INIT");

        public static readonly TradeNotificationStatus NOTIFICATIONOFCHARGEBACK
            = new TradeNotificationStatus("NOTIFICATION_OF_CHARGEBACK");

        public static readonly TradeNotificationStatus REFUNDED
            = new TradeNotificationStatus("REFUNDED");

        public static readonly TradeNotificationStatus REFUNDING
            = new TradeNotificationStatus("REFUNDING");

        public static readonly TradeNotificationStatus REFUNDFAILED
            = new TradeNotificationStatus("REFUND_FAILED");

        public static readonly TradeNotificationStatus REQUESTFORINFORMATION
            = new TradeNotificationStatus("REQUEST_FOR_INFORMATION");


        public static implicit operator TradeNotificationStatus(string value)
        {
            return NewValue(value);
        }

        public TradeNotificationStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}