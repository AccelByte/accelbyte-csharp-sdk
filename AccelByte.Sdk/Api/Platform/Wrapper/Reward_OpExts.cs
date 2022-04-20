// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformReward_OpExts
    {
        public static Platform.Model.RewardInfo? Execute(
            this CreateReward.CreateRewardBuilder builder,
            string namespace_
        )
        {
            CreateReward op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Reward)builder.WrapperObject!).CreateReward(op);
        }

        public static Platform.Model.RewardPagingSlicedResult? Execute(
            this QueryRewards.QueryRewardsBuilder builder,
            string namespace_
        )
        {
            QueryRewards op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Reward)builder.WrapperObject!).QueryRewards(op);
        }

        public static void Execute(
            this ExportRewards.ExportRewardsBuilder builder,
            string namespace_
        )
        {
            ExportRewards op = builder.Build(
                namespace_
            );

            ((Platform.Wrapper.Reward)builder.WrapperObject!).ExportRewards(op);
        }

        public static void Execute(
            this ImportRewards.ImportRewardsBuilder builder,
            string namespace_,
            bool replaceExisting
        )
        {
            ImportRewards op = builder.Build(
                namespace_,
                replaceExisting
            );

            ((Platform.Wrapper.Reward)builder.WrapperObject!).ImportRewards(op);
        }

        public static Platform.Model.RewardInfo? Execute(
            this GetReward.GetRewardBuilder builder,
            string namespace_,
            string rewardId
        )
        {
            GetReward op = builder.Build(
                namespace_,
                rewardId
            );

            return ((Platform.Wrapper.Reward)builder.WrapperObject!).GetReward(op);
        }

        public static Platform.Model.RewardInfo? Execute(
            this UpdateReward.UpdateRewardBuilder builder,
            string namespace_,
            string rewardId
        )
        {
            UpdateReward op = builder.Build(
                namespace_,
                rewardId
            );

            return ((Platform.Wrapper.Reward)builder.WrapperObject!).UpdateReward(op);
        }

        public static Platform.Model.RewardInfo? Execute(
            this DeleteReward.DeleteRewardBuilder builder,
            string namespace_,
            string rewardId
        )
        {
            DeleteReward op = builder.Build(
                namespace_,
                rewardId
            );

            return ((Platform.Wrapper.Reward)builder.WrapperObject!).DeleteReward(op);
        }

        public static Platform.Model.ConditionMatchResult? Execute(
            this CheckEventCondition.CheckEventConditionBuilder builder,
            string namespace_,
            string rewardId
        )
        {
            CheckEventCondition op = builder.Build(
                namespace_,
                rewardId
            );

            return ((Platform.Wrapper.Reward)builder.WrapperObject!).CheckEventCondition(op);
        }

        public static Platform.Model.RewardInfo? Execute(
            this GetRewardByCode.GetRewardByCodeBuilder builder,
            string namespace_,
            string rewardCode
        )
        {
            GetRewardByCode op = builder.Build(
                namespace_,
                rewardCode
            );

            return ((Platform.Wrapper.Reward)builder.WrapperObject!).GetRewardByCode(op);
        }

        public static Platform.Model.RewardPagingSlicedResult? Execute(
            this QueryRewards1.QueryRewards1Builder builder,
            string namespace_
        )
        {
            QueryRewards1 op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Reward)builder.WrapperObject!).QueryRewards1(op);
        }

        public static Platform.Model.RewardInfo? Execute(
            this GetReward1.GetReward1Builder builder,
            string namespace_,
            string rewardId
        )
        {
            GetReward1 op = builder.Build(
                namespace_,
                rewardId
            );

            return ((Platform.Wrapper.Reward)builder.WrapperObject!).GetReward1(op);
        }

    }
}