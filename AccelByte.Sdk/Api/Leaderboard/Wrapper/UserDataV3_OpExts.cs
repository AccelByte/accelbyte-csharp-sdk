// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;
using AccelByte.Sdk.Api.Leaderboard.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LeaderboardUserDataV3_OpExts
    {
        public static Leaderboard.Model.ModelsGetAllUserLeaderboardsRespV3? Execute(
            this GetUserLeaderboardRankingsAdminV3.GetUserLeaderboardRankingsAdminV3Builder builder,
            string namespace_,
            string userId
        )
        {
            GetUserLeaderboardRankingsAdminV3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Leaderboard.Wrapper.UserDataV3)builder.WrapperObject!).GetUserLeaderboardRankingsAdminV3(op);
        }
    }
}