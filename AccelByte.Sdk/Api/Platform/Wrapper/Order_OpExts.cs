// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformOrder_OpExts
    {
        public static Platform.Model.OrderPagingResult? Execute(
            this QueryOrders.QueryOrdersBuilder builder,
            string namespace_
        )
        {
            QueryOrders op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Order)builder.WrapperObject!).QueryOrders(op);
        }
        public static Platform.Model.OrderStatistics? Execute(
            this GetOrderStatistics.GetOrderStatisticsBuilder builder,
            string namespace_
        )
        {
            GetOrderStatistics op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Order)builder.WrapperObject!).GetOrderStatistics(op);
        }
        public static Platform.Model.OrderInfo? Execute(
            this GetOrder.GetOrderBuilder builder,
            string namespace_,
            string orderNo
        )
        {
            GetOrder op = builder.Build(
                namespace_,
                orderNo
            );

            return ((Platform.Wrapper.Order)builder.WrapperObject!).GetOrder(op);
        }

        public static Platform.Model.OrderInfo<T1>? Execute<T1>(
            this GetOrder.GetOrderBuilder builder,
            string namespace_,
            string orderNo
        )
        {
            GetOrder op = builder.Build(
                namespace_,
                orderNo
            );

            return ((Platform.Wrapper.Order)builder.WrapperObject!).GetOrder<T1>(op);
        }
        public static Platform.Model.OrderInfo? Execute(
            this RefundOrder.RefundOrderBuilder builder,
            string namespace_,
            string orderNo
        )
        {
            RefundOrder op = builder.Build(
                namespace_,
                orderNo
            );

            return ((Platform.Wrapper.Order)builder.WrapperObject!).RefundOrder(op);
        }

        public static Platform.Model.OrderInfo<T1>? Execute<T1>(
            this RefundOrder.RefundOrderBuilder builder,
            string namespace_,
            string orderNo
        )
        {
            RefundOrder op = builder.Build(
                namespace_,
                orderNo
            );

            return ((Platform.Wrapper.Order)builder.WrapperObject!).RefundOrder<T1>(op);
        }
        public static Platform.Model.OrderPagingSlicedResult? Execute(
            this QueryUserOrders.QueryUserOrdersBuilder builder,
            string namespace_,
            string userId
        )
        {
            QueryUserOrders op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Order)builder.WrapperObject!).QueryUserOrders(op);
        }
        public static Platform.Model.OrderInfo? Execute(
            this AdminCreateUserOrder.AdminCreateUserOrderBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminCreateUserOrder op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Order)builder.WrapperObject!).AdminCreateUserOrder(op);
        }

        public static Platform.Model.OrderInfo<T1>? Execute<T1>(
            this AdminCreateUserOrder.AdminCreateUserOrderBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminCreateUserOrder op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Order)builder.WrapperObject!).AdminCreateUserOrder<T1>(op);
        }
        public static Platform.Model.PurchasedItemCount? Execute(
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

            return ((Platform.Wrapper.Order)builder.WrapperObject!).CountOfPurchasedItem(op);
        }
        public static Platform.Model.OrderInfo? Execute(
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

            return ((Platform.Wrapper.Order)builder.WrapperObject!).GetUserOrder(op);
        }

        public static Platform.Model.OrderInfo<T1>? Execute<T1>(
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

            return ((Platform.Wrapper.Order)builder.WrapperObject!).GetUserOrder<T1>(op);
        }
        public static Platform.Model.OrderInfo? Execute(
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

            return ((Platform.Wrapper.Order)builder.WrapperObject!).UpdateUserOrderStatus(op);
        }

        public static Platform.Model.OrderInfo<T1>? Execute<T1>(
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

            return ((Platform.Wrapper.Order)builder.WrapperObject!).UpdateUserOrderStatus<T1>(op);
        }
        public static Platform.Model.OrderInfo? Execute(
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

            return ((Platform.Wrapper.Order)builder.WrapperObject!).FulfillUserOrder(op);
        }

        public static Platform.Model.OrderInfo<T1>? Execute<T1>(
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

            return ((Platform.Wrapper.Order)builder.WrapperObject!).FulfillUserOrder<T1>(op);
        }
        public static Platform.Model.OrderGrantInfo? Execute(
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

            return ((Platform.Wrapper.Order)builder.WrapperObject!).GetUserOrderGrant(op);
        }
        public static List<Platform.Model.OrderHistoryInfo>? Execute(
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

            return ((Platform.Wrapper.Order)builder.WrapperObject!).GetUserOrderHistories(op);
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

            ((Platform.Wrapper.Order)builder.WrapperObject!).ProcessUserOrderNotification(op);
        }
        public static Stream? Execute(
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

            return ((Platform.Wrapper.Order)builder.WrapperObject!).DownloadUserOrderReceipt(op);
        }
        public static Platform.Model.OrderPagingSlicedResult? Execute(
            this PublicQueryUserOrders.PublicQueryUserOrdersBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicQueryUserOrders op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Order)builder.WrapperObject!).PublicQueryUserOrders(op);
        }
        public static Platform.Model.OrderInfo? Execute(
            this PublicCreateUserOrder.PublicCreateUserOrderBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicCreateUserOrder op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Order)builder.WrapperObject!).PublicCreateUserOrder(op);
        }

        public static Platform.Model.OrderInfo<T1>? Execute<T1>(
            this PublicCreateUserOrder.PublicCreateUserOrderBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicCreateUserOrder op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Order)builder.WrapperObject!).PublicCreateUserOrder<T1>(op);
        }
        public static Platform.Model.OrderInfo? Execute(
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

            return ((Platform.Wrapper.Order)builder.WrapperObject!).PublicGetUserOrder(op);
        }

        public static Platform.Model.OrderInfo<T1>? Execute<T1>(
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

            return ((Platform.Wrapper.Order)builder.WrapperObject!).PublicGetUserOrder<T1>(op);
        }
        public static Platform.Model.OrderInfo? Execute(
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

            return ((Platform.Wrapper.Order)builder.WrapperObject!).PublicCancelUserOrder(op);
        }

        public static Platform.Model.OrderInfo<T1>? Execute<T1>(
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

            return ((Platform.Wrapper.Order)builder.WrapperObject!).PublicCancelUserOrder<T1>(op);
        }
        public static List<Platform.Model.OrderHistoryInfo>? Execute(
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

            return ((Platform.Wrapper.Order)builder.WrapperObject!).PublicGetUserOrderHistories(op);
        }
        public static Stream? Execute(
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

            return ((Platform.Wrapper.Order)builder.WrapperObject!).PublicDownloadUserOrderReceipt(op);
        }
    }
}