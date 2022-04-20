// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformSubscription_OpExts
    {
        public static Platform.Model.SubscriptionPagingSlicedResult? Execute(
            this QuerySubscriptions.QuerySubscriptionsBuilder builder,
            string namespace_
        )
        {
            QuerySubscriptions op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Subscription)builder.WrapperObject!).QuerySubscriptions(op);
        }

        public static Platform.Model.RecurringChargeResult? Execute(
            this RecurringChargeSubscription.RecurringChargeSubscriptionBuilder builder,
            string namespace_,
            string subscriptionId
        )
        {
            RecurringChargeSubscription op = builder.Build(
                namespace_,
                subscriptionId
            );

            return ((Platform.Wrapper.Subscription)builder.WrapperObject!).RecurringChargeSubscription(op);
        }

        public static Platform.Model.SubscriptionPagingSlicedResult? Execute(
            this QueryUserSubscriptions.QueryUserSubscriptionsBuilder builder,
            string namespace_,
            string userId
        )
        {
            QueryUserSubscriptions op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Subscription)builder.WrapperObject!).QueryUserSubscriptions(op);
        }

        public static Platform.Model.SubscriptionActivityPagingSlicedResult? Execute(
            this GetUserSubscriptionActivities.GetUserSubscriptionActivitiesBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserSubscriptionActivities op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Subscription)builder.WrapperObject!).GetUserSubscriptionActivities(op);
        }

        public static Platform.Model.SubscriptionInfo? Execute(
            this PlatformSubscribeSubscription.PlatformSubscribeSubscriptionBuilder builder,
            string namespace_,
            string userId
        )
        {
            PlatformSubscribeSubscription op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Subscription)builder.WrapperObject!).PlatformSubscribeSubscription(op);
        }

        public static Platform.Model.Subscribable? Execute(
            this CheckUserSubscriptionSubscribableByItemId.CheckUserSubscriptionSubscribableByItemIdBuilder builder,
            string namespace_,
            string userId,
            string itemId
        )
        {
            CheckUserSubscriptionSubscribableByItemId op = builder.Build(
                namespace_,
                userId,
                itemId
            );

            return ((Platform.Wrapper.Subscription)builder.WrapperObject!).CheckUserSubscriptionSubscribableByItemId(op);
        }

        public static Platform.Model.SubscriptionInfo? Execute(
            this GetUserSubscription.GetUserSubscriptionBuilder builder,
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            GetUserSubscription op = builder.Build(
                namespace_,
                subscriptionId,
                userId
            );

            return ((Platform.Wrapper.Subscription)builder.WrapperObject!).GetUserSubscription(op);
        }

        public static void Execute(
            this DeleteUserSubscription.DeleteUserSubscriptionBuilder builder,
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            DeleteUserSubscription op = builder.Build(
                namespace_,
                subscriptionId,
                userId
            );

            ((Platform.Wrapper.Subscription)builder.WrapperObject!).DeleteUserSubscription(op);
        }

        public static Platform.Model.SubscriptionInfo? Execute(
            this CancelSubscription.CancelSubscriptionBuilder builder,
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            CancelSubscription op = builder.Build(
                namespace_,
                subscriptionId,
                userId
            );

            return ((Platform.Wrapper.Subscription)builder.WrapperObject!).CancelSubscription(op);
        }

        public static Platform.Model.SubscriptionInfo? Execute(
            this GrantDaysToSubscription.GrantDaysToSubscriptionBuilder builder,
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            GrantDaysToSubscription op = builder.Build(
                namespace_,
                subscriptionId,
                userId
            );

            return ((Platform.Wrapper.Subscription)builder.WrapperObject!).GrantDaysToSubscription(op);
        }

        public static Platform.Model.BillingHistoryPagingSlicedResult? Execute(
            this GetUserSubscriptionBillingHistories.GetUserSubscriptionBillingHistoriesBuilder builder,
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            GetUserSubscriptionBillingHistories op = builder.Build(
                namespace_,
                subscriptionId,
                userId
            );

            return ((Platform.Wrapper.Subscription)builder.WrapperObject!).GetUserSubscriptionBillingHistories(op);
        }

        public static void Execute(
            this ProcessUserSubscriptionNotification.ProcessUserSubscriptionNotificationBuilder builder,
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            ProcessUserSubscriptionNotification op = builder.Build(
                namespace_,
                subscriptionId,
                userId
            );

            ((Platform.Wrapper.Subscription)builder.WrapperObject!).ProcessUserSubscriptionNotification(op);
        }

        public static Platform.Model.SubscriptionPagingSlicedResult? Execute(
            this PublicQueryUserSubscriptions.PublicQueryUserSubscriptionsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicQueryUserSubscriptions op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Subscription)builder.WrapperObject!).PublicQueryUserSubscriptions(op);
        }

        public static void Execute(
            this PublicSubscribeSubscription.PublicSubscribeSubscriptionBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicSubscribeSubscription op = builder.Build(
                namespace_,
                userId
            );

            ((Platform.Wrapper.Subscription)builder.WrapperObject!).PublicSubscribeSubscription(op);
        }

        public static Platform.Model.Subscribable? Execute(
            this PublicCheckUserSubscriptionSubscribableByItemId.PublicCheckUserSubscriptionSubscribableByItemIdBuilder builder,
            string namespace_,
            string userId,
            string itemId
        )
        {
            PublicCheckUserSubscriptionSubscribableByItemId op = builder.Build(
                namespace_,
                userId,
                itemId
            );

            return ((Platform.Wrapper.Subscription)builder.WrapperObject!).PublicCheckUserSubscriptionSubscribableByItemId(op);
        }

        public static Platform.Model.SubscriptionInfo? Execute(
            this PublicGetUserSubscription.PublicGetUserSubscriptionBuilder builder,
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            PublicGetUserSubscription op = builder.Build(
                namespace_,
                subscriptionId,
                userId
            );

            return ((Platform.Wrapper.Subscription)builder.WrapperObject!).PublicGetUserSubscription(op);
        }

        public static Platform.Model.SubscriptionInfo? Execute(
            this PublicChangeSubscriptionBillingAccount.PublicChangeSubscriptionBillingAccountBuilder builder,
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            PublicChangeSubscriptionBillingAccount op = builder.Build(
                namespace_,
                subscriptionId,
                userId
            );

            return ((Platform.Wrapper.Subscription)builder.WrapperObject!).PublicChangeSubscriptionBillingAccount(op);
        }

        public static Platform.Model.SubscriptionInfo? Execute(
            this PublicCancelSubscription.PublicCancelSubscriptionBuilder builder,
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            PublicCancelSubscription op = builder.Build(
                namespace_,
                subscriptionId,
                userId
            );

            return ((Platform.Wrapper.Subscription)builder.WrapperObject!).PublicCancelSubscription(op);
        }

        public static Platform.Model.BillingHistoryPagingSlicedResult? Execute(
            this PublicGetUserSubscriptionBillingHistories.PublicGetUserSubscriptionBillingHistoriesBuilder builder,
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            PublicGetUserSubscriptionBillingHistories op = builder.Build(
                namespace_,
                subscriptionId,
                userId
            );

            return ((Platform.Wrapper.Subscription)builder.WrapperObject!).PublicGetUserSubscriptionBillingHistories(op);
        }

    }
}