// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformPaymentConfig_OpExts
    {
        public static Platform.Model.TestResult? Execute(
            this TestAdyenConfig.TestAdyenConfigBuilder builder
        )
        {
            TestAdyenConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestAdyenConfig(op);
        }

        public static Platform.Model.TestResult? Execute(
            this TestAliPayConfig.TestAliPayConfigBuilder builder
        )
        {
            TestAliPayConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestAliPayConfig(op);
        }

        public static Platform.Model.TestResult? Execute(
            this TestCheckoutConfig.TestCheckoutConfigBuilder builder
        )
        {
            TestCheckoutConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestCheckoutConfig(op);
        }

        public static Platform.Model.PaymentMerchantConfigInfo? Execute(
            this DebugMatchedPaymentMerchantConfig.DebugMatchedPaymentMerchantConfigBuilder builder
        )
        {
            DebugMatchedPaymentMerchantConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).DebugMatchedPaymentMerchantConfig(op);
        }

        public static Platform.Model.TestResult? Execute(
            this TestPayPalConfig.TestPayPalConfigBuilder builder
        )
        {
            TestPayPalConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestPayPalConfig(op);
        }

        public static Platform.Model.TestResult? Execute(
            this TestStripeConfig.TestStripeConfigBuilder builder
        )
        {
            TestStripeConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestStripeConfig(op);
        }

        public static Platform.Model.TestResult? Execute(
            this TestWxPayConfig.TestWxPayConfigBuilder builder
        )
        {
            TestWxPayConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestWxPayConfig(op);
        }

        public static Platform.Model.TestResult? Execute(
            this TestXsollaConfig.TestXsollaConfigBuilder builder
        )
        {
            TestXsollaConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).TestXsollaConfig(op);
        }

        public static Platform.Model.PaymentMerchantConfigInfo? Execute(
            this GetPaymentMerchantConfig.GetPaymentMerchantConfigBuilder builder,
            string id
        )
        {
            GetPaymentMerchantConfig op = builder.Build(
                id
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).GetPaymentMerchantConfig(op);
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

        public static Platform.Model.PaymentProviderConfigPagingSlicedResult? Execute(
            this QueryPaymentProviderConfig.QueryPaymentProviderConfigBuilder builder
        )
        {
            QueryPaymentProviderConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).QueryPaymentProviderConfig(op);
        }

        public static Platform.Model.PaymentProviderConfigInfo? Execute(
            this CreatePaymentProviderConfig.CreatePaymentProviderConfigBuilder builder
        )
        {
            CreatePaymentProviderConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).CreatePaymentProviderConfig(op);
        }

        public static List<string>? Execute(
            this GetAggregatePaymentProviders.GetAggregatePaymentProvidersBuilder builder
        )
        {
            GetAggregatePaymentProviders op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).GetAggregatePaymentProviders(op);
        }

        public static Platform.Model.PaymentProviderConfigInfo? Execute(
            this DebugMatchedPaymentProviderConfig.DebugMatchedPaymentProviderConfigBuilder builder
        )
        {
            DebugMatchedPaymentProviderConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).DebugMatchedPaymentProviderConfig(op);
        }

        public static List<string>? Execute(
            this GetSpecialPaymentProviders.GetSpecialPaymentProvidersBuilder builder
        )
        {
            GetSpecialPaymentProviders op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).GetSpecialPaymentProviders(op);
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

        public static Platform.Model.PaymentTaxConfigInfo? Execute(
            this GetPaymentTaxConfig.GetPaymentTaxConfigBuilder builder
        )
        {
            GetPaymentTaxConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).GetPaymentTaxConfig(op);
        }

        public static Platform.Model.PaymentTaxConfigInfo? Execute(
            this UpdatePaymentTaxConfig.UpdatePaymentTaxConfigBuilder builder
        )
        {
            UpdatePaymentTaxConfig op = builder.Build(
            );

            return ((Platform.Wrapper.PaymentConfig)builder.WrapperObject!).UpdatePaymentTaxConfig(op);
        }

    }
}