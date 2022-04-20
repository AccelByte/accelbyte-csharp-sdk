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
}