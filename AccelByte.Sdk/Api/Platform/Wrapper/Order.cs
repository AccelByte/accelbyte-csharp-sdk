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

    public static class Order_OperationExtensions
    {
        public static Model.OrderPagingResult? Execute(
            this QueryOrders.QueryOrdersBuilder builder,
            string namespace_
        )
        {
            QueryOrders op = builder.Build(
                namespace_
            );

            return ((Order)builder.WrapperObject!).QueryOrders(op);
        }

        public static Model.OrderStatistics? Execute(
            this GetOrderStatistics.GetOrderStatisticsBuilder builder,
            string namespace_
        )
        {
            GetOrderStatistics op = builder.Build(
                namespace_
            );

            return ((Order)builder.WrapperObject!).GetOrderStatistics(op);
        }

        public static Model.OrderInfo? Execute(
            this GetOrder.GetOrderBuilder builder,
            string namespace_,
            string orderNo
        )
        {
            GetOrder op = builder.Build(
                namespace_,
                orderNo
            );

            return ((Order)builder.WrapperObject!).GetOrder(op);
        }

        public static Model.OrderInfo? Execute(
            this RefundOrder.RefundOrderBuilder builder,
            string namespace_,
            string orderNo
        )
        {
            RefundOrder op = builder.Build(
                namespace_,
                orderNo
            );

            return ((Order)builder.WrapperObject!).RefundOrder(op);
        }

        public static Model.OrderPagingSlicedResult? Execute(
            this QueryUserOrders.QueryUserOrdersBuilder builder,
            string namespace_,
            string userId
        )
        {
            QueryUserOrders op = builder.Build(
                namespace_,
                userId
            );

            return ((Order)builder.WrapperObject!).QueryUserOrders(op);
        }

        public static Model.PurchasedItemCount? Execute(
            this CountOfPurchasedItem.CountOfPurchasedItemBuilder builder,
            string namespace_,
            string userId,
            string itemId
        )
        {
            CountOfPurchasedItem op = builder.Build(
                namespace_,
                userId,
                itemId
            );

            return ((Order)builder.WrapperObject!).CountOfPurchasedItem(op);
        }

        public static Model.OrderInfo? Execute(
            this GetUserOrder.GetUserOrderBuilder builder,
            string namespace_,
            string orderNo,
            string userId
        )
        {
            GetUserOrder op = builder.Build(
                namespace_,
                orderNo,
                userId
            );

            return ((Order)builder.WrapperObject!).GetUserOrder(op);
        }

        public static Model.OrderInfo? Execute(
            this UpdateUserOrderStatus.UpdateUserOrderStatusBuilder builder,
            string namespace_,
            string orderNo,
            string userId
        )
        {
            UpdateUserOrderStatus op = builder.Build(
                namespace_,
                orderNo,
                userId
            );

            return ((Order)builder.WrapperObject!).UpdateUserOrderStatus(op);
        }

        public static Model.OrderInfo? Execute(
            this FulfillUserOrder.FulfillUserOrderBuilder builder,
            string namespace_,
            string orderNo,
            string userId
        )
        {
            FulfillUserOrder op = builder.Build(
                namespace_,
                orderNo,
                userId
            );

            return ((Order)builder.WrapperObject!).FulfillUserOrder(op);
        }

        public static Model.OrderGrantInfo? Execute(
            this GetUserOrderGrant.GetUserOrderGrantBuilder builder,
            string namespace_,
            string orderNo,
            string userId
        )
        {
            GetUserOrderGrant op = builder.Build(
                namespace_,
                orderNo,
                userId
            );

            return ((Order)builder.WrapperObject!).GetUserOrderGrant(op);
        }

        public static List<Model.OrderHistoryInfo>? Execute(
            this GetUserOrderHistories.GetUserOrderHistoriesBuilder builder,
            string namespace_,
            string orderNo,
            string userId
        )
        {
            GetUserOrderHistories op = builder.Build(
                namespace_,
                orderNo,
                userId
            );

            return ((Order)builder.WrapperObject!).GetUserOrderHistories(op);
        }

        public static void Execute(
            this ProcessUserOrderNotification.ProcessUserOrderNotificationBuilder builder,
            string namespace_,
            string orderNo,
            string userId
        )
        {
            ProcessUserOrderNotification op = builder.Build(
                namespace_,
                orderNo,
                userId
            );

            ((Order)builder.WrapperObject!).ProcessUserOrderNotification(op);
        }

        public static void Execute(
            this DownloadUserOrderReceipt.DownloadUserOrderReceiptBuilder builder,
            string namespace_,
            string orderNo,
            string userId
        )
        {
            DownloadUserOrderReceipt op = builder.Build(
                namespace_,
                orderNo,
                userId
            );

            ((Order)builder.WrapperObject!).DownloadUserOrderReceipt(op);
        }

        public static Model.OrderPagingSlicedResult? Execute(
            this PublicQueryUserOrders.PublicQueryUserOrdersBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicQueryUserOrders op = builder.Build(
                namespace_,
                userId
            );

            return ((Order)builder.WrapperObject!).PublicQueryUserOrders(op);
        }

        public static Model.OrderInfo? Execute(
            this PublicCreateUserOrder.PublicCreateUserOrderBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicCreateUserOrder op = builder.Build(
                namespace_,
                userId
            );

            return ((Order)builder.WrapperObject!).PublicCreateUserOrder(op);
        }

        public static Model.OrderInfo? Execute(
            this PublicGetUserOrder.PublicGetUserOrderBuilder builder,
            string namespace_,
            string orderNo,
            string userId
        )
        {
            PublicGetUserOrder op = builder.Build(
                namespace_,
                orderNo,
                userId
            );

            return ((Order)builder.WrapperObject!).PublicGetUserOrder(op);
        }

        public static Model.OrderInfo? Execute(
            this PublicCancelUserOrder.PublicCancelUserOrderBuilder builder,
            string namespace_,
            string orderNo,
            string userId
        )
        {
            PublicCancelUserOrder op = builder.Build(
                namespace_,
                orderNo,
                userId
            );

            return ((Order)builder.WrapperObject!).PublicCancelUserOrder(op);
        }

        public static List<Model.OrderHistoryInfo>? Execute(
            this PublicGetUserOrderHistories.PublicGetUserOrderHistoriesBuilder builder,
            string namespace_,
            string orderNo,
            string userId
        )
        {
            PublicGetUserOrderHistories op = builder.Build(
                namespace_,
                orderNo,
                userId
            );

            return ((Order)builder.WrapperObject!).PublicGetUserOrderHistories(op);
        }

        public static void Execute(
            this PublicDownloadUserOrderReceipt.PublicDownloadUserOrderReceiptBuilder builder,
            string namespace_,
            string orderNo,
            string userId
        )
        {
            PublicDownloadUserOrderReceipt op = builder.Build(
                namespace_,
                orderNo,
                userId
            );

            ((Order)builder.WrapperObject!).PublicDownloadUserOrderReceipt(op);
        }

    }
}