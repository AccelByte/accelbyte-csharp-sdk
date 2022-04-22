// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;
using AccelByte.Sdk.Api.Seasonpass.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SeasonpassSeason_OpExts
    {
        public static Seasonpass.Model.ListSeasonInfoPagingSlicedResult? Execute(
            this QuerySeasons.QuerySeasonsBuilder builder,
            string namespace_
        )
        {
            QuerySeasons op = builder.Build(
                namespace_
            );

            return ((Seasonpass.Wrapper.Season)builder.WrapperObject!).QuerySeasons(op);
        }

        public static Seasonpass.Model.SeasonInfo? Execute(
            this CreateSeason.CreateSeasonBuilder builder,
            string namespace_
        )
        {
            CreateSeason op = builder.Build(
                namespace_
            );

            return ((Seasonpass.Wrapper.Season)builder.WrapperObject!).CreateSeason(op);
        }

        public static Seasonpass.Model.SeasonSummary? Execute(
            this GetCurrentSeason.GetCurrentSeasonBuilder builder,
            string namespace_
        )
        {
            GetCurrentSeason op = builder.Build(
                namespace_
            );

            return ((Seasonpass.Wrapper.Season)builder.WrapperObject!).GetCurrentSeason(op);
        }

        public static Seasonpass.Model.SeasonInfo? Execute(
            this GetSeason.GetSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            GetSeason op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Seasonpass.Wrapper.Season)builder.WrapperObject!).GetSeason(op);
        }

        public static void Execute(
            this DeleteSeason.DeleteSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            DeleteSeason op = builder.Build(
                namespace_,
                seasonId
            );

            ((Seasonpass.Wrapper.Season)builder.WrapperObject!).DeleteSeason(op);
        }

        public static Seasonpass.Model.SeasonInfo? Execute(
            this UpdateSeason.UpdateSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            UpdateSeason op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Seasonpass.Wrapper.Season)builder.WrapperObject!).UpdateSeason(op);
        }

        public static Seasonpass.Model.SeasonInfo? Execute(
            this CloneSeason.CloneSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            CloneSeason op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Seasonpass.Wrapper.Season)builder.WrapperObject!).CloneSeason(op);
        }

        public static Seasonpass.Model.SeasonInfo? Execute(
            this PublishSeason.PublishSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            PublishSeason op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Seasonpass.Wrapper.Season)builder.WrapperObject!).PublishSeason(op);
        }

        public static Seasonpass.Model.SeasonInfo? Execute(
            this RetireSeason.RetireSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            RetireSeason op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Seasonpass.Wrapper.Season)builder.WrapperObject!).RetireSeason(op);
        }

        public static Seasonpass.Model.SeasonInfo? Execute(
            this UnpublishSeason.UnpublishSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            UnpublishSeason op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Seasonpass.Wrapper.Season)builder.WrapperObject!).UnpublishSeason(op);
        }

        public static Seasonpass.Model.ListUserSeasonInfoPagingSlicedResult? Execute(
            this GetUserParticipatedSeasons.GetUserParticipatedSeasonsBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserParticipatedSeasons op = builder.Build(
                namespace_,
                userId
            );

            return ((Seasonpass.Wrapper.Season)builder.WrapperObject!).GetUserParticipatedSeasons(op);
        }

        public static Seasonpass.Model.Ownership? Execute(
            this ExistsAnyPassByPassCodes.ExistsAnyPassByPassCodesBuilder builder,
            string namespace_,
            string userId
        )
        {
            ExistsAnyPassByPassCodes op = builder.Build(
                namespace_,
                userId
            );

            return ((Seasonpass.Wrapper.Season)builder.WrapperObject!).ExistsAnyPassByPassCodes(op);
        }

        public static Seasonpass.Model.UserSeasonSummary? Execute(
            this GetCurrentUserSeasonProgression.GetCurrentUserSeasonProgressionBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetCurrentUserSeasonProgression op = builder.Build(
                namespace_,
                userId
            );

            return ((Seasonpass.Wrapper.Season)builder.WrapperObject!).GetCurrentUserSeasonProgression(op);
        }

        public static void Execute(
            this CheckSeasonPurchasable.CheckSeasonPurchasableBuilder builder,
            string namespace_,
            string userId
        )
        {
            CheckSeasonPurchasable op = builder.Build(
                namespace_,
                userId
            );

            ((Seasonpass.Wrapper.Season)builder.WrapperObject!).CheckSeasonPurchasable(op);
        }

        public static void Execute(
            this ResetUserSeason.ResetUserSeasonBuilder builder,
            string namespace_,
            string userId
        )
        {
            ResetUserSeason op = builder.Build(
                namespace_,
                userId
            );

            ((Seasonpass.Wrapper.Season)builder.WrapperObject!).ResetUserSeason(op);
        }

        public static Seasonpass.Model.ClaimableUserSeasonInfo? Execute(
            this GetUserSeason.GetUserSeasonBuilder builder,
            string namespace_,
            string seasonId,
            string userId
        )
        {
            GetUserSeason op = builder.Build(
                namespace_,
                seasonId,
                userId
            );

            return ((Seasonpass.Wrapper.Season)builder.WrapperObject!).GetUserSeason(op);
        }

        public static Seasonpass.Model.LocalizedSeasonInfo? Execute(
            this PublicGetCurrentSeason.PublicGetCurrentSeasonBuilder builder,
            string namespace_
        )
        {
            PublicGetCurrentSeason op = builder.Build(
                namespace_
            );

            return ((Seasonpass.Wrapper.Season)builder.WrapperObject!).PublicGetCurrentSeason(op);
        }

        public static Seasonpass.Model.ClaimableUserSeasonInfo? Execute(
            this PublicGetCurrentUserSeason.PublicGetCurrentUserSeasonBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetCurrentUserSeason op = builder.Build(
                namespace_,
                userId
            );

            return ((Seasonpass.Wrapper.Season)builder.WrapperObject!).PublicGetCurrentUserSeason(op);
        }

        public static Seasonpass.Model.ClaimableUserSeasonInfo? Execute(
            this PublicGetUserSeason.PublicGetUserSeasonBuilder builder,
            string namespace_,
            string seasonId,
            string userId
        )
        {
            PublicGetUserSeason op = builder.Build(
                namespace_,
                seasonId,
                userId
            );

            return ((Seasonpass.Wrapper.Season)builder.WrapperObject!).PublicGetUserSeason(op);
        }

    }
}