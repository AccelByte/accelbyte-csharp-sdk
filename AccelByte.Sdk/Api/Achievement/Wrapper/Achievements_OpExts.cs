// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Api.Achievement.Operation;
using AccelByte.Sdk.Api.Achievement.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class AchievementAchievements_OpExts
    {
        public static Achievement.Model.ModelsPaginatedAchievementResponse? Execute(
            this AdminListAchievements.AdminListAchievementsBuilder builder,
            string namespace_
        )
        {
            AdminListAchievements op = builder.Build(
                namespace_
            );

            return ((Achievement.Wrapper.Achievements)builder.WrapperObject!).AdminListAchievements(op);
        }

        public static Achievement.Model.ModelsAchievementResponse? Execute(
            this AdminCreateNewAchievement.AdminCreateNewAchievementBuilder builder,
            ModelsAchievementRequest body,
            string namespace_
        )
        {
            AdminCreateNewAchievement op = builder.Build(
                body,
                namespace_
            );

            return ((Achievement.Wrapper.Achievements)builder.WrapperObject!).AdminCreateNewAchievement(op);
        }

        public static List<Achievement.Model.ModelsAchievement>? Execute(
            this ExportAchievements.ExportAchievementsBuilder builder,
            string namespace_
        )
        {
            ExportAchievements op = builder.Build(
                namespace_
            );

            return ((Achievement.Wrapper.Achievements)builder.WrapperObject!).ExportAchievements(op);
        }

        public static Achievement.Model.ServiceImportConfigResponse? Execute(
            this ImportAchievements.ImportAchievementsBuilder builder,
            string namespace_
        )
        {
            ImportAchievements op = builder.Build(
                namespace_
            );

            return ((Achievement.Wrapper.Achievements)builder.WrapperObject!).ImportAchievements(op);
        }

        public static Achievement.Model.ModelsAchievementResponse? Execute(
            this AdminGetAchievement.AdminGetAchievementBuilder builder,
            string achievementCode,
            string namespace_
        )
        {
            AdminGetAchievement op = builder.Build(
                achievementCode,
                namespace_
            );

            return ((Achievement.Wrapper.Achievements)builder.WrapperObject!).AdminGetAchievement(op);
        }

        public static Achievement.Model.ModelsAchievementResponse? Execute(
            this AdminUpdateAchievement.AdminUpdateAchievementBuilder builder,
            ModelsAchievementUpdateRequest body,
            string achievementCode,
            string namespace_
        )
        {
            AdminUpdateAchievement op = builder.Build(
                body,
                achievementCode,
                namespace_
            );

            return ((Achievement.Wrapper.Achievements)builder.WrapperObject!).AdminUpdateAchievement(op);
        }

        public static void Execute(
            this AdminDeleteAchievement.AdminDeleteAchievementBuilder builder,
            string achievementCode,
            string namespace_
        )
        {
            AdminDeleteAchievement op = builder.Build(
                achievementCode,
                namespace_
            );

            ((Achievement.Wrapper.Achievements)builder.WrapperObject!).AdminDeleteAchievement(op);
        }

        public static void Execute(
            this AdminUpdateAchievementListOrder.AdminUpdateAchievementListOrderBuilder builder,
            ModelsAchievementOrderUpdateRequest body,
            string achievementCode,
            string namespace_
        )
        {
            AdminUpdateAchievementListOrder op = builder.Build(
                body,
                achievementCode,
                namespace_
            );

            ((Achievement.Wrapper.Achievements)builder.WrapperObject!).AdminUpdateAchievementListOrder(op);
        }

        public static Achievement.Model.ModelsPaginatedUserAchievementResponse? Execute(
            this AdminListUserAchievements.AdminListUserAchievementsBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminListUserAchievements op = builder.Build(
                namespace_,
                userId
            );

            return ((Achievement.Wrapper.Achievements)builder.WrapperObject!).AdminListUserAchievements(op);
        }

        public static void Execute(
            this AdminUnlockAchievement.AdminUnlockAchievementBuilder builder,
            string achievementCode,
            string namespace_,
            string userId
        )
        {
            AdminUnlockAchievement op = builder.Build(
                achievementCode,
                namespace_,
                userId
            );

            ((Achievement.Wrapper.Achievements)builder.WrapperObject!).AdminUnlockAchievement(op);
        }

        public static Achievement.Model.ModelsPublicAchievementsResponse? Execute(
            this PublicListAchievements.PublicListAchievementsBuilder builder,
            string namespace_,
            string language
        )
        {
            PublicListAchievements op = builder.Build(
                namespace_,
                language
            );

            return ((Achievement.Wrapper.Achievements)builder.WrapperObject!).PublicListAchievements(op);
        }

        public static Achievement.Model.ModelsPublicAchievementResponse? Execute(
            this PublicGetAchievement.PublicGetAchievementBuilder builder,
            string achievementCode,
            string namespace_,
            string language
        )
        {
            PublicGetAchievement op = builder.Build(
                achievementCode,
                namespace_,
                language
            );

            return ((Achievement.Wrapper.Achievements)builder.WrapperObject!).PublicGetAchievement(op);
        }

        public static Achievement.Model.ModelsPaginatedUserAchievementResponse? Execute(
            this PublicListUserAchievements.PublicListUserAchievementsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicListUserAchievements op = builder.Build(
                namespace_,
                userId
            );

            return ((Achievement.Wrapper.Achievements)builder.WrapperObject!).PublicListUserAchievements(op);
        }

        public static void Execute(
            this PublicUnlockAchievement.PublicUnlockAchievementBuilder builder,
            string achievementCode,
            string namespace_,
            string userId
        )
        {
            PublicUnlockAchievement op = builder.Build(
                achievementCode,
                namespace_,
                userId
            );

            ((Achievement.Wrapper.Achievements)builder.WrapperObject!).PublicUnlockAchievement(op);
        }

    }
}