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
    public static class PlatformFulfillment_OpExts
    {
        public static Platform.Model.FulfillmentHistoryPagingSlicedResult? Execute(
            this QueryFulfillmentHistories.QueryFulfillmentHistoriesBuilder builder,
            string namespace_
        )
        {
            QueryFulfillmentHistories op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).QueryFulfillmentHistories(op);
        }
        public static async Task<Platform.Model.FulfillmentHistoryPagingSlicedResult?> ExecuteAsync(
            this QueryFulfillmentHistories.QueryFulfillmentHistoriesBuilder builder,
            string namespace_
        )
        {
            QueryFulfillmentHistories op = builder.Build(
                namespace_
            );

            return await ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).QueryFulfillmentHistoriesAsync(op);
        }
        public static Platform.Model.FulfillmentResult? Execute(
            this FulfillItem.FulfillItemBuilder builder,
            FulfillmentRequest body,
            string namespace_,
            string userId
        )
        {
            FulfillItem op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).FulfillItem(op);
        }
        public static async Task<Platform.Model.FulfillmentResult?> ExecuteAsync(
            this FulfillItem.FulfillItemBuilder builder,
            FulfillmentRequest body,
            string namespace_,
            string userId
        )
        {
            FulfillItem op = builder.Build(
                body,
                namespace_,
                userId
            );

            return await ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).FulfillItemAsync(op);
        }
        public static Platform.Model.FulfillmentResult? Execute(
            this RedeemCode.RedeemCodeBuilder builder,
            FulfillCodeRequest body,
            string namespace_,
            string userId
        )
        {
            RedeemCode op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).RedeemCode(op);
        }
        public static async Task<Platform.Model.FulfillmentResult?> ExecuteAsync(
            this RedeemCode.RedeemCodeBuilder builder,
            FulfillCodeRequest body,
            string namespace_,
            string userId
        )
        {
            RedeemCode op = builder.Build(
                body,
                namespace_,
                userId
            );

            return await ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).RedeemCodeAsync(op);
        }
        public static List<Platform.Model.FulfillmentItem>? Execute(
            this PreCheckFulfillItem.PreCheckFulfillItemBuilder builder,
            PreCheckFulfillmentRequest body,
            string namespace_,
            string userId
        )
        {
            PreCheckFulfillItem op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).PreCheckFulfillItem(op);
        }
        public static async Task<List<Platform.Model.FulfillmentItem>?> ExecuteAsync(
            this PreCheckFulfillItem.PreCheckFulfillItemBuilder builder,
            PreCheckFulfillmentRequest body,
            string namespace_,
            string userId
        )
        {
            PreCheckFulfillItem op = builder.Build(
                body,
                namespace_,
                userId
            );

            return await ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).PreCheckFulfillItemAsync(op);
        }
        public static void Execute(
            this FulfillRewards.FulfillRewardsBuilder builder,
            RewardsRequest body,
            string namespace_,
            string userId
        )
        {
            FulfillRewards op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).FulfillRewards(op);
        }
        public static async Task ExecuteAsync(
            this FulfillRewards.FulfillRewardsBuilder builder,
            RewardsRequest body,
            string namespace_,
            string userId
        )
        {
            FulfillRewards op = builder.Build(
                body,
                namespace_,
                userId
            );

            await ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).FulfillRewardsAsync(op);
        }
        public static Platform.Model.FulfillmentResult? Execute(
            this PublicRedeemCode.PublicRedeemCodeBuilder builder,
            FulfillCodeRequest body,
            string namespace_,
            string userId
        )
        {
            PublicRedeemCode op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).PublicRedeemCode(op);
        }
        public static async Task<Platform.Model.FulfillmentResult?> ExecuteAsync(
            this PublicRedeemCode.PublicRedeemCodeBuilder builder,
            FulfillCodeRequest body,
            string namespace_,
            string userId
        )
        {
            PublicRedeemCode op = builder.Build(
                body,
                namespace_,
                userId
            );

            return await ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).PublicRedeemCodeAsync(op);
        }
        public static Platform.Model.FulfillmentPagingSlicedResult? Execute(
            this QueryFulfillments.QueryFulfillmentsBuilder builder,
            string namespace_
        )
        {
            QueryFulfillments op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).QueryFulfillments(op);
        }
        public static async Task<Platform.Model.FulfillmentPagingSlicedResult?> ExecuteAsync(
            this QueryFulfillments.QueryFulfillmentsBuilder builder,
            string namespace_
        )
        {
            QueryFulfillments op = builder.Build(
                namespace_
            );

            return await ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).QueryFulfillmentsAsync(op);
        }
        public static Platform.Model.FulfillmentResult? Execute(
            this FulfillRewardsV2.FulfillRewardsV2Builder builder,
            RewardsRequest body,
            string namespace_,
            string userId
        )
        {
            FulfillRewardsV2 op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).FulfillRewardsV2(op);
        }
        public static async Task<Platform.Model.FulfillmentResult?> ExecuteAsync(
            this FulfillRewardsV2.FulfillRewardsV2Builder builder,
            RewardsRequest body,
            string namespace_,
            string userId
        )
        {
            FulfillRewardsV2 op = builder.Build(
                body,
                namespace_,
                userId
            );

            return await ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).FulfillRewardsV2Async(op);
        }
        public static Platform.Model.FulfillmentV2Result? Execute(
            this FulfillItems.FulfillItemsBuilder builder,
            FulfillmentV2Request body,
            string namespace_,
            string transactionId,
            string userId
        )
        {
            FulfillItems op = builder.Build(
                body,
                namespace_,
                transactionId,
                userId
            );

            return ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).FulfillItems(op);
        }
        public static async Task<Platform.Model.FulfillmentV2Result?> ExecuteAsync(
            this FulfillItems.FulfillItemsBuilder builder,
            FulfillmentV2Request body,
            string namespace_,
            string transactionId,
            string userId
        )
        {
            FulfillItems op = builder.Build(
                body,
                namespace_,
                transactionId,
                userId
            );

            return await ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).FulfillItemsAsync(op);
        }
        public static Platform.Model.FulfillmentV2Result? Execute(
            this RetryFulfillItems.RetryFulfillItemsBuilder builder,
            string namespace_,
            string transactionId,
            string userId
        )
        {
            RetryFulfillItems op = builder.Build(
                namespace_,
                transactionId,
                userId
            );

            return ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).RetryFulfillItems(op);
        }
        public static async Task<Platform.Model.FulfillmentV2Result?> ExecuteAsync(
            this RetryFulfillItems.RetryFulfillItemsBuilder builder,
            string namespace_,
            string transactionId,
            string userId
        )
        {
            RetryFulfillItems op = builder.Build(
                namespace_,
                transactionId,
                userId
            );

            return await ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).RetryFulfillItemsAsync(op);
        }
        public static Platform.Model.RevokeFulfillmentV2Result? Execute(
            this RevokeItems.RevokeItemsBuilder builder,
            string namespace_,
            string transactionId,
            string userId
        )
        {
            RevokeItems op = builder.Build(
                namespace_,
                transactionId,
                userId
            );

            return ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).RevokeItems(op);
        }
        public static async Task<Platform.Model.RevokeFulfillmentV2Result?> ExecuteAsync(
            this RevokeItems.RevokeItemsBuilder builder,
            string namespace_,
            string transactionId,
            string userId
        )
        {
            RevokeItems op = builder.Build(
                namespace_,
                transactionId,
                userId
            );

            return await ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).RevokeItemsAsync(op);
        }
    }
}