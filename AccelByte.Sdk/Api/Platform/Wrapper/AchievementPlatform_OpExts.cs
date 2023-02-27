// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformAchievementPlatform_OpExts
    {
        public static void Execute(
            this UnlockSteamUserAchievement.UnlockSteamUserAchievementBuilder builder,
            string namespace_,
            string userId
        )
        {
            UnlockSteamUserAchievement op = builder.Build(
                namespace_,
                userId
            );

            ((Platform.Wrapper.AchievementPlatform)builder.WrapperObject!).UnlockSteamUserAchievement(op);
        }
        public static Platform.Model.XblUserAchievements? Execute(
            this GetXblUserAchievements.GetXblUserAchievementsBuilder builder,
            string namespace_,
            string userId,
            string xboxUserId
        )
        {
            GetXblUserAchievements op = builder.Build(
                namespace_,
                userId,
                xboxUserId
            );

            return ((Platform.Wrapper.AchievementPlatform)builder.WrapperObject!).GetXblUserAchievements(op);
        }
        public static void Execute(
            this UpdateXblUserAchievement.UpdateXblUserAchievementBuilder builder,
            string namespace_,
            string userId
        )
        {
            UpdateXblUserAchievement op = builder.Build(
                namespace_,
                userId
            );

            ((Platform.Wrapper.AchievementPlatform)builder.WrapperObject!).UpdateXblUserAchievement(op);
        }
    }
}