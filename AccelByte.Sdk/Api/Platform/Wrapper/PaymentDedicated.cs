// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class PaymentDedicated
    {
        private readonly AccelByteSDK _sdk;

        public PaymentDedicated(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public CreatePaymentOrderByDedicated.CreatePaymentOrderByDedicatedBuilder CreatePaymentOrderByDedicatedOp
        {
            get { return Operation.CreatePaymentOrderByDedicated.Builder.SetWrapperObject(this); }
        }
        public RefundPaymentOrderByDedicated.RefundPaymentOrderByDedicatedBuilder RefundPaymentOrderByDedicatedOp
        {
            get { return Operation.RefundPaymentOrderByDedicated.Builder.SetWrapperObject(this); }
        }
        public SyncPaymentOrders.SyncPaymentOrdersBuilder SyncPaymentOrdersOp
        {
            get { return Operation.SyncPaymentOrders.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.PaymentOrderCreateResult? CreatePaymentOrderByDedicated(CreatePaymentOrderByDedicated input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.PaymentOrderCreateResult?> CreatePaymentOrderByDedicatedAsync(CreatePaymentOrderByDedicated input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderRefundResult? RefundPaymentOrderByDedicated(RefundPaymentOrderByDedicated input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.PaymentOrderRefundResult?> RefundPaymentOrderByDedicatedAsync(RefundPaymentOrderByDedicated input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderSyncResult? SyncPaymentOrders(SyncPaymentOrders input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.PaymentOrderSyncResult?> SyncPaymentOrdersAsync(SyncPaymentOrders input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}