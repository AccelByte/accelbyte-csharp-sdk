// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Api.Achievement.Operation;
using AccelByte.Sdk.Api.Achievement.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class AchievementGlobalAchievements_OpExts
    {
        public static Achievement.Model.ModelsPaginatedGlobalAchievementResponse? Execute(
            this PublicListGlobalAchievements.PublicListGlobalAchievementsBuilder builder,
            string namespace_
        )
        {
            PublicListGlobalAchievements op = builder.Build(
                namespace_
            );

            return ((Achievement.Wrapper.GlobalAchievements)builder.WrapperObject!).PublicListGlobalAchievements(op);
        }
        public static void Execute(
            this ClaimGlobalAchievementReward.ClaimGlobalAchievementRewardBuilder builder,
            string achievementCode,
            string namespace_,
            string userId
        )
        {
            ClaimGlobalAchievementReward op = builder.Build(
                achievementCode,
                namespace_,
                userId
            );

            ((Achievement.Wrapper.GlobalAchievements)builder.WrapperObject!).ClaimGlobalAchievementReward(op);
        }
    }
}