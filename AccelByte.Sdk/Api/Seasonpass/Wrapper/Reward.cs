// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Seasonpass.Wrapper
{
    public class Reward
    {
        private readonly AccelByteSDK _sdk;

        public Reward(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QueryRewards.QueryRewardsBuilder QueryRewardsOp
        {
            get { return Operation.QueryRewards.Builder.SetWrapperObject(this); }
        }
        public CreateReward.CreateRewardBuilder CreateRewardOp
        {
            get { return Operation.CreateReward.Builder.SetWrapperObject(this); }
        }
        public GetReward.GetRewardBuilder GetRewardOp
        {
            get { return Operation.GetReward.Builder.SetWrapperObject(this); }
        }
        public DeleteReward.DeleteRewardBuilder DeleteRewardOp
        {
            get { return Operation.DeleteReward.Builder.SetWrapperObject(this); }
        }
        public UpdateReward.UpdateRewardBuilder UpdateRewardOp
        {
            get { return Operation.UpdateReward.Builder.SetWrapperObject(this); }
        }
        public PublicClaimUserReward.PublicClaimUserRewardBuilder PublicClaimUserRewardOp
        {
            get { return Operation.PublicClaimUserReward.Builder.SetWrapperObject(this); }
        }
        public PublicBulkClaimUserRewards.PublicBulkClaimUserRewardsBuilder PublicBulkClaimUserRewardsOp
        {
            get { return Operation.PublicBulkClaimUserRewards.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.RewardInfo>? QueryRewards(QueryRewards input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RewardInfo? CreateReward(CreateReward input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RewardInfo? GetReward(GetReward input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteReward(DeleteReward input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RewardInfo? UpdateReward(UpdateReward input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ClaimableRewards? PublicClaimUserReward(PublicClaimUserReward input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ClaimableRewards? PublicBulkClaimUserRewards(PublicBulkClaimUserRewards input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Reward_OperationExtensions
    {
        public static List<Model.RewardInfo>? Execute(
            this QueryRewards.QueryRewardsBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            QueryRewards op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Reward)builder.WrapperObject!).QueryRewards(op);
        }

        public static Model.RewardInfo? Execute(
            this CreateReward.CreateRewardBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            CreateReward op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Reward)builder.WrapperObject!).CreateReward(op);
        }

        public static Model.RewardInfo? Execute(
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

            return ((Reward)builder.WrapperObject!).GetReward(op);
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

            ((Reward)builder.WrapperObject!).DeleteReward(op);
        }

        public static Model.RewardInfo? Execute(
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

            return ((Reward)builder.WrapperObject!).UpdateReward(op);
        }

        public static Model.ClaimableRewards? Execute(
            this PublicClaimUserReward.PublicClaimUserRewardBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicClaimUserReward op = builder.Build(
                namespace_,
                userId
            );

            return ((Reward)builder.WrapperObject!).PublicClaimUserReward(op);
        }

        public static Model.ClaimableRewards? Execute(
            this PublicBulkClaimUserRewards.PublicBulkClaimUserRewardsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicBulkClaimUserRewards op = builder.Build(
                namespace_,
                userId
            );

            return ((Reward)builder.WrapperObject!).PublicBulkClaimUserRewards(op);
        }

    }
}