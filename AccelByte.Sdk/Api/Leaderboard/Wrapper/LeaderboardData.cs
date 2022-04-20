// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Leaderboard.Wrapper
{
    public class LeaderboardData
    {
        private readonly AccelByteSDK _sdk;

        public LeaderboardData(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetArchivedLeaderboardRankingDataV1Handler.AdminGetArchivedLeaderboardRankingDataV1HandlerBuilder AdminGetArchivedLeaderboardRankingDataV1HandlerOp
        {
            get { return Operation.AdminGetArchivedLeaderboardRankingDataV1Handler.Builder.SetWrapperObject(this); }
        }
        public CreateArchivedLeaderboardRankingDataV1Handler.CreateArchivedLeaderboardRankingDataV1HandlerBuilder CreateArchivedLeaderboardRankingDataV1HandlerOp
        {
            get { return Operation.CreateArchivedLeaderboardRankingDataV1Handler.Builder.SetWrapperObject(this); }
        }
        public GetAllTimeLeaderboardRankingAdminV1.GetAllTimeLeaderboardRankingAdminV1Builder GetAllTimeLeaderboardRankingAdminV1Op
        {
            get { return Operation.GetAllTimeLeaderboardRankingAdminV1.Builder.SetWrapperObject(this); }
        }
        public GetCurrentMonthLeaderboardRankingAdminV1.GetCurrentMonthLeaderboardRankingAdminV1Builder GetCurrentMonthLeaderboardRankingAdminV1Op
        {
            get { return Operation.GetCurrentMonthLeaderboardRankingAdminV1.Builder.SetWrapperObject(this); }
        }
        public GetCurrentSeasonLeaderboardRankingAdminV1.GetCurrentSeasonLeaderboardRankingAdminV1Builder GetCurrentSeasonLeaderboardRankingAdminV1Op
        {
            get { return Operation.GetCurrentSeasonLeaderboardRankingAdminV1.Builder.SetWrapperObject(this); }
        }
        public GetTodayLeaderboardRankingAdminV1.GetTodayLeaderboardRankingAdminV1Builder GetTodayLeaderboardRankingAdminV1Op
        {
            get { return Operation.GetTodayLeaderboardRankingAdminV1.Builder.SetWrapperObject(this); }
        }
        public GetUserRankingAdminV1.GetUserRankingAdminV1Builder GetUserRankingAdminV1Op
        {
            get { return Operation.GetUserRankingAdminV1.Builder.SetWrapperObject(this); }
        }
        public UpdateUserPointAdminV1.UpdateUserPointAdminV1Builder UpdateUserPointAdminV1Op
        {
            get { return Operation.UpdateUserPointAdminV1.Builder.SetWrapperObject(this); }
        }
        public DeleteUserRankingAdminV1.DeleteUserRankingAdminV1Builder DeleteUserRankingAdminV1Op
        {
            get { return Operation.DeleteUserRankingAdminV1.Builder.SetWrapperObject(this); }
        }
        public GetCurrentWeekLeaderboardRankingAdminV1.GetCurrentWeekLeaderboardRankingAdminV1Builder GetCurrentWeekLeaderboardRankingAdminV1Op
        {
            get { return Operation.GetCurrentWeekLeaderboardRankingAdminV1.Builder.SetWrapperObject(this); }
        }
        public DeleteUserRankingsAdminV1.DeleteUserRankingsAdminV1Builder DeleteUserRankingsAdminV1Op
        {
            get { return Operation.DeleteUserRankingsAdminV1.Builder.SetWrapperObject(this); }
        }
        public GetAllTimeLeaderboardRankingPublicV1.GetAllTimeLeaderboardRankingPublicV1Builder GetAllTimeLeaderboardRankingPublicV1Op
        {
            get { return Operation.GetAllTimeLeaderboardRankingPublicV1.Builder.SetWrapperObject(this); }
        }
        public GetArchivedLeaderboardRankingDataV1Handler.GetArchivedLeaderboardRankingDataV1HandlerBuilder GetArchivedLeaderboardRankingDataV1HandlerOp
        {
            get { return Operation.GetArchivedLeaderboardRankingDataV1Handler.Builder.SetWrapperObject(this); }
        }
        public GetCurrentMonthLeaderboardRankingPublicV1.GetCurrentMonthLeaderboardRankingPublicV1Builder GetCurrentMonthLeaderboardRankingPublicV1Op
        {
            get { return Operation.GetCurrentMonthLeaderboardRankingPublicV1.Builder.SetWrapperObject(this); }
        }
        public GetCurrentSeasonLeaderboardRankingPublicV1.GetCurrentSeasonLeaderboardRankingPublicV1Builder GetCurrentSeasonLeaderboardRankingPublicV1Op
        {
            get { return Operation.GetCurrentSeasonLeaderboardRankingPublicV1.Builder.SetWrapperObject(this); }
        }
        public GetTodayLeaderboardRankingPublicV1.GetTodayLeaderboardRankingPublicV1Builder GetTodayLeaderboardRankingPublicV1Op
        {
            get { return Operation.GetTodayLeaderboardRankingPublicV1.Builder.SetWrapperObject(this); }
        }
        public GetUserRankingPublicV1.GetUserRankingPublicV1Builder GetUserRankingPublicV1Op
        {
            get { return Operation.GetUserRankingPublicV1.Builder.SetWrapperObject(this); }
        }
        public DeleteUserRankingPublicV1.DeleteUserRankingPublicV1Builder DeleteUserRankingPublicV1Op
        {
            get { return Operation.DeleteUserRankingPublicV1.Builder.SetWrapperObject(this); }
        }
        public GetCurrentWeekLeaderboardRankingPublicV1.GetCurrentWeekLeaderboardRankingPublicV1Builder GetCurrentWeekLeaderboardRankingPublicV1Op
        {
            get { return Operation.GetCurrentWeekLeaderboardRankingPublicV1.Builder.SetWrapperObject(this); }
        }
        public GetAllTimeLeaderboardRankingPublicV2.GetAllTimeLeaderboardRankingPublicV2Builder GetAllTimeLeaderboardRankingPublicV2Op
        {
            get { return Operation.GetAllTimeLeaderboardRankingPublicV2.Builder.SetWrapperObject(this); }
        }
        #endregion
        
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