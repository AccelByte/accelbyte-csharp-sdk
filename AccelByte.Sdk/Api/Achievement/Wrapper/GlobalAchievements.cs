// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Api.Achievement.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Achievement.Wrapper
{
    public class GlobalAchievements
    {
        private readonly AccelByteSDK _sdk;

        public GlobalAchievements(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminListGlobalAchievements.AdminListGlobalAchievementsBuilder AdminListGlobalAchievementsOp
        {
            get { return Operation.AdminListGlobalAchievements.Builder.SetWrapperObject(this); }
        }
        public AdminListGlobalAchievementContributors.AdminListGlobalAchievementContributorsBuilder AdminListGlobalAchievementContributorsOp
        {
            get { return Operation.AdminListGlobalAchievementContributors.Builder.SetWrapperObject(this); }
        }
        public ResetGlobalAchievement.ResetGlobalAchievementBuilder ResetGlobalAchievementOp
        {
            get { return Operation.ResetGlobalAchievement.Builder.SetWrapperObject(this); }
        }
        public AdminListUserContributions.AdminListUserContributionsBuilder AdminListUserContributionsOp
        {
            get { return Operation.AdminListUserContributions.Builder.SetWrapperObject(this); }
        }
        public PublicListGlobalAchievements.PublicListGlobalAchievementsBuilder PublicListGlobalAchievementsOp
        {
            get { return Operation.PublicListGlobalAchievements.Builder.SetWrapperObject(this); }
        }
        public ListGlobalAchievementContributors.ListGlobalAchievementContributorsBuilder ListGlobalAchievementContributorsOp
        {
            get { return Operation.ListGlobalAchievementContributors.Builder.SetWrapperObject(this); }
        }
        public ListUserContributions.ListUserContributionsBuilder ListUserContributionsOp
        {
            get { return Operation.ListUserContributions.Builder.SetWrapperObject(this); }
        }
        public ClaimGlobalAchievementReward.ClaimGlobalAchievementRewardBuilder ClaimGlobalAchievementRewardOp
        {
            get { return Operation.ClaimGlobalAchievementReward.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsPaginatedGlobalAchievementResponse? AdminListGlobalAchievements(AdminListGlobalAchievements input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPaginatedGlobalAchievementResponse?> AdminListGlobalAchievementsAsync(AdminListGlobalAchievements input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContributorResponse? AdminListGlobalAchievementContributors(AdminListGlobalAchievementContributors input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPaginatedContributorResponse?> AdminListGlobalAchievementContributorsAsync(AdminListGlobalAchievementContributors input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void ResetGlobalAchievement(ResetGlobalAchievement input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task ResetGlobalAchievementAsync(ResetGlobalAchievement input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedUserContributionResponse? AdminListUserContributions(AdminListUserContributions input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPaginatedUserContributionResponse?> AdminListUserContributionsAsync(AdminListUserContributions input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedGlobalAchievementResponse? PublicListGlobalAchievements(PublicListGlobalAchievements input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPaginatedGlobalAchievementResponse?> PublicListGlobalAchievementsAsync(PublicListGlobalAchievements input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContributorResponse? ListGlobalAchievementContributors(ListGlobalAchievementContributors input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPaginatedContributorResponse?> ListGlobalAchievementContributorsAsync(ListGlobalAchievementContributors input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedUserContributionResponse? ListUserContributions(ListUserContributions input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPaginatedUserContributionResponse?> ListUserContributionsAsync(ListUserContributions input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void ClaimGlobalAchievementReward(ClaimGlobalAchievementReward input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task ClaimGlobalAchievementRewardAsync(ClaimGlobalAchievementReward input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}