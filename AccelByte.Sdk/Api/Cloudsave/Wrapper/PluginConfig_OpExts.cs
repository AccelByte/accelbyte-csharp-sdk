// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Api.Cloudsave.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class CloudsavePluginConfig_OpExts
    {
        public static Cloudsave.Model.ModelsPluginResponse? Execute(
            this GetPluginConfig.GetPluginConfigBuilder builder,
            string namespace_
        )
        {
            GetPluginConfig op = builder.Build(
                namespace_
            );

            return ((Cloudsave.Wrapper.PluginConfig)builder.WrapperObject!).GetPluginConfig(op);
        }
        public static async Task<Cloudsave.Model.ModelsPluginResponse?> ExecuteAsync(
            this GetPluginConfig.GetPluginConfigBuilder builder,
            string namespace_
        )
        {
            GetPluginConfig op = builder.Build(
                namespace_
            );

            return await ((Cloudsave.Wrapper.PluginConfig)builder.WrapperObject!).GetPluginConfigAsync(op);
        }
        public static Cloudsave.Model.ModelsPluginResponse? Execute(
            this CreatePluginConfig.CreatePluginConfigBuilder builder,
            ModelsPluginRequest body,
            string namespace_
        )
        {
            CreatePluginConfig op = builder.Build(
                body,
                namespace_
            );

            return ((Cloudsave.Wrapper.PluginConfig)builder.WrapperObject!).CreatePluginConfig(op);
        }
        public static async Task<Cloudsave.Model.ModelsPluginResponse?> ExecuteAsync(
            this CreatePluginConfig.CreatePluginConfigBuilder builder,
            ModelsPluginRequest body,
            string namespace_
        )
        {
            CreatePluginConfig op = builder.Build(
                body,
                namespace_
            );

            return await ((Cloudsave.Wrapper.PluginConfig)builder.WrapperObject!).CreatePluginConfigAsync(op);
        }
        public static void Execute(
            this DeletePluginConfig.DeletePluginConfigBuilder builder,
            string namespace_
        )
        {
            DeletePluginConfig op = builder.Build(
                namespace_
            );

            ((Cloudsave.Wrapper.PluginConfig)builder.WrapperObject!).DeletePluginConfig(op);
        }
        public static async Task ExecuteAsync(
            this DeletePluginConfig.DeletePluginConfigBuilder builder,
            string namespace_
        )
        {
            DeletePluginConfig op = builder.Build(
                namespace_
            );

            await ((Cloudsave.Wrapper.PluginConfig)builder.WrapperObject!).DeletePluginConfigAsync(op);
        }
        public static Cloudsave.Model.ModelsPluginResponse? Execute(
            this UpdatePluginConfig.UpdatePluginConfigBuilder builder,
            ModelsPluginRequest body,
            string namespace_
        )
        {
            UpdatePluginConfig op = builder.Build(
                body,
                namespace_
            );

            return ((Cloudsave.Wrapper.PluginConfig)builder.WrapperObject!).UpdatePluginConfig(op);
        }
        public static async Task<Cloudsave.Model.ModelsPluginResponse?> ExecuteAsync(
            this UpdatePluginConfig.UpdatePluginConfigBuilder builder,
            ModelsPluginRequest body,
            string namespace_
        )
        {
            UpdatePluginConfig op = builder.Build(
                body,
                namespace_
            );

            return await ((Cloudsave.Wrapper.PluginConfig)builder.WrapperObject!).UpdatePluginConfigAsync(op);
        }
    }
}