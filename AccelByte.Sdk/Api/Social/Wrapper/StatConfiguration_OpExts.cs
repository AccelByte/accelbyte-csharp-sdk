// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;
using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SocialStatConfiguration_OpExts
    {
        public static Social.Model.StatPagingSlicedResult? Execute(
            this GetStats.GetStatsBuilder builder,
            string namespace_
        )
        {
            GetStats op = builder.Build(
                namespace_
            );

            return ((Social.Wrapper.StatConfiguration)builder.WrapperObject!).GetStats(op);
        }

        public static Social.Model.StatInfo? Execute(
            this CreateStat.CreateStatBuilder builder,
            string namespace_
        )
        {
            CreateStat op = builder.Build(
                namespace_
            );

            return ((Social.Wrapper.StatConfiguration)builder.WrapperObject!).CreateStat(op);
        }

        public static void Execute(
            this ExportStats.ExportStatsBuilder builder,
            string namespace_
        )
        {
            ExportStats op = builder.Build(
                namespace_
            );

            ((Social.Wrapper.StatConfiguration)builder.WrapperObject!).ExportStats(op);
        }

        public static Social.Model.StatImportInfo? Execute(
            this ImportStats.ImportStatsBuilder builder,
            string namespace_
        )
        {
            ImportStats op = builder.Build(
                namespace_
            );

            return ((Social.Wrapper.StatConfiguration)builder.WrapperObject!).ImportStats(op);
        }

        public static Social.Model.StatPagingSlicedResult? Execute(
            this QueryStats.QueryStatsBuilder builder,
            string namespace_,
            string keyword
        )
        {
            QueryStats op = builder.Build(
                namespace_,
                keyword
            );

            return ((Social.Wrapper.StatConfiguration)builder.WrapperObject!).QueryStats(op);
        }

        public static Social.Model.StatInfo? Execute(
            this GetStat.GetStatBuilder builder,
            string namespace_,
            string statCode
        )
        {
            GetStat op = builder.Build(
                namespace_,
                statCode
            );

            return ((Social.Wrapper.StatConfiguration)builder.WrapperObject!).GetStat(op);
        }

        public static void Execute(
            this DeleteStat.DeleteStatBuilder builder,
            string namespace_,
            string statCode
        )
        {
            DeleteStat op = builder.Build(
                namespace_,
                statCode
            );

            ((Social.Wrapper.StatConfiguration)builder.WrapperObject!).DeleteStat(op);
        }

        public static Social.Model.StatInfo? Execute(
            this UpdateStat.UpdateStatBuilder builder,
            string namespace_,
            string statCode
        )
        {
            UpdateStat op = builder.Build(
                namespace_,
                statCode
            );

            return ((Social.Wrapper.StatConfiguration)builder.WrapperObject!).UpdateStat(op);
        }

        public static Social.Model.StatInfo? Execute(
            this CreateStat1.CreateStat1Builder builder,
            string namespace_
        )
        {
            CreateStat1 op = builder.Build(
                namespace_
            );

            return ((Social.Wrapper.StatConfiguration)builder.WrapperObject!).CreateStat1(op);
        }

    }
}