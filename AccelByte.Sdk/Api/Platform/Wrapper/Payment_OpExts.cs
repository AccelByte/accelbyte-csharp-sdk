// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformPayment_OpExts
    {
        public static Platform.Model.PaymentNotificationPagingSlicedResult? Execute(
            this QueryPaymentNotifications.QueryPaymentNotificationsBuilder builder,
            string namespace_
        )
        {
            QueryPaymentNotifications op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Payment)builder.WrapperObject!).QueryPaymentNotifications(op);
        }

        public static Platform.Model.PaymentOrderPagingSlicedResult? Execute(
            this QueryPaymentOrders.QueryPaymentOrdersBuilder builder,
            string namespace_
        )
        {
            QueryPaymentOrders op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Payment)builder.WrapperObject!).QueryPaymentOrders(op);
        }

        public static List<string>? Execute(
            this ListExtOrderNoByExtTxId.ListExtOrderNoByExtTxIdBuilder builder,
            string namespace_,
            string extTxId
        )
        {
            ListExtOrderNoByExtTxId op = builder.Build(
                namespace_,
                extTxId
            );

            return ((Platform.Wrapper.Payment)builder.WrapperObject!).ListExtOrderNoByExtTxId(op);
        }

        public static Platform.Model.PaymentOrderInfo? Execute(
            this GetPaymentOrder.GetPaymentOrderBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            GetPaymentOrder op = builder.Build(
                namespace_,
                paymentOrderNo
            );

            return ((Platform.Wrapper.Payment)builder.WrapperObject!).GetPaymentOrder(op);
        }

        public static Platform.Model.PaymentOrderInfo? Execute(
            this ChargePaymentOrder.ChargePaymentOrderBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            ChargePaymentOrder op = builder.Build(
                namespace_,
                paymentOrderNo
            );

            return ((Platform.Wrapper.Payment)builder.WrapperObject!).ChargePaymentOrder(op);
        }

        public static Platform.Model.NotificationProcessResult? Execute(
            this SimulatePaymentOrderNotification.SimulatePaymentOrderNotificationBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            SimulatePaymentOrderNotification op = builder.Build(
                namespace_,
                paymentOrderNo
            );

            return ((Platform.Wrapper.Payment)builder.WrapperObject!).SimulatePaymentOrderNotification(op);
        }

        public static Platform.Model.PaymentOrderChargeStatus? Execute(
            this GetPaymentOrderChargeStatus.GetPaymentOrderChargeStatusBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            GetPaymentOrderChargeStatus op = builder.Build(
                namespace_,
                paymentOrderNo
            );

            return ((Platform.Wrapper.Payment)builder.WrapperObject!).GetPaymentOrderChargeStatus(op);
        }

        public static Platform.Model.PaymentOrderInfo? Execute(
            this CreateUserPaymentOrder.CreateUserPaymentOrderBuilder builder,
            string namespace_,
            string userId
        )
        {
            CreateUserPaymentOrder op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Payment)builder.WrapperObject!).CreateUserPaymentOrder(op);
        }

        public static Platform.Model.PaymentOrderInfo? Execute(
            this RefundUserPaymentOrder.RefundUserPaymentOrderBuilder builder,
            string namespace_,
            string paymentOrderNo,
            string userId
        )
        {
            RefundUserPaymentOrder op = builder.Build(
                namespace_,
                paymentOrderNo,
                userId
            );

            return ((Platform.Wrapper.Payment)builder.WrapperObject!).RefundUserPaymentOrder(op);
        }

    }
}