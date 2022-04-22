// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;
using AccelByte.Sdk.Api.Seasonpass.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SeasonpassPass_OpExts
    {
        public static List<Seasonpass.Model.PassInfo>? Execute(
            this QueryPasses.QueryPassesBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            QueryPasses op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Seasonpass.Wrapper.Pass)builder.WrapperObject!).QueryPasses(op);
        }

        public static Seasonpass.Model.PassInfo? Execute(
            this CreatePass.CreatePassBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            CreatePass op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Seasonpass.Wrapper.Pass)builder.WrapperObject!).CreatePass(op);
        }

        public static Seasonpass.Model.PassInfo? Execute(
            this GetPass.GetPassBuilder builder,
            string code,
            string namespace_,
            string seasonId
        )
        {
            GetPass op = builder.Build(
                code,
                namespace_,
                seasonId
            );

            return ((Seasonpass.Wrapper.Pass)builder.WrapperObject!).GetPass(op);
        }

        public static void Execute(
            this DeletePass.DeletePassBuilder builder,
            string code,
            string namespace_,
            string seasonId
        )
        {
            DeletePass op = builder.Build(
                code,
                namespace_,
                seasonId
            );

            ((Seasonpass.Wrapper.Pass)builder.WrapperObject!).DeletePass(op);
        }

        public static Seasonpass.Model.PassInfo? Execute(
            this UpdatePass.UpdatePassBuilder builder,
            string code,
            string namespace_,
            string seasonId
        )
        {
            UpdatePass op = builder.Build(
                code,
                namespace_,
                seasonId
            );

            return ((Seasonpass.Wrapper.Pass)builder.WrapperObject!).UpdatePass(op);
        }

        public static Seasonpass.Model.UserSeasonSummary? Execute(
            this GrantUserPass.GrantUserPassBuilder builder,
            string namespace_,
            string userId
        )
        {
            GrantUserPass op = builder.Build(
                namespace_,
                userId
            );

            return ((Seasonpass.Wrapper.Pass)builder.WrapperObject!).GrantUserPass(op);
        }

    }
}