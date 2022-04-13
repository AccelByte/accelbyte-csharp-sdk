// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class BillingAccount : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalData")]
        public AdditionalData? AdditionalData { get; set; }

        [JsonPropertyName("paymentMethod")]
        public string? PaymentMethod { get; set; }

        [JsonPropertyName("paymentProvider")]
        [JsonStringEnum]
        public BillingAccountPaymentProvider? PaymentProvider { get; set; }

    }

    public class BillingAccountPaymentProvider : StringEnum<BillingAccountPaymentProvider>
    {
        public static readonly BillingAccountPaymentProvider WALLET
            = new BillingAccountPaymentProvider("WALLET");

        public static readonly BillingAccountPaymentProvider XSOLLA
            = new BillingAccountPaymentProvider("XSOLLA");

        public static readonly BillingAccountPaymentProvider ADYEN
            = new BillingAccountPaymentProvider("ADYEN");

        public static readonly BillingAccountPaymentProvider STRIPE
            = new BillingAccountPaymentProvider("STRIPE");

        public static readonly BillingAccountPaymentProvider CHECKOUT
            = new BillingAccountPaymentProvider("CHECKOUT");

        public static readonly BillingAccountPaymentProvider ALIPAY
            = new BillingAccountPaymentProvider("ALIPAY");

        public static readonly BillingAccountPaymentProvider WXPAY
            = new BillingAccountPaymentProvider("WXPAY");

        public static readonly BillingAccountPaymentProvider PAYPAL
            = new BillingAccountPaymentProvider("PAYPAL");


        public static implicit operator BillingAccountPaymentProvider(string value)
        {
            return Create(value);
        }

        public BillingAccountPaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }    
}