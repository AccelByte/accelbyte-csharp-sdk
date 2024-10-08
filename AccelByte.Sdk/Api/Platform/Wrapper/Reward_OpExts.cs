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
    public static class PlatformReward_OpExts
    {
        public static Platform.Model.RewardInfo? Execute(
            this CreateReward.CreateRewardBuilder builder,
            RewardCreate body,
            string namespace_
        )
        {
            CreateReward op = builder.Build(
                body,
                namespace_
            );

            return ((Platform.Wrapper.Reward)builder.WrapperObject!).CreateReward(op);
        }
        public static async Task<Platform.Model.RewardInfo?> ExecuteAsync(
            this CreateReward.CreateRewardBuilder builder,
            RewardCreate body,
            string namespace_
        )
        {
            CreateReward op = builder.Build(
                body,
                namespace_
            );

            return await ((Platform.Wrapper.Reward)builder.WrapperObject!).CreateRewardAsync(op);
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
        public static async Task<Platform.Model.RewardPagingSlicedResult?> ExecuteAsync(
            this QueryRewards.QueryRewardsBuilder builder,
            string namespace_
        )
        {
            QueryRewards op = builder.Build(
                namespace_
            );

            return await ((Platform.Wrapper.Reward)builder.WrapperObject!).QueryRewardsAsync(op);
        }
        public static Stream? Execute(
            this ExportRewards.ExportRewardsBuilder builder,
            string namespace_
        )
        {
            ExportRewards op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Reward)builder.WrapperObject!).ExportRewards(op);
        }
        public static async Task<Stream?> ExecuteAsync(
            this ExportRewards.ExportRewardsBuilder builder,
            string namespace_
        )
        {
            ExportRewards op = builder.Build(
                namespace_
            );

            return await ((Platform.Wrapper.Reward)builder.WrapperObject!).ExportRewardsAsync(op);
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
        public static async Task ExecuteAsync(
            this ImportRewards.ImportRewardsBuilder builder,
            string namespace_,
            bool replaceExisting
        )
        {
            ImportRewards op = builder.Build(
                namespace_,
                replaceExisting
            );

            await ((Platform.Wrapper.Reward)builder.WrapperObject!).ImportRewardsAsync(op);
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
        public static async Task<Platform.Model.RewardInfo?> ExecuteAsync(
            this GetReward.GetRewardBuilder builder,
            string namespace_,
            string rewardId
        )
        {
            GetReward op = builder.Build(
                namespace_,
                rewardId
            );

            return await ((Platform.Wrapper.Reward)builder.WrapperObject!).GetRewardAsync(op);
        }
        public static Platform.Model.RewardInfo? Execute(
            this UpdateReward.UpdateRewardBuilder builder,
            RewardUpdate body,
            string namespace_,
            string rewardId
        )
        {
            UpdateReward op = builder.Build(
                body,
                namespace_,
                rewardId
            );

            return ((Platform.Wrapper.Reward)builder.WrapperObject!).UpdateReward(op);
        }
        public static async Task<Platform.Model.RewardInfo?> ExecuteAsync(
            this UpdateReward.UpdateRewardBuilder builder,
            RewardUpdate body,
            string namespace_,
            string rewardId
        )
        {
            UpdateReward op = builder.Build(
                body,
                namespace_,
                rewardId
            );

            return await ((Platform.Wrapper.Reward)builder.WrapperObject!).UpdateRewardAsync(op);
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
        public static async Task<Platform.Model.RewardInfo?> ExecuteAsync(
            this DeleteReward.DeleteRewardBuilder builder,
            string namespace_,
            string rewardId
        )
        {
            DeleteReward op = builder.Build(
                namespace_,
                rewardId
            );

            return await ((Platform.Wrapper.Reward)builder.WrapperObject!).DeleteRewardAsync(op);
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
        public static async Task<Platform.Model.ConditionMatchResult?> ExecuteAsync(
            this CheckEventCondition.CheckEventConditionBuilder builder,
            string namespace_,
            string rewardId
        )
        {
            CheckEventCondition op = builder.Build(
                namespace_,
                rewardId
            );

            return await ((Platform.Wrapper.Reward)builder.WrapperObject!).CheckEventConditionAsync(op);
        }
        public static void Execute(
            this DeleteRewardConditionRecord.DeleteRewardConditionRecordBuilder builder,
            DeleteRewardConditionRequest body,
            string namespace_,
            string rewardId
        )
        {
            DeleteRewardConditionRecord op = builder.Build(
                body,
                namespace_,
                rewardId
            );

            ((Platform.Wrapper.Reward)builder.WrapperObject!).DeleteRewardConditionRecord(op);
        }
        public static async Task ExecuteAsync(
            this DeleteRewardConditionRecord.DeleteRewardConditionRecordBuilder builder,
            DeleteRewardConditionRequest body,
            string namespace_,
            string rewardId
        )
        {
            DeleteRewardConditionRecord op = builder.Build(
                body,
                namespace_,
                rewardId
            );

            await ((Platform.Wrapper.Reward)builder.WrapperObject!).DeleteRewardConditionRecordAsync(op);
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
        public static async Task<Platform.Model.RewardInfo?> ExecuteAsync(
            this GetRewardByCode.GetRewardByCodeBuilder builder,
            string namespace_,
            string rewardCode
        )
        {
            GetRewardByCode op = builder.Build(
                namespace_,
                rewardCode
            );

            return await ((Platform.Wrapper.Reward)builder.WrapperObject!).GetRewardByCodeAsync(op);
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
        public static async Task<Platform.Model.RewardPagingSlicedResult?> ExecuteAsync(
            this QueryRewards1.QueryRewards1Builder builder,
            string namespace_
        )
        {
            QueryRewards1 op = builder.Build(
                namespace_
            );

            return await ((Platform.Wrapper.Reward)builder.WrapperObject!).QueryRewards1Async(op);
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
        public static async Task<Platform.Model.RewardInfo?> ExecuteAsync(
            this GetReward1.GetReward1Builder builder,
            string namespace_,
            string rewardId
        )
        {
            GetReward1 op = builder.Build(
                namespace_,
                rewardId
            );

            return await ((Platform.Wrapper.Reward)builder.WrapperObject!).GetReward1Async(op);
        }
    }
}