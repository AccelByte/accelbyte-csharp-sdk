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
    public static class LeaderboardLeaderboardDataV3_OpExts
    {
        public static Leaderboard.Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetAllTimeLeaderboardRankingAdminV3.GetAllTimeLeaderboardRankingAdminV3Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetAllTimeLeaderboardRankingAdminV3 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).GetAllTimeLeaderboardRankingAdminV3(op);
        }
        public static async Task<Leaderboard.Model.ModelsGetLeaderboardRankingResp?> ExecuteAsync(
            this GetAllTimeLeaderboardRankingAdminV3.GetAllTimeLeaderboardRankingAdminV3Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetAllTimeLeaderboardRankingAdminV3 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return await ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).GetAllTimeLeaderboardRankingAdminV3Async(op);
        }
        public static Leaderboard.Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetCurrentCycleLeaderboardRankingAdminV3.GetCurrentCycleLeaderboardRankingAdminV3Builder builder,
            string cycleId,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentCycleLeaderboardRankingAdminV3 op = builder.Build(
                cycleId,
                leaderboardCode,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).GetCurrentCycleLeaderboardRankingAdminV3(op);
        }
        public static async Task<Leaderboard.Model.ModelsGetLeaderboardRankingResp?> ExecuteAsync(
            this GetCurrentCycleLeaderboardRankingAdminV3.GetCurrentCycleLeaderboardRankingAdminV3Builder builder,
            string cycleId,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentCycleLeaderboardRankingAdminV3 op = builder.Build(
                cycleId,
                leaderboardCode,
                namespace_
            );

            return await ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).GetCurrentCycleLeaderboardRankingAdminV3Async(op);
        }
        public static void Execute(
            this DeleteAllUserRankingByCycleIdAdminV3.DeleteAllUserRankingByCycleIdAdminV3Builder builder,
            string cycleId,
            string leaderboardCode,
            string namespace_
        )
        {
            DeleteAllUserRankingByCycleIdAdminV3 op = builder.Build(
                cycleId,
                leaderboardCode,
                namespace_
            );

            ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).DeleteAllUserRankingByCycleIdAdminV3(op);
        }
        public static async Task ExecuteAsync(
            this DeleteAllUserRankingByCycleIdAdminV3.DeleteAllUserRankingByCycleIdAdminV3Builder builder,
            string cycleId,
            string leaderboardCode,
            string namespace_
        )
        {
            DeleteAllUserRankingByCycleIdAdminV3 op = builder.Build(
                cycleId,
                leaderboardCode,
                namespace_
            );

            await ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).DeleteAllUserRankingByCycleIdAdminV3Async(op);
        }
        public static void Execute(
            this DeleteUserRankingByCycleIdAdminV3.DeleteUserRankingByCycleIdAdminV3Builder builder,
            string cycleId,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            DeleteUserRankingByCycleIdAdminV3 op = builder.Build(
                cycleId,
                leaderboardCode,
                namespace_,
                userId
            );

            ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).DeleteUserRankingByCycleIdAdminV3(op);
        }
        public static async Task ExecuteAsync(
            this DeleteUserRankingByCycleIdAdminV3.DeleteUserRankingByCycleIdAdminV3Builder builder,
            string cycleId,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            DeleteUserRankingByCycleIdAdminV3 op = builder.Build(
                cycleId,
                leaderboardCode,
                namespace_,
                userId
            );

            await ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).DeleteUserRankingByCycleIdAdminV3Async(op);
        }
        public static void Execute(
            this DeleteUserRankingByLeaderboardCodeAdminV3.DeleteUserRankingByLeaderboardCodeAdminV3Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            DeleteUserRankingByLeaderboardCodeAdminV3 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).DeleteUserRankingByLeaderboardCodeAdminV3(op);
        }
        public static async Task ExecuteAsync(
            this DeleteUserRankingByLeaderboardCodeAdminV3.DeleteUserRankingByLeaderboardCodeAdminV3Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            DeleteUserRankingByLeaderboardCodeAdminV3 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            await ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).DeleteUserRankingByLeaderboardCodeAdminV3Async(op);
        }
        public static Leaderboard.Model.ModelsUserRankingResponseV3? Execute(
            this GetUserRankingAdminV3.GetUserRankingAdminV3Builder builder,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            GetUserRankingAdminV3 op = builder.Build(
                leaderboardCode,
                namespace_,
                userId
            );

            return ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).GetUserRankingAdminV3(op);
        }
        public static async Task<Leaderboard.Model.ModelsUserRankingResponseV3?> ExecuteAsync(
            this GetUserRankingAdminV3.GetUserRankingAdminV3Builder builder,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            GetUserRankingAdminV3 op = builder.Build(
                leaderboardCode,
                namespace_,
                userId
            );

            return await ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).GetUserRankingAdminV3Async(op);
        }
        public static void Execute(
            this DeleteUserRankingAdminV3.DeleteUserRankingAdminV3Builder builder,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            DeleteUserRankingAdminV3 op = builder.Build(
                leaderboardCode,
                namespace_,
                userId
            );

            ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).DeleteUserRankingAdminV3(op);
        }
        public static async Task ExecuteAsync(
            this DeleteUserRankingAdminV3.DeleteUserRankingAdminV3Builder builder,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            DeleteUserRankingAdminV3 op = builder.Build(
                leaderboardCode,
                namespace_,
                userId
            );

            await ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).DeleteUserRankingAdminV3Async(op);
        }
        public static void Execute(
            this DeleteUserRankingsAdminV3.DeleteUserRankingsAdminV3Builder builder,
            string namespace_,
            string userId,
            List<string> leaderboardCode
        )
        {
            DeleteUserRankingsAdminV3 op = builder.Build(
                namespace_,
                userId,
                leaderboardCode
            );

            ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).DeleteUserRankingsAdminV3(op);
        }
        public static async Task ExecuteAsync(
            this DeleteUserRankingsAdminV3.DeleteUserRankingsAdminV3Builder builder,
            string namespace_,
            string userId,
            List<string> leaderboardCode
        )
        {
            DeleteUserRankingsAdminV3 op = builder.Build(
                namespace_,
                userId,
                leaderboardCode
            );

            await ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).DeleteUserRankingsAdminV3Async(op);
        }
        public static Leaderboard.Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetAllTimeLeaderboardRankingPublicV3.GetAllTimeLeaderboardRankingPublicV3Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetAllTimeLeaderboardRankingPublicV3 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).GetAllTimeLeaderboardRankingPublicV3(op);
        }
        public static async Task<Leaderboard.Model.ModelsGetLeaderboardRankingResp?> ExecuteAsync(
            this GetAllTimeLeaderboardRankingPublicV3.GetAllTimeLeaderboardRankingPublicV3Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetAllTimeLeaderboardRankingPublicV3 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return await ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).GetAllTimeLeaderboardRankingPublicV3Async(op);
        }
        public static Leaderboard.Model.ModelsGetLeaderboardRankingResp? Execute(
            this GetCurrentCycleLeaderboardRankingPublicV3.GetCurrentCycleLeaderboardRankingPublicV3Builder builder,
            string cycleId,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentCycleLeaderboardRankingPublicV3 op = builder.Build(
                cycleId,
                leaderboardCode,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).GetCurrentCycleLeaderboardRankingPublicV3(op);
        }
        public static async Task<Leaderboard.Model.ModelsGetLeaderboardRankingResp?> ExecuteAsync(
            this GetCurrentCycleLeaderboardRankingPublicV3.GetCurrentCycleLeaderboardRankingPublicV3Builder builder,
            string cycleId,
            string leaderboardCode,
            string namespace_
        )
        {
            GetCurrentCycleLeaderboardRankingPublicV3 op = builder.Build(
                cycleId,
                leaderboardCode,
                namespace_
            );

            return await ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).GetCurrentCycleLeaderboardRankingPublicV3Async(op);
        }
        public static Leaderboard.Model.ModelsBulkUserRankingResponseV3? Execute(
            this BulkGetUsersRankingPublicV3.BulkGetUsersRankingPublicV3Builder builder,
            ModelsBulkUserIDsRequest body,
            string leaderboardCode,
            string namespace_
        )
        {
            BulkGetUsersRankingPublicV3 op = builder.Build(
                body,
                leaderboardCode,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).BulkGetUsersRankingPublicV3(op);
        }
        public static async Task<Leaderboard.Model.ModelsBulkUserRankingResponseV3?> ExecuteAsync(
            this BulkGetUsersRankingPublicV3.BulkGetUsersRankingPublicV3Builder builder,
            ModelsBulkUserIDsRequest body,
            string leaderboardCode,
            string namespace_
        )
        {
            BulkGetUsersRankingPublicV3 op = builder.Build(
                body,
                leaderboardCode,
                namespace_
            );

            return await ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).BulkGetUsersRankingPublicV3Async(op);
        }
        public static Leaderboard.Model.ModelsUserRankingResponseV3? Execute(
            this GetUserRankingPublicV3.GetUserRankingPublicV3Builder builder,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            GetUserRankingPublicV3 op = builder.Build(
                leaderboardCode,
                namespace_,
                userId
            );

            return ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).GetUserRankingPublicV3(op);
        }
        public static async Task<Leaderboard.Model.ModelsUserRankingResponseV3?> ExecuteAsync(
            this GetUserRankingPublicV3.GetUserRankingPublicV3Builder builder,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            GetUserRankingPublicV3 op = builder.Build(
                leaderboardCode,
                namespace_,
                userId
            );

            return await ((Leaderboard.Wrapper.LeaderboardDataV3)builder.WrapperObject!).GetUserRankingPublicV3Async(op);
        }
    }
}