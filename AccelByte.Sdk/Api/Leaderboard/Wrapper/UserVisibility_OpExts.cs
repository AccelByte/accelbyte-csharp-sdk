// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;
using AccelByte.Sdk.Api.Leaderboard.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LeaderboardUserVisibility_OpExts
    {
        public static Leaderboard.Model.ModelsGetHiddenUserResponse? Execute(
            this GetHiddenUsersV2.GetHiddenUsersV2Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetHiddenUsersV2 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((Leaderboard.Wrapper.UserVisibility)builder.WrapperObject!).GetHiddenUsersV2(op);
        }

        public static Leaderboard.Model.ModelsGetUserVisibilityResponse? Execute(
            this GetUserVisibilityStatusV2.GetUserVisibilityStatusV2Builder builder,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            GetUserVisibilityStatusV2 op = builder.Build(
                leaderboardCode,
                namespace_,
                userId
            );

            return ((Leaderboard.Wrapper.UserVisibility)builder.WrapperObject!).GetUserVisibilityStatusV2(op);
        }

        public static Leaderboard.Model.ModelsGetUserVisibilityResponse? Execute(
            this SetUserLeaderboardVisibilityStatusV2.SetUserLeaderboardVisibilityStatusV2Builder builder,
            ModelsSetUserVisibilityRequest body,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            SetUserLeaderboardVisibilityStatusV2 op = builder.Build(
                body,
                leaderboardCode,
                namespace_,
                userId
            );

            return ((Leaderboard.Wrapper.UserVisibility)builder.WrapperObject!).SetUserLeaderboardVisibilityStatusV2(op);
        }

        public static Leaderboard.Model.ModelsGetUserVisibilityResponse? Execute(
            this SetUserVisibilityStatusV2.SetUserVisibilityStatusV2Builder builder,
            ModelsSetUserVisibilityRequest body,
            string namespace_,
            string userId
        )
        {
            SetUserVisibilityStatusV2 op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Leaderboard.Wrapper.UserVisibility)builder.WrapperObject!).SetUserVisibilityStatusV2(op);
        }

    }
}