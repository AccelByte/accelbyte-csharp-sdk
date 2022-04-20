// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;
using AccelByte.Sdk.Api.Leaderboard.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LeaderboardLeaderboardConfiguration_OpExts
    {
        public static Leaderboard.Model.ModelsGetAllLeaderboardConfigsResp? Execute(
            this GetLeaderboardConfigurationsAdminV1.GetLeaderboardConfigurationsAdminV1Builder builder,
            string namespace_
        )
        {
            GetLeaderboardConfigurationsAdminV1 op = builder.Build(
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardConfiguration)builder.WrapperObject!).GetLeaderboardConfigurationsAdminV1(op);
        }

        public static Leaderboard.Model.ModelsLeaderboardConfigReq? Execute(
            this CreateLeaderboardConfigurationAdminV1.CreateLeaderboardConfigurationAdminV1Builder builder,
            ModelsLeaderboardConfigReq body,
            string namespace_
        )
        {
            CreateLeaderboardConfigurationAdminV1 op = builder.Build(
                body,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardConfiguration)builder.WrapperObject!).CreateLeaderboardConfigurationAdminV1(op);
        }

        public static Leaderboard.Model.ModelsDeleteBulkLeaderboardsResp? Execute(
            this DeleteBulkLeaderboardConfigurationAdminV1.DeleteBulkLeaderboardConfigurationAdminV1Builder builder,
            ModelsDeleteBulkLeaderboardsReq body,
            string namespace_
        )
        {
            DeleteBulkLeaderboardConfigurationAdminV1 op = builder.Build(
                body,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardConfiguration)builder.WrapperObject!).DeleteBulkLeaderboardConfigurationAdminV1(op);
        }

        public static Leaderboard.Model.ModelsGetLeaderboardConfigResp? Execute(
            this GetLeaderboardConfigurationAdminV1.GetLeaderboardConfigurationAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetLeaderboardConfigurationAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardConfiguration)builder.WrapperObject!).GetLeaderboardConfigurationAdminV1(op);
        }

        public static Leaderboard.Model.ModelsGetLeaderboardConfigResp? Execute(
            this UpdateLeaderboardConfigurationAdminV1.UpdateLeaderboardConfigurationAdminV1Builder builder,
            ModelsUpdateLeaderboardConfigReq body,
            string leaderboardCode,
            string namespace_
        )
        {
            UpdateLeaderboardConfigurationAdminV1 op = builder.Build(
                body,
                leaderboardCode,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardConfiguration)builder.WrapperObject!).UpdateLeaderboardConfigurationAdminV1(op);
        }

        public static void Execute(
            this DeleteLeaderboardConfigurationAdminV1.DeleteLeaderboardConfigurationAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            DeleteLeaderboardConfigurationAdminV1 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            ((Leaderboard.Wrapper.LeaderboardConfiguration)builder.WrapperObject!).DeleteLeaderboardConfigurationAdminV1(op);
        }

        public static Leaderboard.Model.ModelsGetAllLeaderboardConfigsPublicResp? Execute(
            this GetLeaderboardConfigurationsPublicV1.GetLeaderboardConfigurationsPublicV1Builder builder,
            string namespace_
        )
        {
            GetLeaderboardConfigurationsPublicV1 op = builder.Build(
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardConfiguration)builder.WrapperObject!).GetLeaderboardConfigurationsPublicV1(op);
        }

        public static Leaderboard.Model.ModelsLeaderboardConfigReq? Execute(
            this CreateLeaderboardConfigurationPublicV1.CreateLeaderboardConfigurationPublicV1Builder builder,
            ModelsLeaderboardConfigReq body,
            string namespace_
        )
        {
            CreateLeaderboardConfigurationPublicV1 op = builder.Build(
                body,
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardConfiguration)builder.WrapperObject!).CreateLeaderboardConfigurationPublicV1(op);
        }

        public static Leaderboard.Model.V2GetAllLeaderboardConfigsPublicResp? Execute(
            this GetLeaderboardConfigurationsPublicV2.GetLeaderboardConfigurationsPublicV2Builder builder,
            string namespace_
        )
        {
            GetLeaderboardConfigurationsPublicV2 op = builder.Build(
                namespace_
            );

            return ((Leaderboard.Wrapper.LeaderboardConfiguration)builder.WrapperObject!).GetLeaderboardConfigurationsPublicV2(op);
        }

    }
}