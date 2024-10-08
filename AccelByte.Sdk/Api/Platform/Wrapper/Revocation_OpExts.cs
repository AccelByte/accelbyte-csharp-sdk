// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformRevocation_OpExts
    {
        public static Platform.Model.RevocationConfigInfo? Execute(
            this GetRevocationConfig.GetRevocationConfigBuilder builder,
            string namespace_
        )
        {
            GetRevocationConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Revocation)builder.WrapperObject!).GetRevocationConfig(op);
        }
        public static async Task<Platform.Model.RevocationConfigInfo?> ExecuteAsync(
            this GetRevocationConfig.GetRevocationConfigBuilder builder,
            string namespace_
        )
        {
            GetRevocationConfig op = builder.Build(
                namespace_
            );

            return await ((Platform.Wrapper.Revocation)builder.WrapperObject!).GetRevocationConfigAsync(op);
        }
        public static Platform.Model.RevocationConfigInfo? Execute(
            this UpdateRevocationConfig.UpdateRevocationConfigBuilder builder,
            RevocationConfigUpdate body,
            string namespace_
        )
        {
            UpdateRevocationConfig op = builder.Build(
                body,
                namespace_
            );

            return ((Platform.Wrapper.Revocation)builder.WrapperObject!).UpdateRevocationConfig(op);
        }
        public static async Task<Platform.Model.RevocationConfigInfo?> ExecuteAsync(
            this UpdateRevocationConfig.UpdateRevocationConfigBuilder builder,
            RevocationConfigUpdate body,
            string namespace_
        )
        {
            UpdateRevocationConfig op = builder.Build(
                body,
                namespace_
            );

            return await ((Platform.Wrapper.Revocation)builder.WrapperObject!).UpdateRevocationConfigAsync(op);
        }
        public static void Execute(
            this DeleteRevocationConfig.DeleteRevocationConfigBuilder builder,
            string namespace_
        )
        {
            DeleteRevocationConfig op = builder.Build(
                namespace_
            );

            ((Platform.Wrapper.Revocation)builder.WrapperObject!).DeleteRevocationConfig(op);
        }
        public static async Task ExecuteAsync(
            this DeleteRevocationConfig.DeleteRevocationConfigBuilder builder,
            string namespace_
        )
        {
            DeleteRevocationConfig op = builder.Build(
                namespace_
            );

            await ((Platform.Wrapper.Revocation)builder.WrapperObject!).DeleteRevocationConfigAsync(op);
        }
        public static Platform.Model.RevocationHistoryPagingSlicedResult? Execute(
            this QueryRevocationHistories.QueryRevocationHistoriesBuilder builder,
            string namespace_
        )
        {
            QueryRevocationHistories op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Revocation)builder.WrapperObject!).QueryRevocationHistories(op);
        }
        public static async Task<Platform.Model.RevocationHistoryPagingSlicedResult?> ExecuteAsync(
            this QueryRevocationHistories.QueryRevocationHistoriesBuilder builder,
            string namespace_
        )
        {
            QueryRevocationHistories op = builder.Build(
                namespace_
            );

            return await ((Platform.Wrapper.Revocation)builder.WrapperObject!).QueryRevocationHistoriesAsync(op);
        }
        public static Platform.Model.RevocationResult? Execute(
            this DoRevocation.DoRevocationBuilder builder,
            RevocationRequest body,
            string namespace_,
            string userId
        )
        {
            DoRevocation op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Revocation)builder.WrapperObject!).DoRevocation(op);
        }
        public static async Task<Platform.Model.RevocationResult?> ExecuteAsync(
            this DoRevocation.DoRevocationBuilder builder,
            RevocationRequest body,
            string namespace_,
            string userId
        )
        {
            DoRevocation op = builder.Build(
                body,
                namespace_,
                userId
            );

            return await ((Platform.Wrapper.Revocation)builder.WrapperObject!).DoRevocationAsync(op);
        }
    }
}