// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class PaymentStation
    {
        private readonly AccelByteSDK _sdk;

        public PaymentStation(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetPaymentCustomization.GetPaymentCustomizationBuilder GetPaymentCustomizationOp
        {
            get { return Operation.GetPaymentCustomization.Builder.SetWrapperObject(this); }
        }
        public PublicGetPaymentUrl.PublicGetPaymentUrlBuilder PublicGetPaymentUrlOp
        {
            get { return Operation.PublicGetPaymentUrl.Builder.SetWrapperObject(this); }
        }
        public PublicGetPaymentMethods.PublicGetPaymentMethodsBuilder PublicGetPaymentMethodsOp
        {
            get { return Operation.PublicGetPaymentMethods.Builder.SetWrapperObject(this); }
        }
        public PublicGetUnpaidPaymentOrder.PublicGetUnpaidPaymentOrderBuilder PublicGetUnpaidPaymentOrderOp
        {
            get { return Operation.PublicGetUnpaidPaymentOrder.Builder.SetWrapperObject(this); }
        }
        public Pay.PayBuilder PayOp
        {
            get { return Operation.Pay.Builder.SetWrapperObject(this); }
        }
        public PublicCheckPaymentOrderPaidStatus.PublicCheckPaymentOrderPaidStatusBuilder PublicCheckPaymentOrderPaidStatusOp
        {
            get { return Operation.PublicCheckPaymentOrderPaidStatus.Builder.SetWrapperObject(this); }
        }
        public GetPaymentPublicConfig.GetPaymentPublicConfigBuilder GetPaymentPublicConfigOp
        {
            get { return Operation.GetPaymentPublicConfig.Builder.SetWrapperObject(this); }
        }
        public PublicGetQRCode.PublicGetQRCodeBuilder PublicGetQRCodeOp
        {
            get { return Operation.PublicGetQRCode.Builder.SetWrapperObject(this); }
        }
        public PublicNormalizePaymentReturnUrl.PublicNormalizePaymentReturnUrlBuilder PublicNormalizePaymentReturnUrlOp
        {
            get { return Operation.PublicNormalizePaymentReturnUrl.Builder.SetWrapperObject(this); }
        }
        public GetPaymentTaxValue.GetPaymentTaxValueBuilder GetPaymentTaxValueOp
        {
            get { return Operation.GetPaymentTaxValue.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.Customization? GetPaymentCustomization(GetPaymentCustomization input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public Model.PaymentUrl? PublicGetPaymentUrl(PublicGetPaymentUrl input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.PaymentMethod>? PublicGetPaymentMethods(PublicGetPaymentMethods input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderDetails? PublicGetUnpaidPaymentOrder(PublicGetUnpaidPaymentOrder input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentProcessResult? Pay(Pay input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderPaidResult? PublicCheckPaymentOrderPaidStatus(PublicCheckPaymentOrderPaidStatus input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? GetPaymentPublicConfig(GetPaymentPublicConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public byte[]? PublicGetQRCode(PublicGetQRCode input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicNormalizePaymentReturnUrl(PublicNormalizePaymentReturnUrl input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TaxResult? GetPaymentTaxValue(GetPaymentTaxValue input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class PaymentStation_OperationExtensions
    {
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.Customization? Execute(
            this GetPaymentCustomization.GetPaymentCustomizationBuilder builder,
            string namespace_,
            string paymentProvider,
            string region
        )
        {
            GetPaymentCustomization op = builder.Build(
                namespace_,
                paymentProvider,
                region
            );

            return ((PaymentStation)builder.WrapperObject!).GetPaymentCustomization(op);
        }

        public static Model.PaymentUrl? Execute(
            this PublicGetPaymentUrl.PublicGetPaymentUrlBuilder builder,
            string namespace_
        )
        {
            PublicGetPaymentUrl op = builder.Build(
                namespace_
            );

            return ((PaymentStation)builder.WrapperObject!).PublicGetPaymentUrl(op);
        }

        public static List<Model.PaymentMethod>? Execute(
            this PublicGetPaymentMethods.PublicGetPaymentMethodsBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            PublicGetPaymentMethods op = builder.Build(
                namespace_,
                paymentOrderNo
            );

            return ((PaymentStation)builder.WrapperObject!).PublicGetPaymentMethods(op);
        }

        public static Model.PaymentOrderDetails? Execute(
            this PublicGetUnpaidPaymentOrder.PublicGetUnpaidPaymentOrderBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            PublicGetUnpaidPaymentOrder op = builder.Build(
                namespace_,
                paymentOrderNo
            );

            return ((PaymentStation)builder.WrapperObject!).PublicGetUnpaidPaymentOrder(op);
        }

        public static Model.PaymentProcessResult? Execute(
            this Pay.PayBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            Pay op = builder.Build(
                namespace_,
                paymentOrderNo
            );

            return ((PaymentStation)builder.WrapperObject!).Pay(op);
        }

        public static Model.PaymentOrderPaidResult? Execute(
            this PublicCheckPaymentOrderPaidStatus.PublicCheckPaymentOrderPaidStatusBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            PublicCheckPaymentOrderPaidStatus op = builder.Build(
                namespace_,
                paymentOrderNo
            );

            return ((PaymentStation)builder.WrapperObject!).PublicCheckPaymentOrderPaidStatus(op);
        }

        public static Dictionary<string, object>? Execute(
            this GetPaymentPublicConfig.GetPaymentPublicConfigBuilder builder,
            string namespace_,
            string paymentProvider,
            string region
        )
        {
            GetPaymentPublicConfig op = builder.Build(
                namespace_,
                paymentProvider,
                region
            );

            return ((PaymentStation)builder.WrapperObject!).GetPaymentPublicConfig(op);
        }

        public static byte[]? Execute(
            this PublicGetQRCode.PublicGetQRCodeBuilder builder,
            string namespace_,
            string code
        )
        {
            PublicGetQRCode op = builder.Build(
                namespace_,
                code
            );

            return ((PaymentStation)builder.WrapperObject!).PublicGetQRCode(op);
        }

        public static void Execute(
            this PublicNormalizePaymentReturnUrl.PublicNormalizePaymentReturnUrlBuilder builder,
            string namespace_,
            string orderNo,
            string paymentOrderNo,
            string paymentProvider,
            string returnUrl
        )
        {
            PublicNormalizePaymentReturnUrl op = builder.Build(
                namespace_,
                orderNo,
                paymentOrderNo,
                paymentProvider,
                returnUrl
            );

            ((PaymentStation)builder.WrapperObject!).PublicNormalizePaymentReturnUrl(op);
        }

        public static Model.TaxResult? Execute(
            this GetPaymentTaxValue.GetPaymentTaxValueBuilder builder,
            string namespace_,
            string paymentOrderNo,
            string paymentProvider
        )
        {
            GetPaymentTaxValue op = builder.Build(
                namespace_,
                paymentOrderNo,
                paymentProvider
            );

            return ((PaymentStation)builder.WrapperObject!).GetPaymentTaxValue(op);
        }

    }
}