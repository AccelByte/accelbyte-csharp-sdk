// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Subscription
    {
        private readonly AccelByteSDK _sdk;

        public Subscription(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QuerySubscriptions.QuerySubscriptionsBuilder QuerySubscriptionsOp
        {
            get { return Operation.QuerySubscriptions.Builder.SetWrapperObject(this); }
        }
        public RecurringChargeSubscription.RecurringChargeSubscriptionBuilder RecurringChargeSubscriptionOp
        {
            get { return Operation.RecurringChargeSubscription.Builder.SetWrapperObject(this); }
        }
        public QueryUserSubscriptions.QueryUserSubscriptionsBuilder QueryUserSubscriptionsOp
        {
            get { return Operation.QueryUserSubscriptions.Builder.SetWrapperObject(this); }
        }
        public GetUserSubscriptionActivities.GetUserSubscriptionActivitiesBuilder GetUserSubscriptionActivitiesOp
        {
            get { return Operation.GetUserSubscriptionActivities.Builder.SetWrapperObject(this); }
        }
        public PlatformSubscribeSubscription.PlatformSubscribeSubscriptionBuilder PlatformSubscribeSubscriptionOp
        {
            get { return Operation.PlatformSubscribeSubscription.Builder.SetWrapperObject(this); }
        }
        public CheckUserSubscriptionSubscribableByItemId.CheckUserSubscriptionSubscribableByItemIdBuilder CheckUserSubscriptionSubscribableByItemIdOp
        {
            get { return Operation.CheckUserSubscriptionSubscribableByItemId.Builder.SetWrapperObject(this); }
        }
        public GetUserSubscription.GetUserSubscriptionBuilder GetUserSubscriptionOp
        {
            get { return Operation.GetUserSubscription.Builder.SetWrapperObject(this); }
        }
        public DeleteUserSubscription.DeleteUserSubscriptionBuilder DeleteUserSubscriptionOp
        {
            get { return Operation.DeleteUserSubscription.Builder.SetWrapperObject(this); }
        }
        public CancelSubscription.CancelSubscriptionBuilder CancelSubscriptionOp
        {
            get { return Operation.CancelSubscription.Builder.SetWrapperObject(this); }
        }
        public GrantDaysToSubscription.GrantDaysToSubscriptionBuilder GrantDaysToSubscriptionOp
        {
            get { return Operation.GrantDaysToSubscription.Builder.SetWrapperObject(this); }
        }
        public GetUserSubscriptionBillingHistories.GetUserSubscriptionBillingHistoriesBuilder GetUserSubscriptionBillingHistoriesOp
        {
            get { return Operation.GetUserSubscriptionBillingHistories.Builder.SetWrapperObject(this); }
        }
        public ProcessUserSubscriptionNotification.ProcessUserSubscriptionNotificationBuilder ProcessUserSubscriptionNotificationOp
        {
            get { return Operation.ProcessUserSubscriptionNotification.Builder.SetWrapperObject(this); }
        }
        public PublicQueryUserSubscriptions.PublicQueryUserSubscriptionsBuilder PublicQueryUserSubscriptionsOp
        {
            get { return Operation.PublicQueryUserSubscriptions.Builder.SetWrapperObject(this); }
        }
        public PublicSubscribeSubscription.PublicSubscribeSubscriptionBuilder PublicSubscribeSubscriptionOp
        {
            get { return Operation.PublicSubscribeSubscription.Builder.SetWrapperObject(this); }
        }
        public PublicCheckUserSubscriptionSubscribableByItemId.PublicCheckUserSubscriptionSubscribableByItemIdBuilder PublicCheckUserSubscriptionSubscribableByItemIdOp
        {
            get { return Operation.PublicCheckUserSubscriptionSubscribableByItemId.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserSubscription.PublicGetUserSubscriptionBuilder PublicGetUserSubscriptionOp
        {
            get { return Operation.PublicGetUserSubscription.Builder.SetWrapperObject(this); }
        }
        public PublicChangeSubscriptionBillingAccount.PublicChangeSubscriptionBillingAccountBuilder PublicChangeSubscriptionBillingAccountOp
        {
            get { return Operation.PublicChangeSubscriptionBillingAccount.Builder.SetWrapperObject(this); }
        }
        public PublicCancelSubscription.PublicCancelSubscriptionBuilder PublicCancelSubscriptionOp
        {
            get { return Operation.PublicCancelSubscription.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserSubscriptionBillingHistories.PublicGetUserSubscriptionBillingHistoriesBuilder PublicGetUserSubscriptionBillingHistoriesOp
        {
            get { return Operation.PublicGetUserSubscriptionBillingHistories.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.SubscriptionPagingSlicedResult? QuerySubscriptions(QuerySubscriptions input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RecurringChargeResult? RecurringChargeSubscription(RecurringChargeSubscription input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionPagingSlicedResult? QueryUserSubscriptions(QueryUserSubscriptions input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionActivityPagingSlicedResult? GetUserSubscriptionActivities(GetUserSubscriptionActivities input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionInfo? PlatformSubscribeSubscription(PlatformSubscribeSubscription input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.Subscribable? CheckUserSubscriptionSubscribableByItemId(CheckUserSubscriptionSubscribableByItemId input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionInfo? GetUserSubscription(GetUserSubscription input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserSubscription(DeleteUserSubscription input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionInfo? CancelSubscription(CancelSubscription input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionInfo? GrantDaysToSubscription(GrantDaysToSubscription input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.BillingHistoryPagingSlicedResult? GetUserSubscriptionBillingHistories(GetUserSubscriptionBillingHistories input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void ProcessUserSubscriptionNotification(ProcessUserSubscriptionNotification input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionPagingSlicedResult? PublicQueryUserSubscriptions(PublicQueryUserSubscriptions input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicSubscribeSubscription(PublicSubscribeSubscription input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.Subscribable? PublicCheckUserSubscriptionSubscribableByItemId(PublicCheckUserSubscriptionSubscribableByItemId input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionInfo? PublicGetUserSubscription(PublicGetUserSubscription input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionInfo? PublicChangeSubscriptionBillingAccount(PublicChangeSubscriptionBillingAccount input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionInfo? PublicCancelSubscription(PublicCancelSubscription input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.BillingHistoryPagingSlicedResult? PublicGetUserSubscriptionBillingHistories(PublicGetUserSubscriptionBillingHistories input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Subscription_OperationExtensions
    {
        public static Model.SubscriptionPagingSlicedResult? Execute(
            this QuerySubscriptions.QuerySubscriptionsBuilder builder,
            string namespace_
        )
        {
            QuerySubscriptions op = builder.Build(
                namespace_
            );

            return ((Subscription)builder.WrapperObject!).QuerySubscriptions(op);
        }

        public static Model.RecurringChargeResult? Execute(
            this RecurringChargeSubscription.RecurringChargeSubscriptionBuilder builder,
            string namespace_,
            string subscriptionId
        )
        {
            RecurringChargeSubscription op = builder.Build(
                namespace_,
                subscriptionId
            );

            return ((Subscription)builder.WrapperObject!).RecurringChargeSubscription(op);
        }

        public static Model.SubscriptionPagingSlicedResult? Execute(
            this QueryUserSubscriptions.QueryUserSubscriptionsBuilder builder,
            string namespace_,
            string userId
        )
        {
            QueryUserSubscriptions op = builder.Build(
                namespace_,
                userId
            );

            return ((Subscription)builder.WrapperObject!).QueryUserSubscriptions(op);
        }

        public static Model.SubscriptionActivityPagingSlicedResult? Execute(
            this GetUserSubscriptionActivities.GetUserSubscriptionActivitiesBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserSubscriptionActivities op = builder.Build(
                namespace_,
                userId
            );

            return ((Subscription)builder.WrapperObject!).GetUserSubscriptionActivities(op);
        }

        public static Model.SubscriptionInfo? Execute(
            this PlatformSubscribeSubscription.PlatformSubscribeSubscriptionBuilder builder,
            string namespace_,
            string userId
        )
        {
            PlatformSubscribeSubscription op = builder.Build(
                namespace_,
                userId
            );

            return ((Subscription)builder.WrapperObject!).PlatformSubscribeSubscription(op);
        }

        public static Model.Subscribable? Execute(
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

            return ((Subscription)builder.WrapperObject!).CheckUserSubscriptionSubscribableByItemId(op);
        }

        public static Model.SubscriptionInfo? Execute(
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

            return ((Subscription)builder.WrapperObject!).GetUserSubscription(op);
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

            ((Subscription)builder.WrapperObject!).DeleteUserSubscription(op);
        }

        public static Model.SubscriptionInfo? Execute(
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

            return ((Subscription)builder.WrapperObject!).CancelSubscription(op);
        }

        public static Model.SubscriptionInfo? Execute(
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

            return ((Subscription)builder.WrapperObject!).GrantDaysToSubscription(op);
        }

        public static Model.BillingHistoryPagingSlicedResult? Execute(
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

            return ((Subscription)builder.WrapperObject!).GetUserSubscriptionBillingHistories(op);
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

            ((Subscription)builder.WrapperObject!).ProcessUserSubscriptionNotification(op);
        }

        public static Model.SubscriptionPagingSlicedResult? Execute(
            this PublicQueryUserSubscriptions.PublicQueryUserSubscriptionsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicQueryUserSubscriptions op = builder.Build(
                namespace_,
                userId
            );

            return ((Subscription)builder.WrapperObject!).PublicQueryUserSubscriptions(op);
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

            ((Subscription)builder.WrapperObject!).PublicSubscribeSubscription(op);
        }

        public static Model.Subscribable? Execute(
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

            return ((Subscription)builder.WrapperObject!).PublicCheckUserSubscriptionSubscribableByItemId(op);
        }

        public static Model.SubscriptionInfo? Execute(
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

            return ((Subscription)builder.WrapperObject!).PublicGetUserSubscription(op);
        }

        public static Model.SubscriptionInfo? Execute(
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

            return ((Subscription)builder.WrapperObject!).PublicChangeSubscriptionBillingAccount(op);
        }

        public static Model.SubscriptionInfo? Execute(
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

            return ((Subscription)builder.WrapperObject!).PublicCancelSubscription(op);
        }

        public static Model.BillingHistoryPagingSlicedResult? Execute(
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

            return ((Subscription)builder.WrapperObject!).PublicGetUserSubscriptionBillingHistories(op);
        }

    }
}