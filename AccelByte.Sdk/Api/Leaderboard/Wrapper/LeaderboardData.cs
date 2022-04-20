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

    public static class LeaderboardData_OperationExtensions
    {
        public static List<Model.ModelsArchiveLeaderboardSignedURLResponse>? Execute(
            this AdminGetArchivedLeaderboardRankingDataV1Handler.AdminGetArchivedLeaderboardRankingDataV1HandlerBuilder builder,
            string namespace_,
            string leaderboardCodes
        )
        {
            AdminGetArchivedLeaderboardRankingDataV1Handler op = builder.Build(
                namespace_,
                leaderboardCodes
            );

            return ((LeaderboardData)builder.WrapperObject!).AdminGetArchivedLeaderboardRankingDataV1Handler(op);
        }

        public static void Execute(
            this CreateArchivedLeaderboardRankingDataV1Handler.CreateArchivedLeaderboardRankingDataV1HandlerBuilder builder,
            ModelsArchiveLeaderboardReq body,
            string namespace_
        )
        {
            CreateArchivedLeaderboardRankingDataV1Handler op = builder.Build(
                body,
                namespace_
            );

            ((LeaderboardData)builder.WrapperObject!).CreateArchivedLeaderboardRankingDataV1Handler(op);
        }

        public static Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetAllTimeLeaderboardRankingAdminV1.GetAllTimeLeaderboardRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetAllTimeLeaderboardRankingAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((LeaderboardData)builder.WrapperObject!).GetAllTimeLeaderboardRankingAdminV1(op);
        }

        public static Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetCurrentMonthLeaderboardRankingAdminV1.GetCurrentMonthLeaderboardRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentMonthLeaderboardRankingAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((LeaderboardData)builder.WrapperObject!).GetCurrentMonthLeaderboardRankingAdminV1(op);
        }

        public static Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetCurrentSeasonLeaderboardRankingAdminV1.GetCurrentSeasonLeaderboardRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentSeasonLeaderboardRankingAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((LeaderboardData)builder.WrapperObject!).GetCurrentSeasonLeaderboardRankingAdminV1(op);
        }

        public static Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetTodayLeaderboardRankingAdminV1.GetTodayLeaderboardRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetTodayLeaderboardRankingAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((LeaderboardData)builder.WrapperObject!).GetTodayLeaderboardRankingAdminV1(op);
        }

        public static Model.ModelsUserRankingResponse? Execute(
            this GetUserRankingAdminV1.GetUserRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            GetUserRankingAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_,
                userId
            );

            return ((LeaderboardData)builder.WrapperObject!).GetUserRankingAdminV1(op);
        }

        public static Model.ModelsUpdateUserPointAdminV1Response? Execute(
            this UpdateUserPointAdminV1.UpdateUserPointAdminV1Builder builder,
            ModelsUpdateUserPointAdminV1Request body,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            UpdateUserPointAdminV1 op = builder.Build(
                body,
                leaderboardCode,
                namespace_,
                userId
            );

            return ((LeaderboardData)builder.WrapperObject!).UpdateUserPointAdminV1(op);
        }

        public static void Execute(
            this DeleteUserRankingAdminV1.DeleteUserRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            DeleteUserRankingAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_,
                userId
            );

            ((LeaderboardData)builder.WrapperObject!).DeleteUserRankingAdminV1(op);
        }

        public static Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetCurrentWeekLeaderboardRankingAdminV1.GetCurrentWeekLeaderboardRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentWeekLeaderboardRankingAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((LeaderboardData)builder.WrapperObject!).GetCurrentWeekLeaderboardRankingAdminV1(op);
        }

        public static void Execute(
            this DeleteUserRankingsAdminV1.DeleteUserRankingsAdminV1Builder builder,
            string namespace_,
            string userId,
            List<string> leaderboardCode
        )
        {
            DeleteUserRankingsAdminV1 op = builder.Build(
                namespace_,
                userId,
                leaderboardCode
            );

            ((LeaderboardData)builder.WrapperObject!).DeleteUserRankingsAdminV1(op);
        }

        public static Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetAllTimeLeaderboardRankingPublicV1.GetAllTimeLeaderboardRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetAllTimeLeaderboardRankingPublicV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((LeaderboardData)builder.WrapperObject!).GetAllTimeLeaderboardRankingPublicV1(op);
        }

        public static List<Model.ModelsArchiveLeaderboardSignedURLResponse>? Execute(
            this GetArchivedLeaderboardRankingDataV1Handler.GetArchivedLeaderboardRankingDataV1HandlerBuilder builder,
            string leaderboardCode,
            string namespace_,
            string leaderboardCodes
        )
        {
            GetArchivedLeaderboardRankingDataV1Handler op = builder.Build(
                leaderboardCode,
                namespace_,
                leaderboardCodes
            );

            return ((LeaderboardData)builder.WrapperObject!).GetArchivedLeaderboardRankingDataV1Handler(op);
        }

        public static Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetCurrentMonthLeaderboardRankingPublicV1.GetCurrentMonthLeaderboardRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentMonthLeaderboardRankingPublicV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((LeaderboardData)builder.WrapperObject!).GetCurrentMonthLeaderboardRankingPublicV1(op);
        }

        public static Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetCurrentSeasonLeaderboardRankingPublicV1.GetCurrentSeasonLeaderboardRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentSeasonLeaderboardRankingPublicV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((LeaderboardData)builder.WrapperObject!).GetCurrentSeasonLeaderboardRankingPublicV1(op);
        }

        public static Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetTodayLeaderboardRankingPublicV1.GetTodayLeaderboardRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetTodayLeaderboardRankingPublicV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((LeaderboardData)builder.WrapperObject!).GetTodayLeaderboardRankingPublicV1(op);
        }

        public static Model.ModelsUserRankingResponse? Execute(
            this GetUserRankingPublicV1.GetUserRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            GetUserRankingPublicV1 op = builder.Build(
                leaderboardCode,
                namespace_,
                userId
            );

            return ((LeaderboardData)builder.WrapperObject!).GetUserRankingPublicV1(op);
        }

        public static void Execute(
            this DeleteUserRankingPublicV1.DeleteUserRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            DeleteUserRankingPublicV1 op = builder.Build(
                leaderboardCode,
                namespace_,
                userId
            );

            ((LeaderboardData)builder.WrapperObject!).DeleteUserRankingPublicV1(op);
        }

        public static Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetCurrentWeekLeaderboardRankingPublicV1.GetCurrentWeekLeaderboardRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentWeekLeaderboardRankingPublicV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((LeaderboardData)builder.WrapperObject!).GetCurrentWeekLeaderboardRankingPublicV1(op);
        }

        public static Model.V2GetPublicLeaderboardRankingResponse? Execute(
            this GetAllTimeLeaderboardRankingPublicV2.GetAllTimeLeaderboardRankingPublicV2Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetAllTimeLeaderboardRankingPublicV2 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((LeaderboardData)builder.WrapperObject!).GetAllTimeLeaderboardRankingPublicV2(op);
        }

    }
}