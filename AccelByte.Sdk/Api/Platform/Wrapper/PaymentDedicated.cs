// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
        
        public Model.PaymentOrderCreateResult? CreatePaymentOrderByDedicated(CreatePaymentOrderByDedicated input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderRefundResult? RefundPaymentOrderByDedicated(RefundPaymentOrderByDedicated input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderSyncResult? SyncPaymentOrders(SyncPaymentOrders input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class PaymentDedicated_OperationExtensions
    {
        public static Model.PaymentOrderCreateResult? Execute(
            this CreatePaymentOrderByDedicated.CreatePaymentOrderByDedicatedBuilder builder,
            string namespace_
        )
        {
            CreatePaymentOrderByDedicated op = builder.Build(
                namespace_
            );

            return ((PaymentDedicated)builder.WrapperObject!).CreatePaymentOrderByDedicated(op);
        }

        public static Model.PaymentOrderRefundResult? Execute(
            this RefundPaymentOrderByDedicated.RefundPaymentOrderByDedicatedBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            RefundPaymentOrderByDedicated op = builder.Build(
                namespace_,
                paymentOrderNo
            );

            return ((PaymentDedicated)builder.WrapperObject!).RefundPaymentOrderByDedicated(op);
        }

        public static Model.PaymentOrderSyncResult? Execute(
            this SyncPaymentOrders.SyncPaymentOrdersBuilder builder,
            string end,
            string start
        )
        {
            SyncPaymentOrders op = builder.Build(
                end,
                start
            );

            return ((PaymentDedicated)builder.WrapperObject!).SyncPaymentOrders(op);
        }

    }
}