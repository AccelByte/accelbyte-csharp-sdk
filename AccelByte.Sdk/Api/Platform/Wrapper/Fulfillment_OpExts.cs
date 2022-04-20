// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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

        public static Platform.Model.FulfillmentResult? Execute(
            this FulfillItem.FulfillItemBuilder builder,
            string namespace_,
            string userId
        )
        {
            FulfillItem op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).FulfillItem(op);
        }

        public static Platform.Model.FulfillmentResult? Execute(
            this RedeemCode.RedeemCodeBuilder builder,
            string namespace_,
            string userId
        )
        {
            RedeemCode op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).RedeemCode(op);
        }

        public static void Execute(
            this FulfillRewards.FulfillRewardsBuilder builder,
            string namespace_,
            string userId
        )
        {
            FulfillRewards op = builder.Build(
                namespace_,
                userId
            );

            ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).FulfillRewards(op);
        }

        public static Platform.Model.FulfillmentResult? Execute(
            this PublicRedeemCode.PublicRedeemCodeBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicRedeemCode op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Fulfillment)builder.WrapperObject!).PublicRedeemCode(op);
        }

    }
}