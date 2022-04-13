// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentOrderChargeRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("extTxId")]
        public string? ExtTxId { get; set; }

        [JsonPropertyName("paymentMethod")]
        public string? PaymentMethod { get; set; }

        [JsonPropertyName("paymentProvider")]
        [JsonStringEnum]
        public PaymentOrderChargeRequestPaymentProvider? PaymentProvider { get; set; }

    }

    public class PaymentOrderChargeRequestPaymentProvider : StringEnum<PaymentOrderChargeRequestPaymentProvider>
    {
        public static readonly PaymentOrderChargeRequestPaymentProvider WALLET
            = new PaymentOrderChargeRequestPaymentProvider("WALLET");

        public static readonly PaymentOrderChargeRequestPaymentProvider XSOLLA
            = new PaymentOrderChargeRequestPaymentProvider("XSOLLA");

        public static readonly PaymentOrderChargeRequestPaymentProvider ADYEN
            = new PaymentOrderChargeRequestPaymentProvider("ADYEN");

        public static readonly PaymentOrderChargeRequestPaymentProvider STRIPE
            = new PaymentOrderChargeRequestPaymentProvider("STRIPE");

        public static readonly PaymentOrderChargeRequestPaymentProvider CHECKOUT
            = new PaymentOrderChargeRequestPaymentProvider("CHECKOUT");

        public static readonly PaymentOrderChargeRequestPaymentProvider ALIPAY
            = new PaymentOrderChargeRequestPaymentProvider("ALIPAY");

        public static readonly PaymentOrderChargeRequestPaymentProvider WXPAY
            = new PaymentOrderChargeRequestPaymentProvider("WXPAY");

        public static readonly PaymentOrderChargeRequestPaymentProvider PAYPAL
            = new PaymentOrderChargeRequestPaymentProvider("PAYPAL");


        public static implicit operator PaymentOrderChargeRequestPaymentProvider(string value)
        {
            return Create(value);
        }

        public PaymentOrderChargeRequestPaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }    
}