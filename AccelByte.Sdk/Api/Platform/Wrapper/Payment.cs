// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Payment
    {
        private readonly AccelByteSDK _sdk;

        public Payment(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QueryPaymentNotifications.QueryPaymentNotificationsBuilder QueryPaymentNotificationsOp
        {
            get { return Operation.QueryPaymentNotifications.Builder.SetWrapperObject(this); }
        }
        public QueryPaymentOrders.QueryPaymentOrdersBuilder QueryPaymentOrdersOp
        {
            get { return Operation.QueryPaymentOrders.Builder.SetWrapperObject(this); }
        }
        public ListExtOrderNoByExtTxId.ListExtOrderNoByExtTxIdBuilder ListExtOrderNoByExtTxIdOp
        {
            get { return Operation.ListExtOrderNoByExtTxId.Builder.SetWrapperObject(this); }
        }
        public GetPaymentOrder.GetPaymentOrderBuilder GetPaymentOrderOp
        {
            get { return Operation.GetPaymentOrder.Builder.SetWrapperObject(this); }
        }
        public ChargePaymentOrder.ChargePaymentOrderBuilder ChargePaymentOrderOp
        {
            get { return Operation.ChargePaymentOrder.Builder.SetWrapperObject(this); }
        }
        public SimulatePaymentOrderNotification.SimulatePaymentOrderNotificationBuilder SimulatePaymentOrderNotificationOp
        {
            get { return Operation.SimulatePaymentOrderNotification.Builder.SetWrapperObject(this); }
        }
        public GetPaymentOrderChargeStatus.GetPaymentOrderChargeStatusBuilder GetPaymentOrderChargeStatusOp
        {
            get { return Operation.GetPaymentOrderChargeStatus.Builder.SetWrapperObject(this); }
        }
        public CreateUserPaymentOrder.CreateUserPaymentOrderBuilder CreateUserPaymentOrderOp
        {
            get { return Operation.CreateUserPaymentOrder.Builder.SetWrapperObject(this); }
        }
        public RefundUserPaymentOrder.RefundUserPaymentOrderBuilder RefundUserPaymentOrderOp
        {
            get { return Operation.RefundUserPaymentOrder.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.PaymentNotificationPagingSlicedResult? QueryPaymentNotifications(QueryPaymentNotifications input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderPagingSlicedResult? QueryPaymentOrders(QueryPaymentOrders input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<string>? ListExtOrderNoByExtTxId(ListExtOrderNoByExtTxId input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderInfo? GetPaymentOrder(GetPaymentOrder input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderInfo? ChargePaymentOrder(ChargePaymentOrder input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.NotificationProcessResult? SimulatePaymentOrderNotification(SimulatePaymentOrderNotification input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderChargeStatus? GetPaymentOrderChargeStatus(GetPaymentOrderChargeStatus input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderInfo? CreateUserPaymentOrder(CreateUserPaymentOrder input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderInfo? RefundUserPaymentOrder(RefundUserPaymentOrder input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Payment_OperationExtensions
    {
        public static Model.PaymentNotificationPagingSlicedResult? Execute(
            this QueryPaymentNotifications.QueryPaymentNotificationsBuilder builder,
            string namespace_
        )
        {
            QueryPaymentNotifications op = builder.Build(
                namespace_
            );

            return ((Payment)builder.WrapperObject!).QueryPaymentNotifications(op);
        }

        public static Model.PaymentOrderPagingSlicedResult? Execute(
            this QueryPaymentOrders.QueryPaymentOrdersBuilder builder,
            string namespace_
        )
        {
            QueryPaymentOrders op = builder.Build(
                namespace_
            );

            return ((Payment)builder.WrapperObject!).QueryPaymentOrders(op);
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

            return ((Payment)builder.WrapperObject!).ListExtOrderNoByExtTxId(op);
        }

        public static Model.PaymentOrderInfo? Execute(
            this GetPaymentOrder.GetPaymentOrderBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            GetPaymentOrder op = builder.Build(
                namespace_,
                paymentOrderNo
            );

            return ((Payment)builder.WrapperObject!).GetPaymentOrder(op);
        }

        public static Model.PaymentOrderInfo? Execute(
            this ChargePaymentOrder.ChargePaymentOrderBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            ChargePaymentOrder op = builder.Build(
                namespace_,
                paymentOrderNo
            );

            return ((Payment)builder.WrapperObject!).ChargePaymentOrder(op);
        }

        public static Model.NotificationProcessResult? Execute(
            this SimulatePaymentOrderNotification.SimulatePaymentOrderNotificationBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            SimulatePaymentOrderNotification op = builder.Build(
                namespace_,
                paymentOrderNo
            );

            return ((Payment)builder.WrapperObject!).SimulatePaymentOrderNotification(op);
        }

        public static Model.PaymentOrderChargeStatus? Execute(
            this GetPaymentOrderChargeStatus.GetPaymentOrderChargeStatusBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            GetPaymentOrderChargeStatus op = builder.Build(
                namespace_,
                paymentOrderNo
            );

            return ((Payment)builder.WrapperObject!).GetPaymentOrderChargeStatus(op);
        }

        public static Model.PaymentOrderInfo? Execute(
            this CreateUserPaymentOrder.CreateUserPaymentOrderBuilder builder,
            string namespace_,
            string userId
        )
        {
            CreateUserPaymentOrder op = builder.Build(
                namespace_,
                userId
            );

            return ((Payment)builder.WrapperObject!).CreateUserPaymentOrder(op);
        }

        public static Model.PaymentOrderInfo? Execute(
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

            return ((Payment)builder.WrapperObject!).RefundUserPaymentOrder(op);
        }

    }
}