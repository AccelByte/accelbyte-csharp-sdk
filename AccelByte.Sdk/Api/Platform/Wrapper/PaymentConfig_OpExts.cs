// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformPaymentConfig_OpExts
    {
        public static Platform.Model.PaymentDomainWhitelistConfigInfo? Execute(
            this GetPaymentMerchantConfig.GetPaymentMerchantConfigBuilder builder,
            string namespace_
        )
        {
            GetPaymentMerchantConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).GetPaymentMerchantConfig(op);
        }
        public static async Task<Platform.Model.PaymentDomainWhitelistConfigInfo?> ExecuteAsync(
            this GetPaymentMerchantConfig.GetPaymentMerchantConfigBuilder builder,
            string namespace_
        )
        {
            GetPaymentMerchantConfig op = builder.Build(
                namespace_
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).GetPaymentMerchantConfigAsync(op);
        }
        public static Platform.Model.PaymentDomainWhitelistConfigInfo? Execute(
            this UpdatePaymentDomainWhitelistConfig.UpdatePaymentDomainWhitelistConfigBuilder builder,
            string namespace_
        )
        {
            UpdatePaymentDomainWhitelistConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdatePaymentDomainWhitelistConfig(op);
        }
        public static async Task<Platform.Model.PaymentDomainWhitelistConfigInfo?> ExecuteAsync(
            this UpdatePaymentDomainWhitelistConfig.UpdatePaymentDomainWhitelistConfigBuilder builder,
            string namespace_
        )
        {
            UpdatePaymentDomainWhitelistConfig op = builder.Build(
                namespace_
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdatePaymentDomainWhitelistConfigAsync(op);
        }
        public static Platform.Model.TestResult? Execute(
            this TestAdyenConfig.TestAdyenConfigBuilder builder
        )
        {
            TestAdyenConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestAdyenConfig(op);
        }
        public static async Task<Platform.Model.TestResult?> ExecuteAsync(
            this TestAdyenConfig.TestAdyenConfigBuilder builder
        )
        {
            TestAdyenConfig op = builder.Build(
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestAdyenConfigAsync(op);
        }
        public static Platform.Model.TestResult? Execute(
            this TestAliPayConfig.TestAliPayConfigBuilder builder
        )
        {
            TestAliPayConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestAliPayConfig(op);
        }
        public static async Task<Platform.Model.TestResult?> ExecuteAsync(
            this TestAliPayConfig.TestAliPayConfigBuilder builder
        )
        {
            TestAliPayConfig op = builder.Build(
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestAliPayConfigAsync(op);
        }
        public static Platform.Model.TestResult? Execute(
            this TestCheckoutConfig.TestCheckoutConfigBuilder builder
        )
        {
            TestCheckoutConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestCheckoutConfig(op);
        }
        public static async Task<Platform.Model.TestResult?> ExecuteAsync(
            this TestCheckoutConfig.TestCheckoutConfigBuilder builder
        )
        {
            TestCheckoutConfig op = builder.Build(
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestCheckoutConfigAsync(op);
        }
        public static Platform.Model.PaymentMerchantConfigInfo? Execute(
            this DebugMatchedPaymentMerchantConfig.DebugMatchedPaymentMerchantConfigBuilder builder
        )
        {
            DebugMatchedPaymentMerchantConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).DebugMatchedPaymentMerchantConfig(op);
        }
        public static async Task<Platform.Model.PaymentMerchantConfigInfo?> ExecuteAsync(
            this DebugMatchedPaymentMerchantConfig.DebugMatchedPaymentMerchantConfigBuilder builder
        )
        {
            DebugMatchedPaymentMerchantConfig op = builder.Build(
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).DebugMatchedPaymentMerchantConfigAsync(op);
        }
        public static Platform.Model.TestResult? Execute(
            this TestNeonPayConfig.TestNeonPayConfigBuilder builder
        )
        {
            TestNeonPayConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestNeonPayConfig(op);
        }
        public static async Task<Platform.Model.TestResult?> ExecuteAsync(
            this TestNeonPayConfig.TestNeonPayConfigBuilder builder
        )
        {
            TestNeonPayConfig op = builder.Build(
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestNeonPayConfigAsync(op);
        }
        public static Platform.Model.TestResult? Execute(
            this TestPayPalConfig.TestPayPalConfigBuilder builder
        )
        {
            TestPayPalConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestPayPalConfig(op);
        }
        public static async Task<Platform.Model.TestResult?> ExecuteAsync(
            this TestPayPalConfig.TestPayPalConfigBuilder builder
        )
        {
            TestPayPalConfig op = builder.Build(
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestPayPalConfigAsync(op);
        }
        public static Platform.Model.TestResult? Execute(
            this TestStripeConfig.TestStripeConfigBuilder builder
        )
        {
            TestStripeConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestStripeConfig(op);
        }
        public static async Task<Platform.Model.TestResult?> ExecuteAsync(
            this TestStripeConfig.TestStripeConfigBuilder builder
        )
        {
            TestStripeConfig op = builder.Build(
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestStripeConfigAsync(op);
        }
        public static Platform.Model.TestResult? Execute(
            this TestWxPayConfig.TestWxPayConfigBuilder builder
        )
        {
            TestWxPayConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestWxPayConfig(op);
        }
        public static async Task<Platform.Model.TestResult?> ExecuteAsync(
            this TestWxPayConfig.TestWxPayConfigBuilder builder
        )
        {
            TestWxPayConfig op = builder.Build(
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestWxPayConfigAsync(op);
        }
        public static Platform.Model.TestResult? Execute(
            this TestXsollaConfig.TestXsollaConfigBuilder builder
        )
        {
            TestXsollaConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestXsollaConfig(op);
        }
        public static async Task<Platform.Model.TestResult?> ExecuteAsync(
            this TestXsollaConfig.TestXsollaConfigBuilder builder
        )
        {
            TestXsollaConfig op = builder.Build(
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestXsollaConfigAsync(op);
        }
        public static Platform.Model.PaymentMerchantConfigInfo? Execute(
            this GetPaymentMerchantConfig1.GetPaymentMerchantConfig1Builder builder,
            string id
        )
        {
            GetPaymentMerchantConfig1 op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).GetPaymentMerchantConfig1(op);
        }
        public static async Task<Platform.Model.PaymentMerchantConfigInfo?> ExecuteAsync(
            this GetPaymentMerchantConfig1.GetPaymentMerchantConfig1Builder builder,
            string id
        )
        {
            GetPaymentMerchantConfig1 op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).GetPaymentMerchantConfig1Async(op);
        }
        public static Platform.Model.PaymentMerchantConfigInfo? Execute(
            this UpdateAdyenConfig.UpdateAdyenConfigBuilder builder,
            string id
        )
        {
            UpdateAdyenConfig op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdateAdyenConfig(op);
        }
        public static async Task<Platform.Model.PaymentMerchantConfigInfo?> ExecuteAsync(
            this UpdateAdyenConfig.UpdateAdyenConfigBuilder builder,
            string id
        )
        {
            UpdateAdyenConfig op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdateAdyenConfigAsync(op);
        }
        public static Platform.Model.TestResult? Execute(
            this TestAdyenConfigById.TestAdyenConfigByIdBuilder builder,
            string id
        )
        {
            TestAdyenConfigById op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestAdyenConfigById(op);
        }
        public static async Task<Platform.Model.TestResult?> ExecuteAsync(
            this TestAdyenConfigById.TestAdyenConfigByIdBuilder builder,
            string id
        )
        {
            TestAdyenConfigById op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestAdyenConfigByIdAsync(op);
        }
        public static Platform.Model.PaymentMerchantConfigInfo? Execute(
            this UpdateAliPayConfig.UpdateAliPayConfigBuilder builder,
            string id
        )
        {
            UpdateAliPayConfig op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdateAliPayConfig(op);
        }
        public static async Task<Platform.Model.PaymentMerchantConfigInfo?> ExecuteAsync(
            this UpdateAliPayConfig.UpdateAliPayConfigBuilder builder,
            string id
        )
        {
            UpdateAliPayConfig op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdateAliPayConfigAsync(op);
        }
        public static Platform.Model.TestResult? Execute(
            this TestAliPayConfigById.TestAliPayConfigByIdBuilder builder,
            string id
        )
        {
            TestAliPayConfigById op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestAliPayConfigById(op);
        }
        public static async Task<Platform.Model.TestResult?> ExecuteAsync(
            this TestAliPayConfigById.TestAliPayConfigByIdBuilder builder,
            string id
        )
        {
            TestAliPayConfigById op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestAliPayConfigByIdAsync(op);
        }
        public static Platform.Model.PaymentMerchantConfigInfo? Execute(
            this UpdateCheckoutConfig.UpdateCheckoutConfigBuilder builder,
            string id
        )
        {
            UpdateCheckoutConfig op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdateCheckoutConfig(op);
        }
        public static async Task<Platform.Model.PaymentMerchantConfigInfo?> ExecuteAsync(
            this UpdateCheckoutConfig.UpdateCheckoutConfigBuilder builder,
            string id
        )
        {
            UpdateCheckoutConfig op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdateCheckoutConfigAsync(op);
        }
        public static Platform.Model.TestResult? Execute(
            this TestCheckoutConfigById.TestCheckoutConfigByIdBuilder builder,
            string id
        )
        {
            TestCheckoutConfigById op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestCheckoutConfigById(op);
        }
        public static async Task<Platform.Model.TestResult?> ExecuteAsync(
            this TestCheckoutConfigById.TestCheckoutConfigByIdBuilder builder,
            string id
        )
        {
            TestCheckoutConfigById op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestCheckoutConfigByIdAsync(op);
        }
        public static Platform.Model.PaymentMerchantConfigInfo? Execute(
            this UpdateNeonPayConfig.UpdateNeonPayConfigBuilder builder,
            string id
        )
        {
            UpdateNeonPayConfig op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdateNeonPayConfig(op);
        }
        public static async Task<Platform.Model.PaymentMerchantConfigInfo?> ExecuteAsync(
            this UpdateNeonPayConfig.UpdateNeonPayConfigBuilder builder,
            string id
        )
        {
            UpdateNeonPayConfig op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdateNeonPayConfigAsync(op);
        }
        public static Platform.Model.TestResult? Execute(
            this TestNeonPayConfigById.TestNeonPayConfigByIdBuilder builder,
            string id
        )
        {
            TestNeonPayConfigById op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestNeonPayConfigById(op);
        }
        public static async Task<Platform.Model.TestResult?> ExecuteAsync(
            this TestNeonPayConfigById.TestNeonPayConfigByIdBuilder builder,
            string id
        )
        {
            TestNeonPayConfigById op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestNeonPayConfigByIdAsync(op);
        }
        public static Platform.Model.PaymentMerchantConfigInfo? Execute(
            this UpdatePayPalConfig.UpdatePayPalConfigBuilder builder,
            string id
        )
        {
            UpdatePayPalConfig op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdatePayPalConfig(op);
        }
        public static async Task<Platform.Model.PaymentMerchantConfigInfo?> ExecuteAsync(
            this UpdatePayPalConfig.UpdatePayPalConfigBuilder builder,
            string id
        )
        {
            UpdatePayPalConfig op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdatePayPalConfigAsync(op);
        }
        public static Platform.Model.TestResult? Execute(
            this TestPayPalConfigById.TestPayPalConfigByIdBuilder builder,
            string id
        )
        {
            TestPayPalConfigById op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestPayPalConfigById(op);
        }
        public static async Task<Platform.Model.TestResult?> ExecuteAsync(
            this TestPayPalConfigById.TestPayPalConfigByIdBuilder builder,
            string id
        )
        {
            TestPayPalConfigById op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestPayPalConfigByIdAsync(op);
        }
        public static Platform.Model.PaymentMerchantConfigInfo? Execute(
            this UpdateStripeConfig.UpdateStripeConfigBuilder builder,
            string id
        )
        {
            UpdateStripeConfig op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdateStripeConfig(op);
        }
        public static async Task<Platform.Model.PaymentMerchantConfigInfo?> ExecuteAsync(
            this UpdateStripeConfig.UpdateStripeConfigBuilder builder,
            string id
        )
        {
            UpdateStripeConfig op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdateStripeConfigAsync(op);
        }
        public static Platform.Model.TestResult? Execute(
            this TestStripeConfigById.TestStripeConfigByIdBuilder builder,
            string id
        )
        {
            TestStripeConfigById op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestStripeConfigById(op);
        }
        public static async Task<Platform.Model.TestResult?> ExecuteAsync(
            this TestStripeConfigById.TestStripeConfigByIdBuilder builder,
            string id
        )
        {
            TestStripeConfigById op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestStripeConfigByIdAsync(op);
        }
        public static Platform.Model.PaymentMerchantConfigInfo? Execute(
            this UpdateWxPayConfig.UpdateWxPayConfigBuilder builder,
            string id
        )
        {
            UpdateWxPayConfig op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdateWxPayConfig(op);
        }
        public static async Task<Platform.Model.PaymentMerchantConfigInfo?> ExecuteAsync(
            this UpdateWxPayConfig.UpdateWxPayConfigBuilder builder,
            string id
        )
        {
            UpdateWxPayConfig op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdateWxPayConfigAsync(op);
        }
        public static Platform.Model.PaymentMerchantConfigInfo? Execute(
            this UpdateWxPayConfigCert.UpdateWxPayConfigCertBuilder builder,
            string id
        )
        {
            UpdateWxPayConfigCert op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdateWxPayConfigCert(op);
        }
        public static async Task<Platform.Model.PaymentMerchantConfigInfo?> ExecuteAsync(
            this UpdateWxPayConfigCert.UpdateWxPayConfigCertBuilder builder,
            string id
        )
        {
            UpdateWxPayConfigCert op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdateWxPayConfigCertAsync(op);
        }
        public static Platform.Model.TestResult? Execute(
            this TestWxPayConfigById.TestWxPayConfigByIdBuilder builder,
            string id
        )
        {
            TestWxPayConfigById op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestWxPayConfigById(op);
        }
        public static async Task<Platform.Model.TestResult?> ExecuteAsync(
            this TestWxPayConfigById.TestWxPayConfigByIdBuilder builder,
            string id
        )
        {
            TestWxPayConfigById op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestWxPayConfigByIdAsync(op);
        }
        public static Platform.Model.PaymentMerchantConfigInfo? Execute(
            this UpdateXsollaConfig.UpdateXsollaConfigBuilder builder,
            string id
        )
        {
            UpdateXsollaConfig op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdateXsollaConfig(op);
        }
        public static async Task<Platform.Model.PaymentMerchantConfigInfo?> ExecuteAsync(
            this UpdateXsollaConfig.UpdateXsollaConfigBuilder builder,
            string id
        )
        {
            UpdateXsollaConfig op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdateXsollaConfigAsync(op);
        }
        public static Platform.Model.TestResult? Execute(
            this TestXsollaConfigById.TestXsollaConfigByIdBuilder builder,
            string id
        )
        {
            TestXsollaConfigById op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestXsollaConfigById(op);
        }
        public static async Task<Platform.Model.TestResult?> ExecuteAsync(
            this TestXsollaConfigById.TestXsollaConfigByIdBuilder builder,
            string id
        )
        {
            TestXsollaConfigById op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestXsollaConfigByIdAsync(op);
        }
        public static Platform.Model.PaymentMerchantConfigInfo? Execute(
            this UpdateXsollaUIConfig.UpdateXsollaUIConfigBuilder builder,
            string id
        )
        {
            UpdateXsollaUIConfig op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdateXsollaUIConfig(op);
        }
        public static async Task<Platform.Model.PaymentMerchantConfigInfo?> ExecuteAsync(
            this UpdateXsollaUIConfig.UpdateXsollaUIConfigBuilder builder,
            string id
        )
        {
            UpdateXsollaUIConfig op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdateXsollaUIConfigAsync(op);
        }
        public static Platform.Model.PaymentProviderConfigPagingSlicedResult? Execute(
            this QueryPaymentProviderConfig.QueryPaymentProviderConfigBuilder builder
        )
        {
            QueryPaymentProviderConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).QueryPaymentProviderConfig(op);
        }
        public static async Task<Platform.Model.PaymentProviderConfigPagingSlicedResult?> ExecuteAsync(
            this QueryPaymentProviderConfig.QueryPaymentProviderConfigBuilder builder
        )
        {
            QueryPaymentProviderConfig op = builder.Build(
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).QueryPaymentProviderConfigAsync(op);
        }
        public static Platform.Model.PaymentProviderConfigInfo? Execute(
            this CreatePaymentProviderConfig.CreatePaymentProviderConfigBuilder builder
        )
        {
            CreatePaymentProviderConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).CreatePaymentProviderConfig(op);
        }
        public static async Task<Platform.Model.PaymentProviderConfigInfo?> ExecuteAsync(
            this CreatePaymentProviderConfig.CreatePaymentProviderConfigBuilder builder
        )
        {
            CreatePaymentProviderConfig op = builder.Build(
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).CreatePaymentProviderConfigAsync(op);
        }
        public static List<string>? Execute(
            this GetAggregatePaymentProviders.GetAggregatePaymentProvidersBuilder builder
        )
        {
            GetAggregatePaymentProviders op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).GetAggregatePaymentProviders(op);
        }
        public static async Task<List<string>?> ExecuteAsync(
            this GetAggregatePaymentProviders.GetAggregatePaymentProvidersBuilder builder
        )
        {
            GetAggregatePaymentProviders op = builder.Build(
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).GetAggregatePaymentProvidersAsync(op);
        }
        public static Platform.Model.PaymentProviderConfigInfo? Execute(
            this DebugMatchedPaymentProviderConfig.DebugMatchedPaymentProviderConfigBuilder builder
        )
        {
            DebugMatchedPaymentProviderConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).DebugMatchedPaymentProviderConfig(op);
        }
        public static async Task<Platform.Model.PaymentProviderConfigInfo?> ExecuteAsync(
            this DebugMatchedPaymentProviderConfig.DebugMatchedPaymentProviderConfigBuilder builder
        )
        {
            DebugMatchedPaymentProviderConfig op = builder.Build(
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).DebugMatchedPaymentProviderConfigAsync(op);
        }
        public static List<string>? Execute(
            this GetSpecialPaymentProviders.GetSpecialPaymentProvidersBuilder builder
        )
        {
            GetSpecialPaymentProviders op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).GetSpecialPaymentProviders(op);
        }
        public static async Task<List<string>?> ExecuteAsync(
            this GetSpecialPaymentProviders.GetSpecialPaymentProvidersBuilder builder
        )
        {
            GetSpecialPaymentProviders op = builder.Build(
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).GetSpecialPaymentProvidersAsync(op);
        }
        public static Platform.Model.PaymentProviderConfigInfo? Execute(
            this UpdatePaymentProviderConfig.UpdatePaymentProviderConfigBuilder builder,
            string id
        )
        {
            UpdatePaymentProviderConfig op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdatePaymentProviderConfig(op);
        }
        public static async Task<Platform.Model.PaymentProviderConfigInfo?> ExecuteAsync(
            this UpdatePaymentProviderConfig.UpdatePaymentProviderConfigBuilder builder,
            string id
        )
        {
            UpdatePaymentProviderConfig op = builder.Build(
                id
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdatePaymentProviderConfigAsync(op);
        }
        public static void Execute(
            this DeletePaymentProviderConfig.DeletePaymentProviderConfigBuilder builder,
            string id
        )
        {
            DeletePaymentProviderConfig op = builder.Build(
                id
            );

            ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).DeletePaymentProviderConfig(op);
        }
        public static async Task ExecuteAsync(
            this DeletePaymentProviderConfig.DeletePaymentProviderConfigBuilder builder,
            string id
        )
        {
            DeletePaymentProviderConfig op = builder.Build(
                id
            );

            await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).DeletePaymentProviderConfigAsync(op);
        }
        public static Platform.Model.PaymentTaxConfigInfo? Execute(
            this GetPaymentTaxConfig.GetPaymentTaxConfigBuilder builder
        )
        {
            GetPaymentTaxConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).GetPaymentTaxConfig(op);
        }
        public static async Task<Platform.Model.PaymentTaxConfigInfo?> ExecuteAsync(
            this GetPaymentTaxConfig.GetPaymentTaxConfigBuilder builder
        )
        {
            GetPaymentTaxConfig op = builder.Build(
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).GetPaymentTaxConfigAsync(op);
        }
        public static Platform.Model.PaymentTaxConfigInfo? Execute(
            this UpdatePaymentTaxConfig.UpdatePaymentTaxConfigBuilder builder
        )
        {
            UpdatePaymentTaxConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdatePaymentTaxConfig(op);
        }
        public static async Task<Platform.Model.PaymentTaxConfigInfo?> ExecuteAsync(
            this UpdatePaymentTaxConfig.UpdatePaymentTaxConfigBuilder builder
        )
        {
            UpdatePaymentTaxConfig op = builder.Build(
            );

            return await ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdatePaymentTaxConfigAsync(op);
        }
    }
}