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
}