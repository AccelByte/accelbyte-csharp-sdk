// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class OrderInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("chargebackReversedTime")]
        public DateTime? ChargebackReversedTime { get; set; }

        [JsonPropertyName("chargebackTime")]
        public DateTime? ChargebackTime { get; set; }

        [JsonPropertyName("chargedTime")]
        public DateTime? ChargedTime { get; set; }

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
        public OrderInfoPaymentProvider? PaymentProvider { get; set; }

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

        [JsonPropertyName("salesTax")]
        public int? SalesTax { get; set; }

        [JsonPropertyName("sandbox")]
        public bool? Sandbox { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public OrderInfoStatus? Status { get; set; }

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

    public class OrderInfoPaymentProvider : StringEnum<OrderInfoPaymentProvider>
    {
        public static readonly OrderInfoPaymentProvider WALLET
            = new OrderInfoPaymentProvider("WALLET");

        public static readonly OrderInfoPaymentProvider XSOLLA
            = new OrderInfoPaymentProvider("XSOLLA");

        public static readonly OrderInfoPaymentProvider ADYEN
            = new OrderInfoPaymentProvider("ADYEN");

        public static readonly OrderInfoPaymentProvider STRIPE
            = new OrderInfoPaymentProvider("STRIPE");

        public static readonly OrderInfoPaymentProvider CHECKOUT
            = new OrderInfoPaymentProvider("CHECKOUT");

        public static readonly OrderInfoPaymentProvider ALIPAY
            = new OrderInfoPaymentProvider("ALIPAY");

        public static readonly OrderInfoPaymentProvider WXPAY
            = new OrderInfoPaymentProvider("WXPAY");

        public static readonly OrderInfoPaymentProvider PAYPAL
            = new OrderInfoPaymentProvider("PAYPAL");


        public static implicit operator OrderInfoPaymentProvider(string value)
        {
            return Create(value);
        }

        public OrderInfoPaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class OrderInfoStatus : StringEnum<OrderInfoStatus>
    {
        public static readonly OrderInfoStatus INIT
            = new OrderInfoStatus("INIT");

        public static readonly OrderInfoStatus CHARGED
            = new OrderInfoStatus("CHARGED");

        public static readonly OrderInfoStatus CHARGEBACK
            = new OrderInfoStatus("CHARGEBACK");

        public static readonly OrderInfoStatus CHARGEBACKREVERSED
            = new OrderInfoStatus("CHARGEBACK_REVERSED");

        public static readonly OrderInfoStatus FULFILLED
            = new OrderInfoStatus("FULFILLED");

        public static readonly OrderInfoStatus FULFILLFAILED
            = new OrderInfoStatus("FULFILL_FAILED");

        public static readonly OrderInfoStatus REFUNDING
            = new OrderInfoStatus("REFUNDING");

        public static readonly OrderInfoStatus REFUNDED
            = new OrderInfoStatus("REFUNDED");

        public static readonly OrderInfoStatus REFUNDFAILED
            = new OrderInfoStatus("REFUND_FAILED");

        public static readonly OrderInfoStatus CLOSED
            = new OrderInfoStatus("CLOSED");

        public static readonly OrderInfoStatus DELETED
            = new OrderInfoStatus("DELETED");


        public static implicit operator OrderInfoStatus(string value)
        {
            return Create(value);
        }

        public OrderInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}