// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentProviderConfigInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("aggregate")]
        [JsonStringEnum]
        public PaymentProviderConfigInfoAggregate? Aggregate { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("paymentMerchantConfigId")]
        public string? PaymentMerchantConfigId { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("sandboxTaxJarApiToken")]
        public string? SandboxTaxJarApiToken { get; set; }

        [JsonPropertyName("specials")]
        [JsonStringEnum]
        public List<PaymentProviderConfigInfoSpecials>? Specials { get; set; }

        [JsonPropertyName("taxJarApiToken")]
        public string? TaxJarApiToken { get; set; }

        [JsonPropertyName("taxJarEnabled")]
        public bool? TaxJarEnabled { get; set; }

        [JsonPropertyName("useGlobalTaxJarApiToken")]
        public bool? UseGlobalTaxJarApiToken { get; set; }

    }

    public class PaymentProviderConfigInfoAggregate : StringEnum<PaymentProviderConfigInfoAggregate>
    {
        public static readonly PaymentProviderConfigInfoAggregate XSOLLA
            = new PaymentProviderConfigInfoAggregate("XSOLLA");

        public static readonly PaymentProviderConfigInfoAggregate ADYEN
            = new PaymentProviderConfigInfoAggregate("ADYEN");


        public static implicit operator PaymentProviderConfigInfoAggregate(string value)
        {
            return Create(value);
        }

        public PaymentProviderConfigInfoAggregate(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class PaymentProviderConfigInfoSpecials : StringEnum<PaymentProviderConfigInfoSpecials>
    {
        public static readonly PaymentProviderConfigInfoSpecials WALLET
            = new PaymentProviderConfigInfoSpecials("WALLET");

        public static readonly PaymentProviderConfigInfoSpecials XSOLLA
            = new PaymentProviderConfigInfoSpecials("XSOLLA");

        public static readonly PaymentProviderConfigInfoSpecials ADYEN
            = new PaymentProviderConfigInfoSpecials("ADYEN");

        public static readonly PaymentProviderConfigInfoSpecials STRIPE
            = new PaymentProviderConfigInfoSpecials("STRIPE");

        public static readonly PaymentProviderConfigInfoSpecials CHECKOUT
            = new PaymentProviderConfigInfoSpecials("CHECKOUT");

        public static readonly PaymentProviderConfigInfoSpecials ALIPAY
            = new PaymentProviderConfigInfoSpecials("ALIPAY");

        public static readonly PaymentProviderConfigInfoSpecials WXPAY
            = new PaymentProviderConfigInfoSpecials("WXPAY");

        public static readonly PaymentProviderConfigInfoSpecials PAYPAL
            = new PaymentProviderConfigInfoSpecials("PAYPAL");


        public static implicit operator PaymentProviderConfigInfoSpecials(string value)
        {
            return Create(value);
        }

        public PaymentProviderConfigInfoSpecials(string enumValue)
            : base(enumValue)
        {

        }
    }    
}