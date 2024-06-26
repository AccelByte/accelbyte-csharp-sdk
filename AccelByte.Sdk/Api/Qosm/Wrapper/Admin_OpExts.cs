// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Api.Qosm.Operation;
using AccelByte.Sdk.Api.Qosm.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class QosmAdmin_OpExts
    {
        public static void Execute(
            this UpdateServerConfig.UpdateServerConfigBuilder builder,
            ModelsUpdateServerRequest body,
            string namespace_,
            string region
        )
        {
            UpdateServerConfig op = builder.Build(
                body,
                namespace_,
                region
            );

            ((Qosm.Wrapper.Admin)builder.WrapperObject!).UpdateServerConfig(op);
        }
        public static async Task ExecuteAsync(
            this UpdateServerConfig.UpdateServerConfigBuilder builder,
            ModelsUpdateServerRequest body,
            string namespace_,
            string region
        )
        {
            UpdateServerConfig op = builder.Build(
                body,
                namespace_,
                region
            );

            await ((Qosm.Wrapper.Admin)builder.WrapperObject!).UpdateServerConfigAsync(op);
        }
        public static void Execute(
            this DeleteServer.DeleteServerBuilder builder,
            string region
        )
        {
            DeleteServer op = builder.Build(
                region
            );

            ((Qosm.Wrapper.Admin)builder.WrapperObject!).DeleteServer(op);
        }
        public static async Task ExecuteAsync(
            this DeleteServer.DeleteServerBuilder builder,
            string region
        )
        {
            DeleteServer op = builder.Build(
                region
            );

            await ((Qosm.Wrapper.Admin)builder.WrapperObject!).DeleteServerAsync(op);
        }
        public static void Execute(
            this SetServerAlias.SetServerAliasBuilder builder,
            ModelsSetAliasRequest body,
            string region
        )
        {
            SetServerAlias op = builder.Build(
                body,
                region
            );

            ((Qosm.Wrapper.Admin)builder.WrapperObject!).SetServerAlias(op);
        }
        public static async Task ExecuteAsync(
            this SetServerAlias.SetServerAliasBuilder builder,
            ModelsSetAliasRequest body,
            string region
        )
        {
            SetServerAlias op = builder.Build(
                body,
                region
            );

            await ((Qosm.Wrapper.Admin)builder.WrapperObject!).SetServerAliasAsync(op);
        }
    }
}