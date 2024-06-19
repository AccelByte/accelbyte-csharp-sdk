// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentOrderInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("authorisedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? AuthorisedTime { get; set; }

        [JsonPropertyName("channel")]
        [JsonStringEnum]
        public PaymentOrderInfoChannel? Channel { get; set; }

        [JsonPropertyName("chargebackReversedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ChargebackReversedTime { get; set; }

        [JsonPropertyName("chargebackTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ChargebackTime { get; set; }

        [JsonPropertyName("chargedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ChargedTime { get; set; }

        [JsonPropertyName("charging")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Charging { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("createdTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedTime { get; set; }

        [JsonPropertyName("currency")]
        public CurrencySummary? Currency { get; set; }

        [JsonPropertyName("customParameters")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? CustomParameters { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("extOrderNo")]
        public string? ExtOrderNo { get; set; }

        [JsonPropertyName("extUserId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtUserId { get; set; }

        [JsonPropertyName("itemType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PaymentOrderInfoItemType? ItemType { get; set; }

        [JsonPropertyName("language")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Language { get; set; }

        [JsonPropertyName("metadata")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string>? Metadata { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("notifyUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? NotifyUrl { get; set; }

        [JsonPropertyName("omitNotification")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? OmitNotification { get; set; }

        [JsonPropertyName("paymentMethod")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PaymentMethod { get; set; }

        [JsonPropertyName("paymentMethodFee")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? PaymentMethodFee { get; set; }

        [JsonPropertyName("paymentOrderNo")]
        public string? PaymentOrderNo { get; set; }

        [JsonPropertyName("paymentProvider")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PaymentOrderInfoPaymentProvider? PaymentProvider { get; set; }

        [JsonPropertyName("paymentProviderFee")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? PaymentProviderFee { get; set; }

        [JsonPropertyName("paymentStationUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PaymentStationUrl { get; set; }

        [JsonPropertyName("price")]
        public int? Price { get; set; }

        [JsonPropertyName("recurringPaymentOrderNo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RecurringPaymentOrderNo { get; set; }

        [JsonPropertyName("refundedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? RefundedTime { get; set; }

        [JsonPropertyName("region")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Region { get; set; }

        [JsonPropertyName("returnUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReturnUrl { get; set; }

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
        public PaymentOrderInfoStatus? Status { get; set; }

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

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("totalPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TotalPrice { get; set; }

        [JsonPropertyName("totalTax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TotalTax { get; set; }

        [JsonPropertyName("transactions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Transaction>? Transactions { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

        [JsonPropertyName("vat")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Vat { get; set; }

    }

    public class PaymentOrderInfo<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("authorisedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? AuthorisedTime { get; set; }

        [JsonPropertyName("channel")]
        [JsonStringEnum]
        public PaymentOrderInfoChannel? Channel { get; set; }

        [JsonPropertyName("chargebackReversedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ChargebackReversedTime { get; set; }

        [JsonPropertyName("chargebackTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ChargebackTime { get; set; }

        [JsonPropertyName("chargedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ChargedTime { get; set; }

        [JsonPropertyName("charging")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Charging { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("createdTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedTime { get; set; }

        [JsonPropertyName("currency")]
        public CurrencySummary? Currency { get; set; }

        [JsonPropertyName("customParameters")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? CustomParameters { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("extOrderNo")]
        public string? ExtOrderNo { get; set; }

        [JsonPropertyName("extUserId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtUserId { get; set; }

        [JsonPropertyName("itemType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PaymentOrderInfoItemType? ItemType { get; set; }

        [JsonPropertyName("language")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Language { get; set; }

        [JsonPropertyName("metadata")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string>? Metadata { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("notifyUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? NotifyUrl { get; set; }

        [JsonPropertyName("omitNotification")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? OmitNotification { get; set; }

        [JsonPropertyName("paymentMethod")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PaymentMethod { get; set; }

        [JsonPropertyName("paymentMethodFee")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? PaymentMethodFee { get; set; }

        [JsonPropertyName("paymentOrderNo")]
        public string? PaymentOrderNo { get; set; }

        [JsonPropertyName("paymentProvider")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PaymentOrderInfoPaymentProvider? PaymentProvider { get; set; }

        [JsonPropertyName("paymentProviderFee")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? PaymentProviderFee { get; set; }

        [JsonPropertyName("paymentStationUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PaymentStationUrl { get; set; }

        [JsonPropertyName("price")]
        public int? Price { get; set; }

        [JsonPropertyName("recurringPaymentOrderNo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RecurringPaymentOrderNo { get; set; }

        [JsonPropertyName("refundedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? RefundedTime { get; set; }

        [JsonPropertyName("region")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Region { get; set; }

        [JsonPropertyName("returnUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReturnUrl { get; set; }

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
        public PaymentOrderInfoStatus? Status { get; set; }

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

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("totalPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TotalPrice { get; set; }

        [JsonPropertyName("totalTax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TotalTax { get; set; }

        [JsonPropertyName("transactions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Transaction>? Transactions { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

        [JsonPropertyName("vat")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Vat { get; set; }

    }


    public class PaymentOrderInfoChannel : StringEnum<PaymentOrderInfoChannel>
    {
        public static readonly PaymentOrderInfoChannel EXTERNAL
            = new PaymentOrderInfoChannel("EXTERNAL");

        public static readonly PaymentOrderInfoChannel INTERNAL
            = new PaymentOrderInfoChannel("INTERNAL");


        public static implicit operator PaymentOrderInfoChannel(string value)
        {
            return NewValue(value);
        }

        public PaymentOrderInfoChannel(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class PaymentOrderInfoItemType : StringEnum<PaymentOrderInfoItemType>
    {
        public static readonly PaymentOrderInfoItemType APP
            = new PaymentOrderInfoItemType("APP");

        public static readonly PaymentOrderInfoItemType BUNDLE
            = new PaymentOrderInfoItemType("BUNDLE");

        public static readonly PaymentOrderInfoItemType CODE
            = new PaymentOrderInfoItemType("CODE");

        public static readonly PaymentOrderInfoItemType COINS
            = new PaymentOrderInfoItemType("COINS");

        public static readonly PaymentOrderInfoItemType EXTENSION
            = new PaymentOrderInfoItemType("EXTENSION");

        public static readonly PaymentOrderInfoItemType INGAMEITEM
            = new PaymentOrderInfoItemType("INGAMEITEM");

        public static readonly PaymentOrderInfoItemType LOOTBOX
            = new PaymentOrderInfoItemType("LOOTBOX");

        public static readonly PaymentOrderInfoItemType MEDIA
            = new PaymentOrderInfoItemType("MEDIA");

        public static readonly PaymentOrderInfoItemType OPTIONBOX
            = new PaymentOrderInfoItemType("OPTIONBOX");

        public static readonly PaymentOrderInfoItemType SEASON
            = new PaymentOrderInfoItemType("SEASON");

        public static readonly PaymentOrderInfoItemType SUBSCRIPTION
            = new PaymentOrderInfoItemType("SUBSCRIPTION");


        public static implicit operator PaymentOrderInfoItemType(string value)
        {
            return NewValue(value);
        }

        public PaymentOrderInfoItemType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class PaymentOrderInfoPaymentProvider : StringEnum<PaymentOrderInfoPaymentProvider>
    {
        public static readonly PaymentOrderInfoPaymentProvider ADYEN
            = new PaymentOrderInfoPaymentProvider("ADYEN");

        public static readonly PaymentOrderInfoPaymentProvider ALIPAY
            = new PaymentOrderInfoPaymentProvider("ALIPAY");

        public static readonly PaymentOrderInfoPaymentProvider CHECKOUT
            = new PaymentOrderInfoPaymentProvider("CHECKOUT");

        public static readonly PaymentOrderInfoPaymentProvider NEONPAY
            = new PaymentOrderInfoPaymentProvider("NEONPAY");

        public static readonly PaymentOrderInfoPaymentProvider PAYPAL
            = new PaymentOrderInfoPaymentProvider("PAYPAL");

        public static readonly PaymentOrderInfoPaymentProvider STRIPE
            = new PaymentOrderInfoPaymentProvider("STRIPE");

        public static readonly PaymentOrderInfoPaymentProvider WALLET
            = new PaymentOrderInfoPaymentProvider("WALLET");

        public static readonly PaymentOrderInfoPaymentProvider WXPAY
            = new PaymentOrderInfoPaymentProvider("WXPAY");

        public static readonly PaymentOrderInfoPaymentProvider XSOLLA
            = new PaymentOrderInfoPaymentProvider("XSOLLA");


        public static implicit operator PaymentOrderInfoPaymentProvider(string value)
        {
            return NewValue(value);
        }

        public PaymentOrderInfoPaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class PaymentOrderInfoStatus : StringEnum<PaymentOrderInfoStatus>
    {
        public static readonly PaymentOrderInfoStatus AUTHORISED
            = new PaymentOrderInfoStatus("AUTHORISED");

        public static readonly PaymentOrderInfoStatus AUTHORISEFAILED
            = new PaymentOrderInfoStatus("AUTHORISE_FAILED");

        public static readonly PaymentOrderInfoStatus CHARGEBACK
            = new PaymentOrderInfoStatus("CHARGEBACK");

        public static readonly PaymentOrderInfoStatus CHARGEBACKREVERSED
            = new PaymentOrderInfoStatus("CHARGEBACK_REVERSED");

        public static readonly PaymentOrderInfoStatus CHARGED
            = new PaymentOrderInfoStatus("CHARGED");

        public static readonly PaymentOrderInfoStatus CHARGEFAILED
            = new PaymentOrderInfoStatus("CHARGE_FAILED");

        public static readonly PaymentOrderInfoStatus DELETED
            = new PaymentOrderInfoStatus("DELETED");

        public static readonly PaymentOrderInfoStatus INIT
            = new PaymentOrderInfoStatus("INIT");

        public static readonly PaymentOrderInfoStatus NOTIFICATIONOFCHARGEBACK
            = new PaymentOrderInfoStatus("NOTIFICATION_OF_CHARGEBACK");

        public static readonly PaymentOrderInfoStatus REFUNDED
            = new PaymentOrderInfoStatus("REFUNDED");

        public static readonly PaymentOrderInfoStatus REFUNDING
            = new PaymentOrderInfoStatus("REFUNDING");

        public static readonly PaymentOrderInfoStatus REFUNDFAILED
            = new PaymentOrderInfoStatus("REFUND_FAILED");

        public static readonly PaymentOrderInfoStatus REQUESTFORINFORMATION
            = new PaymentOrderInfoStatus("REQUEST_FOR_INFORMATION");


        public static implicit operator PaymentOrderInfoStatus(string value)
        {
            return NewValue(value);
        }

        public PaymentOrderInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}