// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Challenge.Model;
using AccelByte.Sdk.Api.Challenge.Operation;
using AccelByte.Sdk.Api.Challenge.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class ChallengePlayerReward_OpExts
    {
        public static Challenge.Model.ModelListUserRewardsResponse? Execute(
            this AdminGetUserRewards.AdminGetUserRewardsBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserRewards op = builder.Build(
                namespace_,
                userId
            );

            return ((Challenge.Wrapper.PlayerReward)builder.WrapperObject!).AdminGetUserRewards(op);
        }
        public static async Task<Challenge.Model.ModelListUserRewardsResponse?> ExecuteAsync(
            this AdminGetUserRewards.AdminGetUserRewardsBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserRewards op = builder.Build(
                namespace_,
                userId
            );

            return await ((Challenge.Wrapper.PlayerReward)builder.WrapperObject!).AdminGetUserRewardsAsync(op);
        }
        public static Challenge.Model.ModelListUserRewardsResponse? Execute(
            this PublicGetUserRewards.PublicGetUserRewardsBuilder builder,
            string namespace_
        )
        {
            PublicGetUserRewards op = builder.Build(
                namespace_
            );

            return ((Challenge.Wrapper.PlayerReward)builder.WrapperObject!).PublicGetUserRewards(op);
        }
        public static async Task<Challenge.Model.ModelListUserRewardsResponse?> ExecuteAsync(
            this PublicGetUserRewards.PublicGetUserRewardsBuilder builder,
            string namespace_
        )
        {
            PublicGetUserRewards op = builder.Build(
                namespace_
            );

            return await ((Challenge.Wrapper.PlayerReward)builder.WrapperObject!).PublicGetUserRewardsAsync(op);
        }
        public static List<Challenge.Model.ModelUserReward>? Execute(
            this PublicClaimUserRewards.PublicClaimUserRewardsBuilder builder,
            ModelClaimUserRewardsReq body,
            string namespace_
        )
        {
            PublicClaimUserRewards op = builder.Build(
                body,
                namespace_
            );

            return ((Challenge.Wrapper.PlayerReward)builder.WrapperObject!).PublicClaimUserRewards(op);
        }
        public static async Task<List<Challenge.Model.ModelUserReward>?> ExecuteAsync(
            this PublicClaimUserRewards.PublicClaimUserRewardsBuilder builder,
            ModelClaimUserRewardsReq body,
            string namespace_
        )
        {
            PublicClaimUserRewards op = builder.Build(
                body,
                namespace_
            );

            return await ((Challenge.Wrapper.PlayerReward)builder.WrapperObject!).PublicClaimUserRewardsAsync(op);
        }
    }
}