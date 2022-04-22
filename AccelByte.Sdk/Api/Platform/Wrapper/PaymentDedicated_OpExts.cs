// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformPaymentDedicated_OpExts
    {
        public static Platform.Model.PaymentOrderCreateResult? Execute(
            this CreatePaymentOrderByDedicated.CreatePaymentOrderByDedicatedBuilder builder,
            string namespace_
        )
        {
            CreatePaymentOrderByDedicated op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.PaymentDedicated)builder.WrapperObject!).CreatePaymentOrderByDedicated(op);
        }

        public static Platform.Model.PaymentOrderRefundResult? Execute(
            this RefundPaymentOrderByDedicated.RefundPaymentOrderByDedicatedBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            RefundPaymentOrderByDedicated op = builder.Build(
                namespace_,
                paymentOrderNo
            );

            return ((Platform.Wrapper.PaymentDedicated)builder.WrapperObject!).RefundPaymentOrderByDedicated(op);
        }

        public static Platform.Model.PaymentOrderSyncResult? Execute(
            this SyncPaymentOrders.SyncPaymentOrdersBuilder builder,
            string end,
            string start
        )
        {
            SyncPaymentOrders op = builder.Build(
                end,
                start
            );

            return ((Platform.Wrapper.PaymentDedicated)builder.WrapperObject!).SyncPaymentOrders(op);
        }

    }
}