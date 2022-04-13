// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentMethod : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("paymentProvider")]
        [JsonStringEnum]
        public PaymentMethodPaymentProvider? PaymentProvider { get; set; }

    }

    public class PaymentMethodPaymentProvider : StringEnum<PaymentMethodPaymentProvider>
    {
        public static readonly PaymentMethodPaymentProvider WALLET
            = new PaymentMethodPaymentProvider("WALLET");

        public static readonly PaymentMethodPaymentProvider XSOLLA
            = new PaymentMethodPaymentProvider("XSOLLA");

        public static readonly PaymentMethodPaymentProvider ADYEN
            = new PaymentMethodPaymentProvider("ADYEN");

        public static readonly PaymentMethodPaymentProvider STRIPE
            = new PaymentMethodPaymentProvider("STRIPE");

        public static readonly PaymentMethodPaymentProvider CHECKOUT
            = new PaymentMethodPaymentProvider("CHECKOUT");

        public static readonly PaymentMethodPaymentProvider ALIPAY
            = new PaymentMethodPaymentProvider("ALIPAY");

        public static readonly PaymentMethodPaymentProvider WXPAY
            = new PaymentMethodPaymentProvider("WXPAY");

        public static readonly PaymentMethodPaymentProvider PAYPAL
            = new PaymentMethodPaymentProvider("PAYPAL");


        public static implicit operator PaymentMethodPaymentProvider(string value)
        {
            return Create(value);
        }

        public PaymentMethodPaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }    
}