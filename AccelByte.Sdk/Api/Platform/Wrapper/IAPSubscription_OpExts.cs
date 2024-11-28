// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformIAPSubscription_OpExts
    {
        public static Platform.Model.ThirdPartyUserSubscriptionPagingSlicedResult? Execute(
            this QueryThirdPartySubscription.QueryThirdPartySubscriptionBuilder builder,
            string namespace_
        )
        {
            QueryThirdPartySubscription op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).QueryThirdPartySubscription(op);
        }
        public static async Task<Platform.Model.ThirdPartyUserSubscriptionPagingSlicedResult?> ExecuteAsync(
            this QueryThirdPartySubscription.QueryThirdPartySubscriptionBuilder builder,
            string namespace_
        )
        {
            QueryThirdPartySubscription op = builder.Build(
                namespace_
            );

            return await ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).QueryThirdPartySubscriptionAsync(op);
        }
        public static Platform.Model.ThirdPartyUserSubscriptionPagingSlicedResult? Execute(
            this QueryUserThirdPartySubscription.QueryUserThirdPartySubscriptionBuilder builder,
            string namespace_,
            string userId
        )
        {
            QueryUserThirdPartySubscription op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).QueryUserThirdPartySubscription(op);
        }
        public static async Task<Platform.Model.ThirdPartyUserSubscriptionPagingSlicedResult?> ExecuteAsync(
            this QueryUserThirdPartySubscription.QueryUserThirdPartySubscriptionBuilder builder,
            string namespace_,
            string userId
        )
        {
            QueryUserThirdPartySubscription op = builder.Build(
                namespace_,
                userId
            );

            return await ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).QueryUserThirdPartySubscriptionAsync(op);
        }
        public static Platform.Model.ThirdPartySubscriptionOwnership? Execute(
            this GetThirdPartyPlatformSubscriptionOwnershipByGroupId.GetThirdPartyPlatformSubscriptionOwnershipByGroupIdBuilder builder,
            string namespace_,
            string platform,
            string userId,
            string groupId
        )
        {
            GetThirdPartyPlatformSubscriptionOwnershipByGroupId op = builder.Build(
                namespace_,
                platform,
                userId,
                groupId
            );

            return ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).GetThirdPartyPlatformSubscriptionOwnershipByGroupId(op);
        }
        public static async Task<Platform.Model.ThirdPartySubscriptionOwnership?> ExecuteAsync(
            this GetThirdPartyPlatformSubscriptionOwnershipByGroupId.GetThirdPartyPlatformSubscriptionOwnershipByGroupIdBuilder builder,
            string namespace_,
            string platform,
            string userId,
            string groupId
        )
        {
            GetThirdPartyPlatformSubscriptionOwnershipByGroupId op = builder.Build(
                namespace_,
                platform,
                userId,
                groupId
            );

            return await ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).GetThirdPartyPlatformSubscriptionOwnershipByGroupIdAsync(op);
        }
        public static Platform.Model.ThirdPartySubscriptionOwnership? Execute(
            this GetThirdPartyPlatformSubscriptionOwnershipByProductId.GetThirdPartyPlatformSubscriptionOwnershipByProductIdBuilder builder,
            string namespace_,
            string platform,
            string userId,
            string productId
        )
        {
            GetThirdPartyPlatformSubscriptionOwnershipByProductId op = builder.Build(
                namespace_,
                platform,
                userId,
                productId
            );

            return ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).GetThirdPartyPlatformSubscriptionOwnershipByProductId(op);
        }
        public static async Task<Platform.Model.ThirdPartySubscriptionOwnership?> ExecuteAsync(
            this GetThirdPartyPlatformSubscriptionOwnershipByProductId.GetThirdPartyPlatformSubscriptionOwnershipByProductIdBuilder builder,
            string namespace_,
            string platform,
            string userId,
            string productId
        )
        {
            GetThirdPartyPlatformSubscriptionOwnershipByProductId op = builder.Build(
                namespace_,
                platform,
                userId,
                productId
            );

            return await ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).GetThirdPartyPlatformSubscriptionOwnershipByProductIdAsync(op);
        }
        public static Platform.Model.ThirdPartySubscriptionTransactionPagingSlicedResult? Execute(
            this QueryUserThirdPartySubscriptionTransactions.QueryUserThirdPartySubscriptionTransactionsBuilder builder,
            string namespace_,
            string userId
        )
        {
            QueryUserThirdPartySubscriptionTransactions op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).QueryUserThirdPartySubscriptionTransactions(op);
        }
        public static async Task<Platform.Model.ThirdPartySubscriptionTransactionPagingSlicedResult?> ExecuteAsync(
            this QueryUserThirdPartySubscriptionTransactions.QueryUserThirdPartySubscriptionTransactionsBuilder builder,
            string namespace_,
            string userId
        )
        {
            QueryUserThirdPartySubscriptionTransactions op = builder.Build(
                namespace_,
                userId
            );

            return await ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).QueryUserThirdPartySubscriptionTransactionsAsync(op);
        }
        public static Platform.Model.ThirdPartySubscriptionTransactionInfo? Execute(
            this GetThirdPartySubscriptionDetails.GetThirdPartySubscriptionDetailsBuilder builder,
            string id,
            string namespace_,
            string userId
        )
        {
            GetThirdPartySubscriptionDetails op = builder.Build(
                id,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).GetThirdPartySubscriptionDetails(op);
        }
        public static async Task<Platform.Model.ThirdPartySubscriptionTransactionInfo?> ExecuteAsync(
            this GetThirdPartySubscriptionDetails.GetThirdPartySubscriptionDetailsBuilder builder,
            string id,
            string namespace_,
            string userId
        )
        {
            GetThirdPartySubscriptionDetails op = builder.Build(
                id,
                namespace_,
                userId
            );

            return await ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).GetThirdPartySubscriptionDetailsAsync(op);
        }
        public static Platform.Model.ThirdPartySubscriptionTransactionHistoryPagingSlicedResult? Execute(
            this GetSubscriptionHistory.GetSubscriptionHistoryBuilder builder,
            string id,
            string namespace_,
            string userId
        )
        {
            GetSubscriptionHistory op = builder.Build(
                id,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).GetSubscriptionHistory(op);
        }
        public static async Task<Platform.Model.ThirdPartySubscriptionTransactionHistoryPagingSlicedResult?> ExecuteAsync(
            this GetSubscriptionHistory.GetSubscriptionHistoryBuilder builder,
            string id,
            string namespace_,
            string userId
        )
        {
            GetSubscriptionHistory op = builder.Build(
                id,
                namespace_,
                userId
            );

            return await ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).GetSubscriptionHistoryAsync(op);
        }
        public static Platform.Model.ThirdPartySubscriptionTransactionInfo? Execute(
            this SyncSubscriptionTransaction.SyncSubscriptionTransactionBuilder builder,
            string id,
            string namespace_,
            string userId
        )
        {
            SyncSubscriptionTransaction op = builder.Build(
                id,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).SyncSubscriptionTransaction(op);
        }
        public static async Task<Platform.Model.ThirdPartySubscriptionTransactionInfo?> ExecuteAsync(
            this SyncSubscriptionTransaction.SyncSubscriptionTransactionBuilder builder,
            string id,
            string namespace_,
            string userId
        )
        {
            SyncSubscriptionTransaction op = builder.Build(
                id,
                namespace_,
                userId
            );

            return await ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).SyncSubscriptionTransactionAsync(op);
        }
        public static Platform.Model.ThirdPartyUserSubscriptionInfo? Execute(
            this GetThirdPartyUserSubscriptionDetails.GetThirdPartyUserSubscriptionDetailsBuilder builder,
            string id,
            string namespace_,
            string userId
        )
        {
            GetThirdPartyUserSubscriptionDetails op = builder.Build(
                id,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).GetThirdPartyUserSubscriptionDetails(op);
        }
        public static async Task<Platform.Model.ThirdPartyUserSubscriptionInfo?> ExecuteAsync(
            this GetThirdPartyUserSubscriptionDetails.GetThirdPartyUserSubscriptionDetailsBuilder builder,
            string id,
            string namespace_,
            string userId
        )
        {
            GetThirdPartyUserSubscriptionDetails op = builder.Build(
                id,
                namespace_,
                userId
            );

            return await ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).GetThirdPartyUserSubscriptionDetailsAsync(op);
        }
        public static Platform.Model.ThirdPartyUserSubscriptionInfo? Execute(
            this SyncSubscription.SyncSubscriptionBuilder builder,
            string id,
            string namespace_,
            string userId
        )
        {
            SyncSubscription op = builder.Build(
                id,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).SyncSubscription(op);
        }
        public static async Task<Platform.Model.ThirdPartyUserSubscriptionInfo?> ExecuteAsync(
            this SyncSubscription.SyncSubscriptionBuilder builder,
            string id,
            string namespace_,
            string userId
        )
        {
            SyncSubscription op = builder.Build(
                id,
                namespace_,
                userId
            );

            return await ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).SyncSubscriptionAsync(op);
        }
        public static Platform.Model.ThirdPartyUserSubscriptionPagingSlicedResult? Execute(
            this PublicQueryUserThirdPartySubscription.PublicQueryUserThirdPartySubscriptionBuilder builder,
            string namespace_,
            string platform,
            string userId
        )
        {
            PublicQueryUserThirdPartySubscription op = builder.Build(
                namespace_,
                platform,
                userId
            );

            return ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).PublicQueryUserThirdPartySubscription(op);
        }
        public static async Task<Platform.Model.ThirdPartyUserSubscriptionPagingSlicedResult?> ExecuteAsync(
            this PublicQueryUserThirdPartySubscription.PublicQueryUserThirdPartySubscriptionBuilder builder,
            string namespace_,
            string platform,
            string userId
        )
        {
            PublicQueryUserThirdPartySubscription op = builder.Build(
                namespace_,
                platform,
                userId
            );

            return await ((Platform.Wrapper.IAPSubscription)builder.WrapperObject!).PublicQueryUserThirdPartySubscriptionAsync(op);
        }
    }
}