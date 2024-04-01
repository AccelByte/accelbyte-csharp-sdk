// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;
using AccelByte.Sdk.Api.Leaderboard.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LeaderboardLeaderboardData_OpExts
    {
        public static List<Leaderboard.Model.ModelsArchiveLeaderboardSignedURLResponse>? Execute(
            this AdminGetArchivedLeaderboardRankingDataV1Handler.AdminGetArchivedLeaderboardRankingDataV1HandlerBuilder builder,
            string namespace_,
            string leaderboardCodes
        )
        {
            AdminGetArchivedLeaderboardRankingDataV1Handler op = builder.Build(
                namespace_,
                leaderboardCodes
            );

            return ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).AdminGetArchivedLeaderboardRankingDataV1Handler(op);
        }
        public static async Task<List<Leaderboard.Model.ModelsArchiveLeaderboardSignedURLResponse>?> ExecuteAsync(
            this AdminGetArchivedLeaderboardRankingDataV1Handler.AdminGetArchivedLeaderboardRankingDataV1HandlerBuilder builder,
            string namespace_,
            string leaderboardCodes
        )
        {
            AdminGetArchivedLeaderboardRankingDataV1Handler op = builder.Build(
                namespace_,
                leaderboardCodes
            );

            return await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).AdminGetArchivedLeaderboardRankingDataV1HandlerAsync(op);
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

            ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).CreateArchivedLeaderboardRankingDataV1Handler(op);
        }
        public static async Task ExecuteAsync(
            this CreateArchivedLeaderboardRankingDataV1Handler.CreateArchivedLeaderboardRankingDataV1HandlerBuilder builder,
            ModelsArchiveLeaderboardReq body,
            string namespace_
        )
        {
            CreateArchivedLeaderboardRankingDataV1Handler op = builder.Build(
                body,
                namespace_
            );

            await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).CreateArchivedLeaderboardRankingDataV1HandlerAsync(op);
        }
        public static Leaderboard.Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetAllTimeLeaderboardRankingAdminV1.GetAllTimeLeaderboardRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetAllTimeLeaderboardRankingAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetAllTimeLeaderboardRankingAdminV1(op);
        }
        public static async Task<Leaderboard.Model.ModelsGetLeaderboardRankingResp?> ExecuteAsync(
            this GetAllTimeLeaderboardRankingAdminV1.GetAllTimeLeaderboardRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetAllTimeLeaderboardRankingAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetAllTimeLeaderboardRankingAdminV1Async(op);
        }
        public static Leaderboard.Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetCurrentMonthLeaderboardRankingAdminV1.GetCurrentMonthLeaderboardRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentMonthLeaderboardRankingAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetCurrentMonthLeaderboardRankingAdminV1(op);
        }
        public static async Task<Leaderboard.Model.ModelsGetLeaderboardRankingResp?> ExecuteAsync(
            this GetCurrentMonthLeaderboardRankingAdminV1.GetCurrentMonthLeaderboardRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentMonthLeaderboardRankingAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetCurrentMonthLeaderboardRankingAdminV1Async(op);
        }
        public static void Execute(
            this DeleteUserRankingByLeaderboardCodeAdminV1.DeleteUserRankingByLeaderboardCodeAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            DeleteUserRankingByLeaderboardCodeAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).DeleteUserRankingByLeaderboardCodeAdminV1(op);
        }
        public static async Task ExecuteAsync(
            this DeleteUserRankingByLeaderboardCodeAdminV1.DeleteUserRankingByLeaderboardCodeAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            DeleteUserRankingByLeaderboardCodeAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).DeleteUserRankingByLeaderboardCodeAdminV1Async(op);
        }
        public static Leaderboard.Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetCurrentSeasonLeaderboardRankingAdminV1.GetCurrentSeasonLeaderboardRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentSeasonLeaderboardRankingAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetCurrentSeasonLeaderboardRankingAdminV1(op);
        }
        public static async Task<Leaderboard.Model.ModelsGetLeaderboardRankingResp?> ExecuteAsync(
            this GetCurrentSeasonLeaderboardRankingAdminV1.GetCurrentSeasonLeaderboardRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentSeasonLeaderboardRankingAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetCurrentSeasonLeaderboardRankingAdminV1Async(op);
        }
        public static Leaderboard.Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetTodayLeaderboardRankingAdminV1.GetTodayLeaderboardRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetTodayLeaderboardRankingAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetTodayLeaderboardRankingAdminV1(op);
        }
        public static async Task<Leaderboard.Model.ModelsGetLeaderboardRankingResp?> ExecuteAsync(
            this GetTodayLeaderboardRankingAdminV1.GetTodayLeaderboardRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetTodayLeaderboardRankingAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetTodayLeaderboardRankingAdminV1Async(op);
        }
        public static Leaderboard.Model.ModelsUserRankingResponse? Execute(
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

            return ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetUserRankingAdminV1(op);
        }
        public static async Task<Leaderboard.Model.ModelsUserRankingResponse?> ExecuteAsync(
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

            return await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetUserRankingAdminV1Async(op);
        }
        public static Leaderboard.Model.ModelsUpdateUserPointAdminV1Response? Execute(
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

            return ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).UpdateUserPointAdminV1(op);
        }
        public static async Task<Leaderboard.Model.ModelsUpdateUserPointAdminV1Response?> ExecuteAsync(
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

            return await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).UpdateUserPointAdminV1Async(op);
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

            ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).DeleteUserRankingAdminV1(op);
        }
        public static async Task ExecuteAsync(
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

            await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).DeleteUserRankingAdminV1Async(op);
        }
        public static Leaderboard.Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetCurrentWeekLeaderboardRankingAdminV1.GetCurrentWeekLeaderboardRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentWeekLeaderboardRankingAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetCurrentWeekLeaderboardRankingAdminV1(op);
        }
        public static async Task<Leaderboard.Model.ModelsGetLeaderboardRankingResp?> ExecuteAsync(
            this GetCurrentWeekLeaderboardRankingAdminV1.GetCurrentWeekLeaderboardRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentWeekLeaderboardRankingAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetCurrentWeekLeaderboardRankingAdminV1Async(op);
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

            ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).DeleteUserRankingsAdminV1(op);
        }
        public static async Task ExecuteAsync(
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

            await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).DeleteUserRankingsAdminV1Async(op);
        }
        public static Leaderboard.Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetAllTimeLeaderboardRankingPublicV1.GetAllTimeLeaderboardRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetAllTimeLeaderboardRankingPublicV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetAllTimeLeaderboardRankingPublicV1(op);
        }
        public static async Task<Leaderboard.Model.ModelsGetLeaderboardRankingResp?> ExecuteAsync(
            this GetAllTimeLeaderboardRankingPublicV1.GetAllTimeLeaderboardRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetAllTimeLeaderboardRankingPublicV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetAllTimeLeaderboardRankingPublicV1Async(op);
        }
        public static List<Leaderboard.Model.ModelsArchiveLeaderboardSignedURLResponse>? Execute(
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

            return ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetArchivedLeaderboardRankingDataV1Handler(op);
        }
        public static async Task<List<Leaderboard.Model.ModelsArchiveLeaderboardSignedURLResponse>?> ExecuteAsync(
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

            return await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetArchivedLeaderboardRankingDataV1HandlerAsync(op);
        }
        public static Leaderboard.Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetCurrentMonthLeaderboardRankingPublicV1.GetCurrentMonthLeaderboardRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentMonthLeaderboardRankingPublicV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetCurrentMonthLeaderboardRankingPublicV1(op);
        }
        public static async Task<Leaderboard.Model.ModelsGetLeaderboardRankingResp?> ExecuteAsync(
            this GetCurrentMonthLeaderboardRankingPublicV1.GetCurrentMonthLeaderboardRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentMonthLeaderboardRankingPublicV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetCurrentMonthLeaderboardRankingPublicV1Async(op);
        }
        public static Leaderboard.Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetCurrentSeasonLeaderboardRankingPublicV1.GetCurrentSeasonLeaderboardRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentSeasonLeaderboardRankingPublicV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetCurrentSeasonLeaderboardRankingPublicV1(op);
        }
        public static async Task<Leaderboard.Model.ModelsGetLeaderboardRankingResp?> ExecuteAsync(
            this GetCurrentSeasonLeaderboardRankingPublicV1.GetCurrentSeasonLeaderboardRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentSeasonLeaderboardRankingPublicV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetCurrentSeasonLeaderboardRankingPublicV1Async(op);
        }
        public static Leaderboard.Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetTodayLeaderboardRankingPublicV1.GetTodayLeaderboardRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetTodayLeaderboardRankingPublicV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetTodayLeaderboardRankingPublicV1(op);
        }
        public static async Task<Leaderboard.Model.ModelsGetLeaderboardRankingResp?> ExecuteAsync(
            this GetTodayLeaderboardRankingPublicV1.GetTodayLeaderboardRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetTodayLeaderboardRankingPublicV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetTodayLeaderboardRankingPublicV1Async(op);
        }
        public static Leaderboard.Model.ModelsUserRankingResponse? Execute(
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

            return ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetUserRankingPublicV1(op);
        }
        public static async Task<Leaderboard.Model.ModelsUserRankingResponse?> ExecuteAsync(
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

            return await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetUserRankingPublicV1Async(op);
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

            ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).DeleteUserRankingPublicV1(op);
        }
        public static async Task ExecuteAsync(
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

            await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).DeleteUserRankingPublicV1Async(op);
        }
        public static Leaderboard.Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetCurrentWeekLeaderboardRankingPublicV1.GetCurrentWeekLeaderboardRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentWeekLeaderboardRankingPublicV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetCurrentWeekLeaderboardRankingPublicV1(op);
        }
        public static async Task<Leaderboard.Model.ModelsGetLeaderboardRankingResp?> ExecuteAsync(
            this GetCurrentWeekLeaderboardRankingPublicV1.GetCurrentWeekLeaderboardRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentWeekLeaderboardRankingPublicV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetCurrentWeekLeaderboardRankingPublicV1Async(op);
        }
        public static Leaderboard.Model.V2GetPublicLeaderboardRankingResponse? Execute(
            this GetAllTimeLeaderboardRankingPublicV2.GetAllTimeLeaderboardRankingPublicV2Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetAllTimeLeaderboardRankingPublicV2 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetAllTimeLeaderboardRankingPublicV2(op);
        }
        public static async Task<Leaderboard.Model.V2GetPublicLeaderboardRankingResponse?> ExecuteAsync(
            this GetAllTimeLeaderboardRankingPublicV2.GetAllTimeLeaderboardRankingPublicV2Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetAllTimeLeaderboardRankingPublicV2 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return await ((Leaderboard.Wrapper.LeaderboardData)builder.WrapperObject!).GetAllTimeLeaderboardRankingPublicV2Async(op);
        }
    }
}