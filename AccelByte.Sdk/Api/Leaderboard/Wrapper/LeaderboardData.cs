// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Leaderboard.Wrapper
{
    public class LeaderboardData {
        private readonly AccelByteSDK _sdk;

        public LeaderboardData(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public List<Model.ModelsArchiveLeaderboardSignedURLResponse>? AdminGetArchivedLeaderboardRankingDataV1Handler(AdminGetArchivedLeaderboardRankingDataV1Handler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void CreateArchivedLeaderboardRankingDataV1Handler(CreateArchivedLeaderboardRankingDataV1Handler input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardRankingResp? GetAllTimeLeaderboardRankingAdminV1(GetAllTimeLeaderboardRankingAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardRankingResp? GetCurrentMonthLeaderboardRankingAdminV1(GetCurrentMonthLeaderboardRankingAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardRankingResp? GetCurrentSeasonLeaderboardRankingAdminV1(GetCurrentSeasonLeaderboardRankingAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardRankingResp? GetTodayLeaderboardRankingAdminV1(GetTodayLeaderboardRankingAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUserRankingResponse? GetUserRankingAdminV1(GetUserRankingAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateUserPointAdminV1Response? UpdateUserPointAdminV1(UpdateUserPointAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserRankingAdminV1(DeleteUserRankingAdminV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardRankingResp? GetCurrentWeekLeaderboardRankingAdminV1(GetCurrentWeekLeaderboardRankingAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserRankingsAdminV1(DeleteUserRankingsAdminV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardRankingResp? GetAllTimeLeaderboardRankingPublicV1(GetAllTimeLeaderboardRankingPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsArchiveLeaderboardSignedURLResponse>? GetArchivedLeaderboardRankingDataV1Handler(GetArchivedLeaderboardRankingDataV1Handler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardRankingResp? GetCurrentMonthLeaderboardRankingPublicV1(GetCurrentMonthLeaderboardRankingPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardRankingResp? GetCurrentSeasonLeaderboardRankingPublicV1(GetCurrentSeasonLeaderboardRankingPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardRankingResp? GetTodayLeaderboardRankingPublicV1(GetTodayLeaderboardRankingPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUserRankingResponse? GetUserRankingPublicV1(GetUserRankingPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserRankingPublicV1(DeleteUserRankingPublicV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardRankingResp? GetCurrentWeekLeaderboardRankingPublicV1(GetCurrentWeekLeaderboardRankingPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.V2GetPublicLeaderboardRankingResponse? GetAllTimeLeaderboardRankingPublicV2(GetAllTimeLeaderboardRankingPublicV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}