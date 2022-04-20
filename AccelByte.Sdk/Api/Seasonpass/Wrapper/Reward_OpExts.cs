// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;
using AccelByte.Sdk.Api.Seasonpass.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SeasonpassReward_OpExts
    {
        public static List<Seasonpass.Model.RewardInfo>? Execute(
            this QueryRewards.QueryRewardsBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            QueryRewards op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Seasonpass.Wrapper.Reward)builder.WrapperObject!).QueryRewards(op);
        }

        public static Seasonpass.Model.RewardInfo? Execute(
            this CreateReward.CreateRewardBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            CreateReward op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Seasonpass.Wrapper.Reward)builder.WrapperObject!).CreateReward(op);
        }

        public static Seasonpass.Model.RewardInfo? Execute(
            this GetReward.GetRewardBuilder builder,
            string code,
            string namespace_,
            string seasonId
        )
        {
            GetReward op = builder.Build(
                code,
                namespace_,
                seasonId
            );

            return ((Seasonpass.Wrapper.Reward)builder.WrapperObject!).GetReward(op);
        }

        public static void Execute(
            this DeleteReward.DeleteRewardBuilder builder,
            string code,
            string namespace_,
            string seasonId
        )
        {
            DeleteReward op = builder.Build(
                code,
                namespace_,
                seasonId
            );

            ((Seasonpass.Wrapper.Reward)builder.WrapperObject!).DeleteReward(op);
        }

        public static Seasonpass.Model.RewardInfo? Execute(
            this UpdateReward.UpdateRewardBuilder builder,
            string code,
            string namespace_,
            string seasonId
        )
        {
            UpdateReward op = builder.Build(
                code,
                namespace_,
                seasonId
            );

            return ((Seasonpass.Wrapper.Reward)builder.WrapperObject!).UpdateReward(op);
        }

        public static Seasonpass.Model.ClaimableRewards? Execute(
            this PublicClaimUserReward.PublicClaimUserRewardBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicClaimUserReward op = builder.Build(
                namespace_,
                userId
            );

            return ((Seasonpass.Wrapper.Reward)builder.WrapperObject!).PublicClaimUserReward(op);
        }

        public static Seasonpass.Model.ClaimableRewards? Execute(
            this PublicBulkClaimUserRewards.PublicBulkClaimUserRewardsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicBulkClaimUserRewards op = builder.Build(
                namespace_,
                userId
            );

            return ((Seasonpass.Wrapper.Reward)builder.WrapperObject!).PublicBulkClaimUserRewards(op);
        }

    }
}