// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Api.Achievement.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Achievement.Wrapper
{
    public class Achievements
    {
        private readonly AccelByteSDK _sdk;

        public Achievements(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminListAchievements.AdminListAchievementsBuilder AdminListAchievementsOp
        {
            get { return Operation.AdminListAchievements.Builder.SetWrapperObject(this); }
        }
        public AdminCreateNewAchievement.AdminCreateNewAchievementBuilder AdminCreateNewAchievementOp
        {
            get { return Operation.AdminCreateNewAchievement.Builder.SetWrapperObject(this); }
        }
        public ExportAchievements.ExportAchievementsBuilder ExportAchievementsOp
        {
            get { return Operation.ExportAchievements.Builder.SetWrapperObject(this); }
        }
        public ImportAchievements.ImportAchievementsBuilder ImportAchievementsOp
        {
            get { return Operation.ImportAchievements.Builder.SetWrapperObject(this); }
        }
        public AdminGetAchievement.AdminGetAchievementBuilder AdminGetAchievementOp
        {
            get { return Operation.AdminGetAchievement.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateAchievement.AdminUpdateAchievementBuilder AdminUpdateAchievementOp
        {
            get { return Operation.AdminUpdateAchievement.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteAchievement.AdminDeleteAchievementBuilder AdminDeleteAchievementOp
        {
            get { return Operation.AdminDeleteAchievement.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateAchievementListOrder.AdminUpdateAchievementListOrderBuilder AdminUpdateAchievementListOrderOp
        {
            get { return Operation.AdminUpdateAchievementListOrder.Builder.SetWrapperObject(this); }
        }
        public AdminListUserAchievements.AdminListUserAchievementsBuilder AdminListUserAchievementsOp
        {
            get { return Operation.AdminListUserAchievements.Builder.SetWrapperObject(this); }
        }
        public AdminUnlockAchievement.AdminUnlockAchievementBuilder AdminUnlockAchievementOp
        {
            get { return Operation.AdminUnlockAchievement.Builder.SetWrapperObject(this); }
        }
        public PublicListAchievements.PublicListAchievementsBuilder PublicListAchievementsOp
        {
            get { return Operation.PublicListAchievements.Builder.SetWrapperObject(this); }
        }
        public PublicGetAchievement.PublicGetAchievementBuilder PublicGetAchievementOp
        {
            get { return Operation.PublicGetAchievement.Builder.SetWrapperObject(this); }
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
        
        public Model.ModelsPaginatedAchievementResponse? AdminListAchievements(AdminListAchievements input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsAchievementResponse? AdminCreateNewAchievement(AdminCreateNewAchievement input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsAchievement>? ExportAchievements(ExportAchievements input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ServiceImportConfigResponse? ImportAchievements(ImportAchievements input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsAchievementResponse? AdminGetAchievement(AdminGetAchievement input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsAchievementResponse? AdminUpdateAchievement(AdminUpdateAchievement input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteAchievement(AdminDeleteAchievement input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminUpdateAchievementListOrder(AdminUpdateAchievementListOrder input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedUserAchievementResponse? AdminListUserAchievements(AdminListUserAchievements input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
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
        public Model.ModelsPublicAchievementsResponse? PublicListAchievements(PublicListAchievements input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPublicAchievementResponse? PublicGetAchievement(PublicGetAchievement input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedUserAchievementResponse? PublicListUserAchievements(PublicListUserAchievements input) {
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