// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class PaymentConfig
    {
        private readonly AccelByteSDK _sdk;

        public PaymentConfig(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public TestAdyenConfig.TestAdyenConfigBuilder TestAdyenConfigOp
        {
            get { return Operation.TestAdyenConfig.Builder.SetWrapperObject(this); }
        }
        public TestAliPayConfig.TestAliPayConfigBuilder TestAliPayConfigOp
        {
            get { return Operation.TestAliPayConfig.Builder.SetWrapperObject(this); }
        }
        public TestCheckoutConfig.TestCheckoutConfigBuilder TestCheckoutConfigOp
        {
            get { return Operation.TestCheckoutConfig.Builder.SetWrapperObject(this); }
        }
        public DebugMatchedPaymentMerchantConfig.DebugMatchedPaymentMerchantConfigBuilder DebugMatchedPaymentMerchantConfigOp
        {
            get { return Operation.DebugMatchedPaymentMerchantConfig.Builder.SetWrapperObject(this); }
        }
        public TestPayPalConfig.TestPayPalConfigBuilder TestPayPalConfigOp
        {
            get { return Operation.TestPayPalConfig.Builder.SetWrapperObject(this); }
        }
        public TestStripeConfig.TestStripeConfigBuilder TestStripeConfigOp
        {
            get { return Operation.TestStripeConfig.Builder.SetWrapperObject(this); }
        }
        public TestWxPayConfig.TestWxPayConfigBuilder TestWxPayConfigOp
        {
            get { return Operation.TestWxPayConfig.Builder.SetWrapperObject(this); }
        }
        public TestXsollaConfig.TestXsollaConfigBuilder TestXsollaConfigOp
        {
            get { return Operation.TestXsollaConfig.Builder.SetWrapperObject(this); }
        }
        public GetPaymentMerchantConfig.GetPaymentMerchantConfigBuilder GetPaymentMerchantConfigOp
        {
            get { return Operation.GetPaymentMerchantConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateAdyenConfig.UpdateAdyenConfigBuilder UpdateAdyenConfigOp
        {
            get { return Operation.UpdateAdyenConfig.Builder.SetWrapperObject(this); }
        }
        public TestAdyenConfigById.TestAdyenConfigByIdBuilder TestAdyenConfigByIdOp
        {
            get { return Operation.TestAdyenConfigById.Builder.SetWrapperObject(this); }
        }
        public UpdateAliPayConfig.UpdateAliPayConfigBuilder UpdateAliPayConfigOp
        {
            get { return Operation.UpdateAliPayConfig.Builder.SetWrapperObject(this); }
        }
        public TestAliPayConfigById.TestAliPayConfigByIdBuilder TestAliPayConfigByIdOp
        {
            get { return Operation.TestAliPayConfigById.Builder.SetWrapperObject(this); }
        }
        public UpdateCheckoutConfig.UpdateCheckoutConfigBuilder UpdateCheckoutConfigOp
        {
            get { return Operation.UpdateCheckoutConfig.Builder.SetWrapperObject(this); }
        }
        public TestCheckoutConfigById.TestCheckoutConfigByIdBuilder TestCheckoutConfigByIdOp
        {
            get { return Operation.TestCheckoutConfigById.Builder.SetWrapperObject(this); }
        }
        public UpdatePayPalConfig.UpdatePayPalConfigBuilder UpdatePayPalConfigOp
        {
            get { return Operation.UpdatePayPalConfig.Builder.SetWrapperObject(this); }
        }
        public TestPayPalConfigById.TestPayPalConfigByIdBuilder TestPayPalConfigByIdOp
        {
            get { return Operation.TestPayPalConfigById.Builder.SetWrapperObject(this); }
        }
        public UpdateStripeConfig.UpdateStripeConfigBuilder UpdateStripeConfigOp
        {
            get { return Operation.UpdateStripeConfig.Builder.SetWrapperObject(this); }
        }
        public TestStripeConfigById.TestStripeConfigByIdBuilder TestStripeConfigByIdOp
        {
            get { return Operation.TestStripeConfigById.Builder.SetWrapperObject(this); }
        }
        public UpdateWxPayConfig.UpdateWxPayConfigBuilder UpdateWxPayConfigOp
        {
            get { return Operation.UpdateWxPayConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateWxPayConfigCert.UpdateWxPayConfigCertBuilder UpdateWxPayConfigCertOp
        {
            get { return Operation.UpdateWxPayConfigCert.Builder.SetWrapperObject(this); }
        }
        public TestWxPayConfigById.TestWxPayConfigByIdBuilder TestWxPayConfigByIdOp
        {
            get { return Operation.TestWxPayConfigById.Builder.SetWrapperObject(this); }
        }
        public UpdateXsollaConfig.UpdateXsollaConfigBuilder UpdateXsollaConfigOp
        {
            get { return Operation.UpdateXsollaConfig.Builder.SetWrapperObject(this); }
        }
        public TestXsollaConfigById.TestXsollaConfigByIdBuilder TestXsollaConfigByIdOp
        {
            get { return Operation.TestXsollaConfigById.Builder.SetWrapperObject(this); }
        }
        public UpdateXsollaUIConfig.UpdateXsollaUIConfigBuilder UpdateXsollaUIConfigOp
        {
            get { return Operation.UpdateXsollaUIConfig.Builder.SetWrapperObject(this); }
        }
        public QueryPaymentProviderConfig.QueryPaymentProviderConfigBuilder QueryPaymentProviderConfigOp
        {
            get { return Operation.QueryPaymentProviderConfig.Builder.SetWrapperObject(this); }
        }
        public CreatePaymentProviderConfig.CreatePaymentProviderConfigBuilder CreatePaymentProviderConfigOp
        {
            get { return Operation.CreatePaymentProviderConfig.Builder.SetWrapperObject(this); }
        }
        public GetAggregatePaymentProviders.GetAggregatePaymentProvidersBuilder GetAggregatePaymentProvidersOp
        {
            get { return Operation.GetAggregatePaymentProviders.Builder.SetWrapperObject(this); }
        }
        public DebugMatchedPaymentProviderConfig.DebugMatchedPaymentProviderConfigBuilder DebugMatchedPaymentProviderConfigOp
        {
            get { return Operation.DebugMatchedPaymentProviderConfig.Builder.SetWrapperObject(this); }
        }
        public GetSpecialPaymentProviders.GetSpecialPaymentProvidersBuilder GetSpecialPaymentProvidersOp
        {
            get { return Operation.GetSpecialPaymentProviders.Builder.SetWrapperObject(this); }
        }
        public UpdatePaymentProviderConfig.UpdatePaymentProviderConfigBuilder UpdatePaymentProviderConfigOp
        {
            get { return Operation.UpdatePaymentProviderConfig.Builder.SetWrapperObject(this); }
        }
        public DeletePaymentProviderConfig.DeletePaymentProviderConfigBuilder DeletePaymentProviderConfigOp
        {
            get { return Operation.DeletePaymentProviderConfig.Builder.SetWrapperObject(this); }
        }
        public GetPaymentTaxConfig.GetPaymentTaxConfigBuilder GetPaymentTaxConfigOp
        {
            get { return Operation.GetPaymentTaxConfig.Builder.SetWrapperObject(this); }
        }
        public UpdatePaymentTaxConfig.UpdatePaymentTaxConfigBuilder UpdatePaymentTaxConfigOp
        {
            get { return Operation.UpdatePaymentTaxConfig.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.TestResult? TestAdyenConfig(TestAdyenConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TestResult? TestAliPayConfig(TestAliPayConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TestResult? TestCheckoutConfig(TestCheckoutConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentMerchantConfigInfo? DebugMatchedPaymentMerchantConfig(DebugMatchedPaymentMerchantConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TestResult? TestPayPalConfig(TestPayPalConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TestResult? TestStripeConfig(TestStripeConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TestResult? TestWxPayConfig(TestWxPayConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TestResult? TestXsollaConfig(TestXsollaConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentMerchantConfigInfo? GetPaymentMerchantConfig(GetPaymentMerchantConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentMerchantConfigInfo? UpdateAdyenConfig(UpdateAdyenConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TestResult? TestAdyenConfigById(TestAdyenConfigById input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentMerchantConfigInfo? UpdateAliPayConfig(UpdateAliPayConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TestResult? TestAliPayConfigById(TestAliPayConfigById input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentMerchantConfigInfo? UpdateCheckoutConfig(UpdateCheckoutConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TestResult? TestCheckoutConfigById(TestCheckoutConfigById input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentMerchantConfigInfo? UpdatePayPalConfig(UpdatePayPalConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TestResult? TestPayPalConfigById(TestPayPalConfigById input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentMerchantConfigInfo? UpdateStripeConfig(UpdateStripeConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TestResult? TestStripeConfigById(TestStripeConfigById input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentMerchantConfigInfo? UpdateWxPayConfig(UpdateWxPayConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentMerchantConfigInfo? UpdateWxPayConfigCert(UpdateWxPayConfigCert input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TestResult? TestWxPayConfigById(TestWxPayConfigById input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentMerchantConfigInfo? UpdateXsollaConfig(UpdateXsollaConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TestResult? TestXsollaConfigById(TestXsollaConfigById input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentMerchantConfigInfo? UpdateXsollaUIConfig(UpdateXsollaUIConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentProviderConfigPagingSlicedResult? QueryPaymentProviderConfig(QueryPaymentProviderConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentProviderConfigInfo? CreatePaymentProviderConfig(CreatePaymentProviderConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<string>? GetAggregatePaymentProviders(GetAggregatePaymentProviders input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentProviderConfigInfo? DebugMatchedPaymentProviderConfig(DebugMatchedPaymentProviderConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<string>? GetSpecialPaymentProviders(GetSpecialPaymentProviders input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentProviderConfigInfo? UpdatePaymentProviderConfig(UpdatePaymentProviderConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeletePaymentProviderConfig(DeletePaymentProviderConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentTaxConfigInfo? GetPaymentTaxConfig(GetPaymentTaxConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentTaxConfigInfo? UpdatePaymentTaxConfig(UpdatePaymentTaxConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class PaymentConfig_OperationExtensions
    {
        public static Model.TestResult? Execute(
            this TestAdyenConfig.TestAdyenConfigBuilder builder
        )
        {
            TestAdyenConfig op = builder.Build(
            );

            return ((PaymentConfig)builder.WrapperObject!).TestAdyenConfig(op);
        }

        public static Model.TestResult? Execute(
            this TestAliPayConfig.TestAliPayConfigBuilder builder
        )
        {
            TestAliPayConfig op = builder.Build(
            );

            return ((PaymentConfig)builder.WrapperObject!).TestAliPayConfig(op);
        }

        public static Model.TestResult? Execute(
            this TestCheckoutConfig.TestCheckoutConfigBuilder builder
        )
        {
            TestCheckoutConfig op = builder.Build(
            );

            return ((PaymentConfig)builder.WrapperObject!).TestCheckoutConfig(op);
        }

        public static Model.PaymentMerchantConfigInfo? Execute(
            this DebugMatchedPaymentMerchantConfig.DebugMatchedPaymentMerchantConfigBuilder builder
        )
        {
            DebugMatchedPaymentMerchantConfig op = builder.Build(
            );

            return ((PaymentConfig)builder.WrapperObject!).DebugMatchedPaymentMerchantConfig(op);
        }

        public static Model.TestResult? Execute(
            this TestPayPalConfig.TestPayPalConfigBuilder builder
        )
        {
            TestPayPalConfig op = builder.Build(
            );

            return ((PaymentConfig)builder.WrapperObject!).TestPayPalConfig(op);
        }

        public static Model.TestResult? Execute(
            this TestStripeConfig.TestStripeConfigBuilder builder
        )
        {
            TestStripeConfig op = builder.Build(
            );

            return ((PaymentConfig)builder.WrapperObject!).TestStripeConfig(op);
        }

        public static Model.TestResult? Execute(
            this TestWxPayConfig.TestWxPayConfigBuilder builder
        )
        {
            TestWxPayConfig op = builder.Build(
            );

            return ((PaymentConfig)builder.WrapperObject!).TestWxPayConfig(op);
        }

        public static Model.TestResult? Execute(
            this TestXsollaConfig.TestXsollaConfigBuilder builder
        )
        {
            TestXsollaConfig op = builder.Build(
            );

            return ((PaymentConfig)builder.WrapperObject!).TestXsollaConfig(op);
        }

        public static Model.PaymentMerchantConfigInfo? Execute(
            this GetPaymentMerchantConfig.GetPaymentMerchantConfigBuilder builder,
            string id
        )
        {
            GetPaymentMerchantConfig op = builder.Build(
                id
            );

            return ((PaymentConfig)builder.WrapperObject!).GetPaymentMerchantConfig(op);
        }

        public static Model.PaymentMerchantConfigInfo? Execute(
            this UpdateAdyenConfig.UpdateAdyenConfigBuilder builder,
            string id
        )
        {
            UpdateAdyenConfig op = builder.Build(
                id
            );

            return ((PaymentConfig)builder.WrapperObject!).UpdateAdyenConfig(op);
        }

        public static Model.TestResult? Execute(
            this TestAdyenConfigById.TestAdyenConfigByIdBuilder builder,
            string id
        )
        {
            TestAdyenConfigById op = builder.Build(
                id
            );

            return ((PaymentConfig)builder.WrapperObject!).TestAdyenConfigById(op);
        }

        public static Model.PaymentMerchantConfigInfo? Execute(
            this UpdateAliPayConfig.UpdateAliPayConfigBuilder builder,
            string id
        )
        {
            UpdateAliPayConfig op = builder.Build(
                id
            );

            return ((PaymentConfig)builder.WrapperObject!).UpdateAliPayConfig(op);
        }

        public static Model.TestResult? Execute(
            this TestAliPayConfigById.TestAliPayConfigByIdBuilder builder,
            string id
        )
        {
            TestAliPayConfigById op = builder.Build(
                id
            );

            return ((PaymentConfig)builder.WrapperObject!).TestAliPayConfigById(op);
        }

        public static Model.PaymentMerchantConfigInfo? Execute(
            this UpdateCheckoutConfig.UpdateCheckoutConfigBuilder builder,
            string id
        )
        {
            UpdateCheckoutConfig op = builder.Build(
                id
            );

            return ((PaymentConfig)builder.WrapperObject!).UpdateCheckoutConfig(op);
        }

        public static Model.TestResult? Execute(
            this TestCheckoutConfigById.TestCheckoutConfigByIdBuilder builder,
            string id
        )
        {
            TestCheckoutConfigById op = builder.Build(
                id
            );

            return ((PaymentConfig)builder.WrapperObject!).TestCheckoutConfigById(op);
        }

        public static Model.PaymentMerchantConfigInfo? Execute(
            this UpdatePayPalConfig.UpdatePayPalConfigBuilder builder,
            string id
        )
        {
            UpdatePayPalConfig op = builder.Build(
                id
            );

            return ((PaymentConfig)builder.WrapperObject!).UpdatePayPalConfig(op);
        }

        public static Model.TestResult? Execute(
            this TestPayPalConfigById.TestPayPalConfigByIdBuilder builder,
            string id
        )
        {
            TestPayPalConfigById op = builder.Build(
                id
            );

            return ((PaymentConfig)builder.WrapperObject!).TestPayPalConfigById(op);
        }

        public static Model.PaymentMerchantConfigInfo? Execute(
            this UpdateStripeConfig.UpdateStripeConfigBuilder builder,
            string id
        )
        {
            UpdateStripeConfig op = builder.Build(
                id
            );

            return ((PaymentConfig)builder.WrapperObject!).UpdateStripeConfig(op);
        }

        public static Model.TestResult? Execute(
            this TestStripeConfigById.TestStripeConfigByIdBuilder builder,
            string id
        )
        {
            TestStripeConfigById op = builder.Build(
                id
            );

            return ((PaymentConfig)builder.WrapperObject!).TestStripeConfigById(op);
        }

        public static Model.PaymentMerchantConfigInfo? Execute(
            this UpdateWxPayConfig.UpdateWxPayConfigBuilder builder,
            string id
        )
        {
            UpdateWxPayConfig op = builder.Build(
                id
            );

            return ((PaymentConfig)builder.WrapperObject!).UpdateWxPayConfig(op);
        }

        public static Model.PaymentMerchantConfigInfo? Execute(
            this UpdateWxPayConfigCert.UpdateWxPayConfigCertBuilder builder,
            string id
        )
        {
            UpdateWxPayConfigCert op = builder.Build(
                id
            );

            return ((PaymentConfig)builder.WrapperObject!).UpdateWxPayConfigCert(op);
        }

        public static Model.TestResult? Execute(
            this TestWxPayConfigById.TestWxPayConfigByIdBuilder builder,
            string id
        )
        {
            TestWxPayConfigById op = builder.Build(
                id
            );

            return ((PaymentConfig)builder.WrapperObject!).TestWxPayConfigById(op);
        }

        public static Model.PaymentMerchantConfigInfo? Execute(
            this UpdateXsollaConfig.UpdateXsollaConfigBuilder builder,
            string id
        )
        {
            UpdateXsollaConfig op = builder.Build(
                id
            );

            return ((PaymentConfig)builder.WrapperObject!).UpdateXsollaConfig(op);
        }

        public static Model.TestResult? Execute(
            this TestXsollaConfigById.TestXsollaConfigByIdBuilder builder,
            string id
        )
        {
            TestXsollaConfigById op = builder.Build(
                id
            );

            return ((PaymentConfig)builder.WrapperObject!).TestXsollaConfigById(op);
        }

        public static Model.PaymentMerchantConfigInfo? Execute(
            this UpdateXsollaUIConfig.UpdateXsollaUIConfigBuilder builder,
            string id
        )
        {
            UpdateXsollaUIConfig op = builder.Build(
                id
            );

            return ((PaymentConfig)builder.WrapperObject!).UpdateXsollaUIConfig(op);
        }

        public static Model.PaymentProviderConfigPagingSlicedResult? Execute(
            this QueryPaymentProviderConfig.QueryPaymentProviderConfigBuilder builder
        )
        {
            QueryPaymentProviderConfig op = builder.Build(
            );

            return ((PaymentConfig)builder.WrapperObject!).QueryPaymentProviderConfig(op);
        }

        public static Model.PaymentProviderConfigInfo? Execute(
            this CreatePaymentProviderConfig.CreatePaymentProviderConfigBuilder builder
        )
        {
            CreatePaymentProviderConfig op = builder.Build(
            );

            return ((PaymentConfig)builder.WrapperObject!).CreatePaymentProviderConfig(op);
        }

        public static List<string>? Execute(
            this GetAggregatePaymentProviders.GetAggregatePaymentProvidersBuilder builder
        )
        {
            GetAggregatePaymentProviders op = builder.Build(
            );

            return ((PaymentConfig)builder.WrapperObject!).GetAggregatePaymentProviders(op);
        }

        public static Model.PaymentProviderConfigInfo? Execute(
            this DebugMatchedPaymentProviderConfig.DebugMatchedPaymentProviderConfigBuilder builder
        )
        {
            DebugMatchedPaymentProviderConfig op = builder.Build(
            );

            return ((PaymentConfig)builder.WrapperObject!).DebugMatchedPaymentProviderConfig(op);
        }

        public static List<string>? Execute(
            this GetSpecialPaymentProviders.GetSpecialPaymentProvidersBuilder builder
        )
        {
            GetSpecialPaymentProviders op = builder.Build(
            );

            return ((PaymentConfig)builder.WrapperObject!).GetSpecialPaymentProviders(op);
        }

        public static Model.PaymentProviderConfigInfo? Execute(
            this UpdatePaymentProviderConfig.UpdatePaymentProviderConfigBuilder builder,
            string id
        )
        {
            UpdatePaymentProviderConfig op = builder.Build(
                id
            );

            return ((PaymentConfig)builder.WrapperObject!).UpdatePaymentProviderConfig(op);
        }

        public static void Execute(
            this DeletePaymentProviderConfig.DeletePaymentProviderConfigBuilder builder,
            string id
        )
        {
            DeletePaymentProviderConfig op = builder.Build(
                id
            );

            ((PaymentConfig)builder.WrapperObject!).DeletePaymentProviderConfig(op);
        }

        public static Model.PaymentTaxConfigInfo? Execute(
            this GetPaymentTaxConfig.GetPaymentTaxConfigBuilder builder
        )
        {
            GetPaymentTaxConfig op = builder.Build(
            );

            return ((PaymentConfig)builder.WrapperObject!).GetPaymentTaxConfig(op);
        }

        public static Model.PaymentTaxConfigInfo? Execute(
            this UpdatePaymentTaxConfig.UpdatePaymentTaxConfigBuilder builder
        )
        {
            UpdatePaymentTaxConfig op = builder.Build(
            );

            return ((PaymentConfig)builder.WrapperObject!).UpdatePaymentTaxConfig(op);
        }

    }
}