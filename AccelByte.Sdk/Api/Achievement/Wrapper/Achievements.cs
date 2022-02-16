// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Api.Achievement.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Achievement.Wrapper
{
    public class Achievements {
        private readonly AccelByteSDK _sdk;

        public Achievements(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
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