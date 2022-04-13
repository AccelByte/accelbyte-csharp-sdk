// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentOrder : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("authorisedTime")]
        public DateTime? AuthorisedTime { get; set; }

        [JsonPropertyName("channel")]
        [JsonStringEnum]
        public PaymentOrderChannel? Channel { get; set; }

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
        public PaymentOrderItemType? ItemType { get; set; }

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
        public PaymentOrderPaymentProvider? PaymentProvider { get; set; }

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

        [JsonPropertyName("rvn")]
        public int? Rvn { get; set; }

        [JsonPropertyName("salesTax")]
        public int? SalesTax { get; set; }

        [JsonPropertyName("sandbox")]
        public bool? Sandbox { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("state")]
        public string? State { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public PaymentOrderStatus? Status { get; set; }

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

        [JsonPropertyName("zipCode")]
        public string? ZipCode { get; set; }

    }

    public class PaymentOrderChannel : StringEnum<PaymentOrderChannel>
    {
        public static readonly PaymentOrderChannel EXTERNAL
            = new PaymentOrderChannel("EXTERNAL");

        public static readonly PaymentOrderChannel INTERNAL
            = new PaymentOrderChannel("INTERNAL");


        public static implicit operator PaymentOrderChannel(string value)
        {
            return Create(value);
        }

        public PaymentOrderChannel(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class PaymentOrderItemType : StringEnum<PaymentOrderItemType>
    {
        public static readonly PaymentOrderItemType APP
            = new PaymentOrderItemType("APP");

        public static readonly PaymentOrderItemType COINS
            = new PaymentOrderItemType("COINS");

        public static readonly PaymentOrderItemType INGAMEITEM
            = new PaymentOrderItemType("INGAMEITEM");

        public static readonly PaymentOrderItemType BUNDLE
            = new PaymentOrderItemType("BUNDLE");

        public static readonly PaymentOrderItemType CODE
            = new PaymentOrderItemType("CODE");

        public static readonly PaymentOrderItemType SUBSCRIPTION
            = new PaymentOrderItemType("SUBSCRIPTION");

        public static readonly PaymentOrderItemType SEASON
            = new PaymentOrderItemType("SEASON");

        public static readonly PaymentOrderItemType MEDIA
            = new PaymentOrderItemType("MEDIA");


        public static implicit operator PaymentOrderItemType(string value)
        {
            return Create(value);
        }

        public PaymentOrderItemType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class PaymentOrderPaymentProvider : StringEnum<PaymentOrderPaymentProvider>
    {
        public static readonly PaymentOrderPaymentProvider WALLET
            = new PaymentOrderPaymentProvider("WALLET");

        public static readonly PaymentOrderPaymentProvider XSOLLA
            = new PaymentOrderPaymentProvider("XSOLLA");

        public static readonly PaymentOrderPaymentProvider ADYEN
            = new PaymentOrderPaymentProvider("ADYEN");

        public static readonly PaymentOrderPaymentProvider STRIPE
            = new PaymentOrderPaymentProvider("STRIPE");

        public static readonly PaymentOrderPaymentProvider CHECKOUT
            = new PaymentOrderPaymentProvider("CHECKOUT");

        public static readonly PaymentOrderPaymentProvider ALIPAY
            = new PaymentOrderPaymentProvider("ALIPAY");

        public static readonly PaymentOrderPaymentProvider WXPAY
            = new PaymentOrderPaymentProvider("WXPAY");

        public static readonly PaymentOrderPaymentProvider PAYPAL
            = new PaymentOrderPaymentProvider("PAYPAL");


        public static implicit operator PaymentOrderPaymentProvider(string value)
        {
            return Create(value);
        }

        public PaymentOrderPaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class PaymentOrderStatus : StringEnum<PaymentOrderStatus>
    {
        public static readonly PaymentOrderStatus INIT
            = new PaymentOrderStatus("INIT");

        public static readonly PaymentOrderStatus AUTHORISED
            = new PaymentOrderStatus("AUTHORISED");

        public static readonly PaymentOrderStatus AUTHORISEFAILED
            = new PaymentOrderStatus("AUTHORISE_FAILED");

        public static readonly PaymentOrderStatus CHARGED
            = new PaymentOrderStatus("CHARGED");

        public static readonly PaymentOrderStatus CHARGEFAILED
            = new PaymentOrderStatus("CHARGE_FAILED");

        public static readonly PaymentOrderStatus NOTIFICATIONOFCHARGEBACK
            = new PaymentOrderStatus("NOTIFICATION_OF_CHARGEBACK");

        public static readonly PaymentOrderStatus REQUESTFORINFORMATION
            = new PaymentOrderStatus("REQUEST_FOR_INFORMATION");

        public static readonly PaymentOrderStatus CHARGEBACK
            = new PaymentOrderStatus("CHARGEBACK");

        public static readonly PaymentOrderStatus CHARGEBACKREVERSED
            = new PaymentOrderStatus("CHARGEBACK_REVERSED");

        public static readonly PaymentOrderStatus REFUNDING
            = new PaymentOrderStatus("REFUNDING");

        public static readonly PaymentOrderStatus REFUNDED
            = new PaymentOrderStatus("REFUNDED");

        public static readonly PaymentOrderStatus REFUNDFAILED
            = new PaymentOrderStatus("REFUND_FAILED");

        public static readonly PaymentOrderStatus DELETED
            = new PaymentOrderStatus("DELETED");


        public static implicit operator PaymentOrderStatus(string value)
        {
            return Create(value);
        }

        public PaymentOrderStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}