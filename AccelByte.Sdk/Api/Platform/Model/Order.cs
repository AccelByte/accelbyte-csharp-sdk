// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class Order : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("chargebackReversedTime")]
        public DateTime? ChargebackReversedTime { get; set; }

        [JsonPropertyName("chargebackTime")]
        public DateTime? ChargebackTime { get; set; }

        [JsonPropertyName("charged")]
        public bool? Charged { get; set; }

        [JsonPropertyName("chargedTime")]
        public DateTime? ChargedTime { get; set; }

        [JsonPropertyName("countItemId")]
        public string? CountItemId { get; set; }

        [JsonPropertyName("countNamespace")]
        public string? CountNamespace { get; set; }

        [JsonPropertyName("countUserId")]
        public string? CountUserId { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("createdTime")]
        public DateTime? CreatedTime { get; set; }

        [JsonPropertyName("currency")]
        public CurrencySummary? Currency { get; set; }

        [JsonPropertyName("discountedPrice")]
        public int? DiscountedPrice { get; set; }

        [JsonPropertyName("expireTime")]
        public DateTime? ExpireTime { get; set; }

        [JsonPropertyName("ext")]
        public Dictionary<string, object>? Ext { get; set; }

        [JsonPropertyName("free")]
        public bool? Free { get; set; }

        [JsonPropertyName("fulfilledTime")]
        public DateTime? FulfilledTime { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemSnapshot")]
        public ItemSnapshot? ItemSnapshot { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("orderNo")]
        public string? OrderNo { get; set; }

        [JsonPropertyName("paymentMethod")]
        public string? PaymentMethod { get; set; }

        [JsonPropertyName("paymentMethodFee")]
        public int? PaymentMethodFee { get; set; }

        [JsonPropertyName("paymentOrderNo")]
        public string? PaymentOrderNo { get; set; }

        [JsonPropertyName("paymentProvider")]
        [JsonStringEnum]
        public OrderPaymentProvider? PaymentProvider { get; set; }

        [JsonPropertyName("paymentProviderFee")]
        public int? PaymentProviderFee { get; set; }

        [JsonPropertyName("paymentRemainSeconds")]
        public int? PaymentRemainSeconds { get; set; }

        [JsonPropertyName("paymentStationUrl")]
        public string? PaymentStationUrl { get; set; }

        [JsonPropertyName("price")]
        public int? Price { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

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

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public OrderStatus? Status { get; set; }

        [JsonPropertyName("statusReason")]
        public string? StatusReason { get; set; }

        [JsonPropertyName("subtotalPrice")]
        public int? SubtotalPrice { get; set; }

        [JsonPropertyName("tax")]
        public int? Tax { get; set; }

        [JsonPropertyName("totalPrice")]
        public int? TotalPrice { get; set; }

        [JsonPropertyName("totalTax")]
        public int? TotalTax { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

        [JsonPropertyName("vat")]
        public int? Vat { get; set; }

    }

    public class OrderPaymentProvider : StringEnum<OrderPaymentProvider>
    {
        public static readonly OrderPaymentProvider WALLET
            = new OrderPaymentProvider("WALLET");

        public static readonly OrderPaymentProvider XSOLLA
            = new OrderPaymentProvider("XSOLLA");

        public static readonly OrderPaymentProvider ADYEN
            = new OrderPaymentProvider("ADYEN");

        public static readonly OrderPaymentProvider STRIPE
            = new OrderPaymentProvider("STRIPE");

        public static readonly OrderPaymentProvider CHECKOUT
            = new OrderPaymentProvider("CHECKOUT");

        public static readonly OrderPaymentProvider ALIPAY
            = new OrderPaymentProvider("ALIPAY");

        public static readonly OrderPaymentProvider WXPAY
            = new OrderPaymentProvider("WXPAY");

        public static readonly OrderPaymentProvider PAYPAL
            = new OrderPaymentProvider("PAYPAL");


        public static implicit operator OrderPaymentProvider(string value)
        {
            return Create(value);
        }

        public OrderPaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class OrderStatus : StringEnum<OrderStatus>
    {
        public static readonly OrderStatus INIT
            = new OrderStatus("INIT");

        public static readonly OrderStatus CHARGED
            = new OrderStatus("CHARGED");

        public static readonly OrderStatus CHARGEBACK
            = new OrderStatus("CHARGEBACK");

        public static readonly OrderStatus CHARGEBACKREVERSED
            = new OrderStatus("CHARGEBACK_REVERSED");

        public static readonly OrderStatus FULFILLED
            = new OrderStatus("FULFILLED");

        public static readonly OrderStatus FULFILLFAILED
            = new OrderStatus("FULFILL_FAILED");

        public static readonly OrderStatus REFUNDING
            = new OrderStatus("REFUNDING");

        public static readonly OrderStatus REFUNDED
            = new OrderStatus("REFUNDED");

        public static readonly OrderStatus REFUNDFAILED
            = new OrderStatus("REFUND_FAILED");

        public static readonly OrderStatus CLOSED
            = new OrderStatus("CLOSED");

        public static readonly OrderStatus DELETED
            = new OrderStatus("DELETED");


        public static implicit operator OrderStatus(string value)
        {
            return Create(value);
        }

        public OrderStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}