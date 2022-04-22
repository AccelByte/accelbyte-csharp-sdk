// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;
using AccelByte.Sdk.Api.Leaderboard.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LeaderboardUserData_OpExts
    {
        public static Leaderboard.Model.ModelsGetAllUserLeaderboardsResp? Execute(
            this GetUserLeaderboardRankingsAdminV1.GetUserLeaderboardRankingsAdminV1Builder builder,
            string namespace_,
            string userId
        )
        {
            GetUserLeaderboardRankingsAdminV1 op = builder.Build(
                namespace_,
                userId
            );

            return ((Leaderboard.Wrapper.UserData)builder.WrapperObject!).GetUserLeaderboardRankingsAdminV1(op);
        }

    }
}