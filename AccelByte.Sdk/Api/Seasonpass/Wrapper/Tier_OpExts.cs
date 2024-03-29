// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;
using AccelByte.Sdk.Api.Seasonpass.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SeasonpassTier_OpExts
    {
        public static Seasonpass.Model.TierPagingSlicedResult? Execute(
            this QueryTiers.QueryTiersBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            QueryTiers op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Seasonpass.Wrapper.Tier)builder.WrapperObject!).QueryTiers(op);
        }
        public static List<Seasonpass.Model.Tier>? Execute(
            this CreateTier.CreateTierBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            CreateTier op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Seasonpass.Wrapper.Tier)builder.WrapperObject!).CreateTier(op);
        }
        public static Seasonpass.Model.Tier? Execute(
            this UpdateTier.UpdateTierBuilder builder,
            string id,
            string namespace_,
            string seasonId
        )
        {
            UpdateTier op = builder.Build(
                id,
                namespace_,
                seasonId
            );

            return ((Seasonpass.Wrapper.Tier)builder.WrapperObject!).UpdateTier(op);
        }
        public static void Execute(
            this DeleteTier.DeleteTierBuilder builder,
            string id,
            string namespace_,
            string seasonId
        )
        {
            DeleteTier op = builder.Build(
                id,
                namespace_,
                seasonId
            );

            ((Seasonpass.Wrapper.Tier)builder.WrapperObject!).DeleteTier(op);
        }
        public static Seasonpass.Model.Tier? Execute(
            this ReorderTier.ReorderTierBuilder builder,
            string id,
            string namespace_,
            string seasonId
        )
        {
            ReorderTier op = builder.Build(
                id,
                namespace_,
                seasonId
            );

            return ((Seasonpass.Wrapper.Tier)builder.WrapperObject!).ReorderTier(op);
        }
        public static Seasonpass.Model.UserSeasonSummary? Execute(
            this GrantUserExp.GrantUserExpBuilder builder,
            string namespace_,
            string userId
        )
        {
            GrantUserExp op = builder.Build(
                namespace_,
                userId
            );

            return ((Seasonpass.Wrapper.Tier)builder.WrapperObject!).GrantUserExp(op);
        }
        public static Seasonpass.Model.UserSeasonSummary? Execute(
            this GrantUserTier.GrantUserTierBuilder builder,
            string namespace_,
            string userId
        )
        {
            GrantUserTier op = builder.Build(
                namespace_,
                userId
            );

            return ((Seasonpass.Wrapper.Tier)builder.WrapperObject!).GrantUserTier(op);
        }
    }
}