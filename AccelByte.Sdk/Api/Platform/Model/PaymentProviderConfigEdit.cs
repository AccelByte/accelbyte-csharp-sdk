// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentProviderConfigEdit : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("aggregate")]
        [JsonStringEnum]
        public PaymentProviderConfigEditAggregate? Aggregate { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("sandboxTaxJarApiToken")]
        public string? SandboxTaxJarApiToken { get; set; }

        [JsonPropertyName("specials")]
        [JsonStringEnum]
        public List<PaymentProviderConfigEditSpecials>? Specials { get; set; }

        [JsonPropertyName("taxJarApiToken")]
        public string? TaxJarApiToken { get; set; }

        [JsonPropertyName("taxJarEnabled")]
        public bool? TaxJarEnabled { get; set; }

        [JsonPropertyName("useGlobalTaxJarApiToken")]
        public bool? UseGlobalTaxJarApiToken { get; set; }

    }

    public class PaymentProviderConfigEditAggregate : StringEnum<PaymentProviderConfigEditAggregate>
    {
        public static readonly PaymentProviderConfigEditAggregate XSOLLA
            = new PaymentProviderConfigEditAggregate("XSOLLA");

        public static readonly PaymentProviderConfigEditAggregate ADYEN
            = new PaymentProviderConfigEditAggregate("ADYEN");


        public static implicit operator PaymentProviderConfigEditAggregate(string value)
        {
            return Create(value);
        }

        public PaymentProviderConfigEditAggregate(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class PaymentProviderConfigEditSpecials : StringEnum<PaymentProviderConfigEditSpecials>
    {
        public static readonly PaymentProviderConfigEditSpecials WALLET
            = new PaymentProviderConfigEditSpecials("WALLET");

        public static readonly PaymentProviderConfigEditSpecials XSOLLA
            = new PaymentProviderConfigEditSpecials("XSOLLA");

        public static readonly PaymentProviderConfigEditSpecials ADYEN
            = new PaymentProviderConfigEditSpecials("ADYEN");

        public static readonly PaymentProviderConfigEditSpecials STRIPE
            = new PaymentProviderConfigEditSpecials("STRIPE");

        public static readonly PaymentProviderConfigEditSpecials CHECKOUT
            = new PaymentProviderConfigEditSpecials("CHECKOUT");

        public static readonly PaymentProviderConfigEditSpecials ALIPAY
            = new PaymentProviderConfigEditSpecials("ALIPAY");

        public static readonly PaymentProviderConfigEditSpecials WXPAY
            = new PaymentProviderConfigEditSpecials("WXPAY");

        public static readonly PaymentProviderConfigEditSpecials PAYPAL
            = new PaymentProviderConfigEditSpecials("PAYPAL");


        public static implicit operator PaymentProviderConfigEditSpecials(string value)
        {
            return Create(value);
        }

        public PaymentProviderConfigEditSpecials(string enumValue)
            : base(enumValue)
        {

        }
    }    
}