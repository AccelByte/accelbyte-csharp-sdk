// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Operation.Deprecated;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformPaymentStation_OpExts
    {
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Platform.Model.Customization? Execute(
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

            return ((Platform.Wrapper.PaymentStation)builder.WrapperObject!).GetPaymentCustomization(op);
        }

        public static Platform.Model.PaymentUrl? Execute(
            this PublicGetPaymentUrl.PublicGetPaymentUrlBuilder builder,
            string namespace_
        )
        {
            PublicGetPaymentUrl op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.PaymentStation)builder.WrapperObject!).PublicGetPaymentUrl(op);
        }

        public static List<Platform.Model.PaymentMethod>? Execute(
            this PublicGetPaymentMethods.PublicGetPaymentMethodsBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            PublicGetPaymentMethods op = builder.Build(
                namespace_,
                paymentOrderNo
            );

            return ((Platform.Wrapper.PaymentStation)builder.WrapperObject!).PublicGetPaymentMethods(op);
        }

        public static Platform.Model.PaymentOrderDetails? Execute(
            this PublicGetUnpaidPaymentOrder.PublicGetUnpaidPaymentOrderBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            PublicGetUnpaidPaymentOrder op = builder.Build(
                namespace_,
                paymentOrderNo
            );

            return ((Platform.Wrapper.PaymentStation)builder.WrapperObject!).PublicGetUnpaidPaymentOrder(op);
        }

        public static Platform.Model.PaymentProcessResult? Execute(
            this Pay.PayBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            Pay op = builder.Build(
                namespace_,
                paymentOrderNo
            );

            return ((Platform.Wrapper.PaymentStation)builder.WrapperObject!).Pay(op);
        }

        public static Platform.Model.PaymentOrderPaidResult? Execute(
            this PublicCheckPaymentOrderPaidStatus.PublicCheckPaymentOrderPaidStatusBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            PublicCheckPaymentOrderPaidStatus op = builder.Build(
                namespace_,
                paymentOrderNo
            );

            return ((Platform.Wrapper.PaymentStation)builder.WrapperObject!).PublicCheckPaymentOrderPaidStatus(op);
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

            return ((Platform.Wrapper.PaymentStation)builder.WrapperObject!).GetPaymentPublicConfig(op);
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

            return ((Platform.Wrapper.PaymentStation)builder.WrapperObject!).PublicGetQRCode(op);
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

            ((Platform.Wrapper.PaymentStation)builder.WrapperObject!).PublicNormalizePaymentReturnUrl(op);
        }

        public static Platform.Model.TaxResult? Execute(
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

            return ((Platform.Wrapper.PaymentStation)builder.WrapperObject!).GetPaymentTaxValue(op);
        }

    }
}