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
        public DateTime? AuthorisedTime { get; set; }

        [JsonPropertyName("channel")]
        [JsonStringEnum]
        public PaymentOrderInfoChannel? Channel { get; set; }

        [JsonPropertyName("chargebackReversedTime")]
        public DateTime? ChargebackReversedTime { get; set; }

        [JsonPropertyName("chargebackTime")]
        public DateTime? ChargebackTime { get; set; }

        [JsonPropertyName("chargedTime")]
        public DateTime? ChargedTime { get; set; }

        [JsonPropertyName("charging")]
        public bool? Charging { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("createdTime")]
        public DateTime? CreatedTime { get; set; }

        [JsonPropertyName("currency")]
        public CurrencySummary? Currency { get; set; }

        [JsonPropertyName("customParameters")]
        public Dictionary<string, object>? CustomParameters { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("extOrderNo")]
        public string? ExtOrderNo { get; set; }

        [JsonPropertyName("extUserId")]
        public string? ExtUserId { get; set; }

        [JsonPropertyName("itemType")]
        [JsonStringEnum]
        public PaymentOrderInfoItemType? ItemType { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("notifyUrl")]
        public string? NotifyUrl { get; set; }

        [JsonPropertyName("omitNotification")]
        public bool? OmitNotification { get; set; }

        [JsonPropertyName("paymentMethod")]
        public string? PaymentMethod { get; set; }

        [JsonPropertyName("paymentMethodFee")]
        public int? PaymentMethodFee { get; set; }

        [JsonPropertyName("paymentOrderNo")]
        public string? PaymentOrderNo { get; set; }

        [JsonPropertyName("paymentProvider")]
        [JsonStringEnum]
        public PaymentOrderInfoPaymentProvider? PaymentProvider { get; set; }

        [JsonPropertyName("paymentProviderFee")]
        public int? PaymentProviderFee { get; set; }

        [JsonPropertyName("paymentStationUrl")]
        public string? PaymentStationUrl { get; set; }

        [JsonPropertyName("price")]
        public int? Price { get; set; }

        [JsonPropertyName("recurringPaymentOrderNo")]
        public string? RecurringPaymentOrderNo { get; set; }

        [JsonPropertyName("refundedTime")]
        public DateTime? RefundedTime { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("returnUrl")]
        public string? ReturnUrl { get; set; }

        [JsonPropertyName("salesTax")]
        public int? SalesTax { get; set; }

        [JsonPropertyName("sandbox")]
        public bool? Sandbox { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public PaymentOrderInfoStatus? Status { get; set; }

        [JsonPropertyName("statusReason")]
        public string? StatusReason { get; set; }

        [JsonPropertyName("subscriptionId")]
        public string? SubscriptionId { get; set; }

        [JsonPropertyName("subtotalPrice")]
        public int? SubtotalPrice { get; set; }

        [JsonPropertyName("targetNamespace")]
        public string? TargetNamespace { get; set; }

        [JsonPropertyName("targetUserId")]
        public string? TargetUserId { get; set; }

        [JsonPropertyName("tax")]
        public int? Tax { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("totalPrice")]
        public int? TotalPrice { get; set; }

        [JsonPropertyName("totalTax")]
        public int? TotalTax { get; set; }

        [JsonPropertyName("transactions")]
        public List<Transaction>? Transactions { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

        [JsonPropertyName("vat")]
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
            return Create(value);
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

        public static readonly PaymentOrderInfoItemType COINS
            = new PaymentOrderInfoItemType("COINS");

        public static readonly PaymentOrderInfoItemType INGAMEITEM
            = new PaymentOrderInfoItemType("INGAMEITEM");

        public static readonly PaymentOrderInfoItemType BUNDLE
            = new PaymentOrderInfoItemType("BUNDLE");

        public static readonly PaymentOrderInfoItemType CODE
            = new PaymentOrderInfoItemType("CODE");

        public static readonly PaymentOrderInfoItemType SUBSCRIPTION
            = new PaymentOrderInfoItemType("SUBSCRIPTION");

        public static readonly PaymentOrderInfoItemType SEASON
            = new PaymentOrderInfoItemType("SEASON");

        public static readonly PaymentOrderInfoItemType MEDIA
            = new PaymentOrderInfoItemType("MEDIA");


        public static implicit operator PaymentOrderInfoItemType(string value)
        {
            return Create(value);
        }

        public PaymentOrderInfoItemType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class PaymentOrderInfoPaymentProvider : StringEnum<PaymentOrderInfoPaymentProvider>
    {
        public static readonly PaymentOrderInfoPaymentProvider WALLET
            = new PaymentOrderInfoPaymentProvider("WALLET");

        public static readonly PaymentOrderInfoPaymentProvider XSOLLA
            = new PaymentOrderInfoPaymentProvider("XSOLLA");

        public static readonly PaymentOrderInfoPaymentProvider ADYEN
            = new PaymentOrderInfoPaymentProvider("ADYEN");

        public static readonly PaymentOrderInfoPaymentProvider STRIPE
            = new PaymentOrderInfoPaymentProvider("STRIPE");

        public static readonly PaymentOrderInfoPaymentProvider CHECKOUT
            = new PaymentOrderInfoPaymentProvider("CHECKOUT");

        public static readonly PaymentOrderInfoPaymentProvider ALIPAY
            = new PaymentOrderInfoPaymentProvider("ALIPAY");

        public static readonly PaymentOrderInfoPaymentProvider WXPAY
            = new PaymentOrderInfoPaymentProvider("WXPAY");

        public static readonly PaymentOrderInfoPaymentProvider PAYPAL
            = new PaymentOrderInfoPaymentProvider("PAYPAL");


        public static implicit operator PaymentOrderInfoPaymentProvider(string value)
        {
            return Create(value);
        }

        public PaymentOrderInfoPaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class PaymentOrderInfoStatus : StringEnum<PaymentOrderInfoStatus>
    {
        public static readonly PaymentOrderInfoStatus INIT
            = new PaymentOrderInfoStatus("INIT");

        public static readonly PaymentOrderInfoStatus AUTHORISED
            = new PaymentOrderInfoStatus("AUTHORISED");

        public static readonly PaymentOrderInfoStatus AUTHORISEFAILED
            = new PaymentOrderInfoStatus("AUTHORISE_FAILED");

        public static readonly PaymentOrderInfoStatus CHARGED
            = new PaymentOrderInfoStatus("CHARGED");

        public static readonly PaymentOrderInfoStatus CHARGEFAILED
            = new PaymentOrderInfoStatus("CHARGE_FAILED");

        public static readonly PaymentOrderInfoStatus NOTIFICATIONOFCHARGEBACK
            = new PaymentOrderInfoStatus("NOTIFICATION_OF_CHARGEBACK");

        public static readonly PaymentOrderInfoStatus REQUESTFORINFORMATION
            = new PaymentOrderInfoStatus("REQUEST_FOR_INFORMATION");

        public static readonly PaymentOrderInfoStatus CHARGEBACK
            = new PaymentOrderInfoStatus("CHARGEBACK");

        public static readonly PaymentOrderInfoStatus CHARGEBACKREVERSED
            = new PaymentOrderInfoStatus("CHARGEBACK_REVERSED");

        public static readonly PaymentOrderInfoStatus REFUNDING
            = new PaymentOrderInfoStatus("REFUNDING");

        public static readonly PaymentOrderInfoStatus REFUNDED
            = new PaymentOrderInfoStatus("REFUNDED");

        public static readonly PaymentOrderInfoStatus REFUNDFAILED
            = new PaymentOrderInfoStatus("REFUND_FAILED");

        public static readonly PaymentOrderInfoStatus DELETED
            = new PaymentOrderInfoStatus("DELETED");


        public static implicit operator PaymentOrderInfoStatus(string value)
        {
            return Create(value);
        }

        public PaymentOrderInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}