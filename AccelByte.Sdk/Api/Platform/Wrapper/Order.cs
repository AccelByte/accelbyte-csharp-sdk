// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Order
    {
        private readonly AccelByteSDK _sdk;

        public Order(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QueryOrders.QueryOrdersBuilder QueryOrdersOp
        {
            get { return Operation.QueryOrders.Builder.SetWrapperObject(this); }
        }
        public GetOrderStatistics.GetOrderStatisticsBuilder GetOrderStatisticsOp
        {
            get { return Operation.GetOrderStatistics.Builder.SetWrapperObject(this); }
        }
        public GetOrder.GetOrderBuilder GetOrderOp
        {
            get { return Operation.GetOrder.Builder.SetWrapperObject(this); }
        }
        public RefundOrder.RefundOrderBuilder RefundOrderOp
        {
            get { return Operation.RefundOrder.Builder.SetWrapperObject(this); }
        }
        public QueryUserOrders.QueryUserOrdersBuilder QueryUserOrdersOp
        {
            get { return Operation.QueryUserOrders.Builder.SetWrapperObject(this); }
        }
        public CountOfPurchasedItem.CountOfPurchasedItemBuilder CountOfPurchasedItemOp
        {
            get { return Operation.CountOfPurchasedItem.Builder.SetWrapperObject(this); }
        }
        public GetUserOrder.GetUserOrderBuilder GetUserOrderOp
        {
            get { return Operation.GetUserOrder.Builder.SetWrapperObject(this); }
        }
        public UpdateUserOrderStatus.UpdateUserOrderStatusBuilder UpdateUserOrderStatusOp
        {
            get { return Operation.UpdateUserOrderStatus.Builder.SetWrapperObject(this); }
        }
        public FulfillUserOrder.FulfillUserOrderBuilder FulfillUserOrderOp
        {
            get { return Operation.FulfillUserOrder.Builder.SetWrapperObject(this); }
        }
        public GetUserOrderGrant.GetUserOrderGrantBuilder GetUserOrderGrantOp
        {
            get { return Operation.GetUserOrderGrant.Builder.SetWrapperObject(this); }
        }
        public GetUserOrderHistories.GetUserOrderHistoriesBuilder GetUserOrderHistoriesOp
        {
            get { return Operation.GetUserOrderHistories.Builder.SetWrapperObject(this); }
        }
        public ProcessUserOrderNotification.ProcessUserOrderNotificationBuilder ProcessUserOrderNotificationOp
        {
            get { return Operation.ProcessUserOrderNotification.Builder.SetWrapperObject(this); }
        }
        public DownloadUserOrderReceipt.DownloadUserOrderReceiptBuilder DownloadUserOrderReceiptOp
        {
            get { return Operation.DownloadUserOrderReceipt.Builder.SetWrapperObject(this); }
        }
        public PublicQueryUserOrders.PublicQueryUserOrdersBuilder PublicQueryUserOrdersOp
        {
            get { return Operation.PublicQueryUserOrders.Builder.SetWrapperObject(this); }
        }
        public PublicCreateUserOrder.PublicCreateUserOrderBuilder PublicCreateUserOrderOp
        {
            get { return Operation.PublicCreateUserOrder.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserOrder.PublicGetUserOrderBuilder PublicGetUserOrderOp
        {
            get { return Operation.PublicGetUserOrder.Builder.SetWrapperObject(this); }
        }
        public PublicCancelUserOrder.PublicCancelUserOrderBuilder PublicCancelUserOrderOp
        {
            get { return Operation.PublicCancelUserOrder.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserOrderHistories.PublicGetUserOrderHistoriesBuilder PublicGetUserOrderHistoriesOp
        {
            get { return Operation.PublicGetUserOrderHistories.Builder.SetWrapperObject(this); }
        }
        public PublicDownloadUserOrderReceipt.PublicDownloadUserOrderReceiptBuilder PublicDownloadUserOrderReceiptOp
        {
            get { return Operation.PublicDownloadUserOrderReceipt.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.OrderPagingResult? QueryOrders(QueryOrders input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OrderStatistics? GetOrderStatistics(GetOrderStatistics input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OrderInfo? GetOrder(GetOrder input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OrderInfo? RefundOrder(RefundOrder input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OrderPagingSlicedResult? QueryUserOrders(QueryUserOrders input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PurchasedItemCount? CountOfPurchasedItem(CountOfPurchasedItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OrderInfo? GetUserOrder(GetUserOrder input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OrderInfo? UpdateUserOrderStatus(UpdateUserOrderStatus input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OrderInfo? FulfillUserOrder(FulfillUserOrder input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OrderGrantInfo? GetUserOrderGrant(GetUserOrderGrant input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.OrderHistoryInfo>? GetUserOrderHistories(GetUserOrderHistories input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void ProcessUserOrderNotification(ProcessUserOrderNotification input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DownloadUserOrderReceipt(DownloadUserOrderReceipt input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OrderPagingSlicedResult? PublicQueryUserOrders(PublicQueryUserOrders input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OrderInfo? PublicCreateUserOrder(PublicCreateUserOrder input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OrderInfo? PublicGetUserOrder(PublicGetUserOrder input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OrderInfo? PublicCancelUserOrder(PublicCancelUserOrder input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.OrderHistoryInfo>? PublicGetUserOrderHistories(PublicGetUserOrderHistories input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicDownloadUserOrderReceipt(PublicDownloadUserOrderReceipt input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}