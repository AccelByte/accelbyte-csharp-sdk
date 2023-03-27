// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Api.Achievement.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Achievement.Wrapper
{
    public class UserAchievements
    {
        private readonly AccelByteSDK _sdk;

        public UserAchievements(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminListUserAchievements.AdminListUserAchievementsBuilder AdminListUserAchievementsOp
        {
            get { return Operation.AdminListUserAchievements.Builder.SetWrapperObject(this); }
        }
        public AdminResetAchievement.AdminResetAchievementBuilder AdminResetAchievementOp
        {
            get { return Operation.AdminResetAchievement.Builder.SetWrapperObject(this); }
        }
        public AdminUnlockAchievement.AdminUnlockAchievementBuilder AdminUnlockAchievementOp
        {
            get { return Operation.AdminUnlockAchievement.Builder.SetWrapperObject(this); }
        }
        public PublicListUserAchievements.PublicListUserAchievementsBuilder PublicListUserAchievementsOp
        {
            get { return Operation.PublicListUserAchievements.Builder.SetWrapperObject(this); }
        }
        public PublicUnlockAchievement.PublicUnlockAchievementBuilder PublicUnlockAchievementOp
        {
            get { return Operation.PublicUnlockAchievement.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsPaginatedUserAchievementResponse? AdminListUserAchievements(AdminListUserAchievements input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminResetAchievement(AdminResetAchievement input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminUnlockAchievement(AdminUnlockAchievement input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedUserAchievementResponse? PublicListUserAchievements(PublicListUserAchievements input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicUnlockAchievement(PublicUnlockAchievement input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}