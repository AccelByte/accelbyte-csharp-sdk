// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentUrlCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("paymentOrderNo")]
        public string? PaymentOrderNo { get; set; }

        [JsonPropertyName("paymentProvider")]
        [JsonStringEnum]
        public PaymentUrlCreatePaymentProvider? PaymentProvider { get; set; }

        [JsonPropertyName("returnUrl")]
        public string? ReturnUrl { get; set; }

        [JsonPropertyName("ui")]
        public string? Ui { get; set; }

        [JsonPropertyName("zipCode")]
        public string? ZipCode { get; set; }

    }

    public class PaymentUrlCreatePaymentProvider : StringEnum<PaymentUrlCreatePaymentProvider>
    {
        public static readonly PaymentUrlCreatePaymentProvider WALLET
            = new PaymentUrlCreatePaymentProvider("WALLET");

        public static readonly PaymentUrlCreatePaymentProvider XSOLLA
            = new PaymentUrlCreatePaymentProvider("XSOLLA");

        public static readonly PaymentUrlCreatePaymentProvider ADYEN
            = new PaymentUrlCreatePaymentProvider("ADYEN");

        public static readonly PaymentUrlCreatePaymentProvider STRIPE
            = new PaymentUrlCreatePaymentProvider("STRIPE");

        public static readonly PaymentUrlCreatePaymentProvider CHECKOUT
            = new PaymentUrlCreatePaymentProvider("CHECKOUT");

        public static readonly PaymentUrlCreatePaymentProvider ALIPAY
            = new PaymentUrlCreatePaymentProvider("ALIPAY");

        public static readonly PaymentUrlCreatePaymentProvider WXPAY
            = new PaymentUrlCreatePaymentProvider("WXPAY");

        public static readonly PaymentUrlCreatePaymentProvider PAYPAL
            = new PaymentUrlCreatePaymentProvider("PAYPAL");


        public static implicit operator PaymentUrlCreatePaymentProvider(string value)
        {
            return Create(value);
        }

        public PaymentUrlCreatePaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }    
}