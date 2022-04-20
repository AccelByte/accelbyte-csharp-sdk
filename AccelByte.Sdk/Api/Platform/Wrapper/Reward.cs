// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Reward
    {
        private readonly AccelByteSDK _sdk;

        public Reward(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public CreateReward.CreateRewardBuilder CreateRewardOp
        {
            get { return Operation.CreateReward.Builder.SetWrapperObject(this); }
        }
        public QueryRewards.QueryRewardsBuilder QueryRewardsOp
        {
            get { return Operation.QueryRewards.Builder.SetWrapperObject(this); }
        }
        public ExportRewards.ExportRewardsBuilder ExportRewardsOp
        {
            get { return Operation.ExportRewards.Builder.SetWrapperObject(this); }
        }
        public ImportRewards.ImportRewardsBuilder ImportRewardsOp
        {
            get { return Operation.ImportRewards.Builder.SetWrapperObject(this); }
        }
        public GetReward.GetRewardBuilder GetRewardOp
        {
            get { return Operation.GetReward.Builder.SetWrapperObject(this); }
        }
        public UpdateReward.UpdateRewardBuilder UpdateRewardOp
        {
            get { return Operation.UpdateReward.Builder.SetWrapperObject(this); }
        }
        public DeleteReward.DeleteRewardBuilder DeleteRewardOp
        {
            get { return Operation.DeleteReward.Builder.SetWrapperObject(this); }
        }
        public CheckEventCondition.CheckEventConditionBuilder CheckEventConditionOp
        {
            get { return Operation.CheckEventCondition.Builder.SetWrapperObject(this); }
        }
        public GetRewardByCode.GetRewardByCodeBuilder GetRewardByCodeOp
        {
            get { return Operation.GetRewardByCode.Builder.SetWrapperObject(this); }
        }
        public QueryRewards1.QueryRewards1Builder QueryRewards1Op
        {
            get { return Operation.QueryRewards1.Builder.SetWrapperObject(this); }
        }
        public GetReward1.GetReward1Builder GetReward1Op
        {
            get { return Operation.GetReward1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.RewardInfo? CreateReward(CreateReward input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RewardPagingSlicedResult? QueryRewards(QueryRewards input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void ExportRewards(ExportRewards input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void ImportRewards(ImportRewards input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
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
        public Model.RewardInfo? UpdateReward(UpdateReward input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RewardInfo? DeleteReward(DeleteReward input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ConditionMatchResult? CheckEventCondition(CheckEventCondition input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RewardInfo? GetRewardByCode(GetRewardByCode input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RewardPagingSlicedResult? QueryRewards1(QueryRewards1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RewardInfo? GetReward1(GetReward1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}