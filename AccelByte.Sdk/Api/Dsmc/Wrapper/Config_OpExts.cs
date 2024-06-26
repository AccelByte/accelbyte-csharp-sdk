// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class DsmcConfig_OpExts
    {
        public static Dsmc.Model.ModelsListConfigResponse? Execute(
            this ListConfig.ListConfigBuilder builder
        )
        {
            ListConfig op = builder.Build(
            );

            return ((Dsmc.Wrapper.Config)builder.WrapperObject!).ListConfig(op);
        }
        public static async Task<Dsmc.Model.ModelsListConfigResponse?> ExecuteAsync(
            this ListConfig.ListConfigBuilder builder
        )
        {
            ListConfig op = builder.Build(
            );

            return await ((Dsmc.Wrapper.Config)builder.WrapperObject!).ListConfigAsync(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static void Execute(
            this SaveConfig.SaveConfigBuilder builder,
            ModelsDSMConfigRecord body
        )
        {
            SaveConfig op = builder.Build(
                body
            );

            ((Dsmc.Wrapper.Config)builder.WrapperObject!).SaveConfig(op);
        }
        public static async Task ExecuteAsync(
            this SaveConfig.SaveConfigBuilder builder,
            ModelsDSMConfigRecord body
        )
        {
            SaveConfig op = builder.Build(
                body
            );

            await ((Dsmc.Wrapper.Config)builder.WrapperObject!).SaveConfigAsync(op);
        }
        public static Dsmc.Model.ModelsDSMConfigRecord? Execute(
            this GetConfig.GetConfigBuilder builder,
            string namespace_
        )
        {
            GetConfig op = builder.Build(
                namespace_
            );

            return ((Dsmc.Wrapper.Config)builder.WrapperObject!).GetConfig(op);
        }
        public static async Task<Dsmc.Model.ModelsDSMConfigRecord?> ExecuteAsync(
            this GetConfig.GetConfigBuilder builder,
            string namespace_
        )
        {
            GetConfig op = builder.Build(
                namespace_
            );

            return await ((Dsmc.Wrapper.Config)builder.WrapperObject!).GetConfigAsync(op);
        }
        public static Dsmc.Model.ModelsDSMConfigRecord? Execute(
            this CreateConfig.CreateConfigBuilder builder,
            ModelsCreateDSMConfigRequest body,
            string namespace_
        )
        {
            CreateConfig op = builder.Build(
                body,
                namespace_
            );

            return ((Dsmc.Wrapper.Config)builder.WrapperObject!).CreateConfig(op);
        }
        public static async Task<Dsmc.Model.ModelsDSMConfigRecord?> ExecuteAsync(
            this CreateConfig.CreateConfigBuilder builder,
            ModelsCreateDSMConfigRequest body,
            string namespace_
        )
        {
            CreateConfig op = builder.Build(
                body,
                namespace_
            );

            return await ((Dsmc.Wrapper.Config)builder.WrapperObject!).CreateConfigAsync(op);
        }
        public static void Execute(
            this DeleteConfig.DeleteConfigBuilder builder,
            string namespace_
        )
        {
            DeleteConfig op = builder.Build(
                namespace_
            );

            ((Dsmc.Wrapper.Config)builder.WrapperObject!).DeleteConfig(op);
        }
        public static async Task ExecuteAsync(
            this DeleteConfig.DeleteConfigBuilder builder,
            string namespace_
        )
        {
            DeleteConfig op = builder.Build(
                namespace_
            );

            await ((Dsmc.Wrapper.Config)builder.WrapperObject!).DeleteConfigAsync(op);
        }
        public static Dsmc.Model.ModelsDSMConfigRecord? Execute(
            this UpdateConfig.UpdateConfigBuilder builder,
            ModelsUpdateDSMConfigRequest body,
            string namespace_
        )
        {
            UpdateConfig op = builder.Build(
                body,
                namespace_
            );

            return ((Dsmc.Wrapper.Config)builder.WrapperObject!).UpdateConfig(op);
        }
        public static async Task<Dsmc.Model.ModelsDSMConfigRecord?> ExecuteAsync(
            this UpdateConfig.UpdateConfigBuilder builder,
            ModelsUpdateDSMConfigRequest body,
            string namespace_
        )
        {
            UpdateConfig op = builder.Build(
                body,
                namespace_
            );

            return await ((Dsmc.Wrapper.Config)builder.WrapperObject!).UpdateConfigAsync(op);
        }
        public static void Execute(
            this ClearCache.ClearCacheBuilder builder,
            string namespace_
        )
        {
            ClearCache op = builder.Build(
                namespace_
            );

            ((Dsmc.Wrapper.Config)builder.WrapperObject!).ClearCache(op);
        }
        public static async Task ExecuteAsync(
            this ClearCache.ClearCacheBuilder builder,
            string namespace_
        )
        {
            ClearCache op = builder.Build(
                namespace_
            );

            await ((Dsmc.Wrapper.Config)builder.WrapperObject!).ClearCacheAsync(op);
        }
        public static Dsmc.Model.ModelsDSMConfigRecord? Execute(
            this AddPort.AddPortBuilder builder,
            ModelsCreatePortRequest body,
            string name,
            string namespace_
        )
        {
            AddPort op = builder.Build(
                body,
                name,
                namespace_
            );

            return ((Dsmc.Wrapper.Config)builder.WrapperObject!).AddPort(op);
        }
        public static async Task<Dsmc.Model.ModelsDSMConfigRecord?> ExecuteAsync(
            this AddPort.AddPortBuilder builder,
            ModelsCreatePortRequest body,
            string name,
            string namespace_
        )
        {
            AddPort op = builder.Build(
                body,
                name,
                namespace_
            );

            return await ((Dsmc.Wrapper.Config)builder.WrapperObject!).AddPortAsync(op);
        }
        public static Dsmc.Model.ModelsDSMConfigRecord? Execute(
            this DeletePort.DeletePortBuilder builder,
            string name,
            string namespace_
        )
        {
            DeletePort op = builder.Build(
                name,
                namespace_
            );

            return ((Dsmc.Wrapper.Config)builder.WrapperObject!).DeletePort(op);
        }
        public static async Task<Dsmc.Model.ModelsDSMConfigRecord?> ExecuteAsync(
            this DeletePort.DeletePortBuilder builder,
            string name,
            string namespace_
        )
        {
            DeletePort op = builder.Build(
                name,
                namespace_
            );

            return await ((Dsmc.Wrapper.Config)builder.WrapperObject!).DeletePortAsync(op);
        }
        public static Dsmc.Model.ModelsDSMConfigRecord? Execute(
            this UpdatePort.UpdatePortBuilder builder,
            ModelsUpdatePortRequest body,
            string name,
            string namespace_
        )
        {
            UpdatePort op = builder.Build(
                body,
                name,
                namespace_
            );

            return ((Dsmc.Wrapper.Config)builder.WrapperObject!).UpdatePort(op);
        }
        public static async Task<Dsmc.Model.ModelsDSMConfigRecord?> ExecuteAsync(
            this UpdatePort.UpdatePortBuilder builder,
            ModelsUpdatePortRequest body,
            string name,
            string namespace_
        )
        {
            UpdatePort op = builder.Build(
                body,
                name,
                namespace_
            );

            return await ((Dsmc.Wrapper.Config)builder.WrapperObject!).UpdatePortAsync(op);
        }
        public static Stream? Execute(
            this ExportConfigV1.ExportConfigV1Builder builder,
            string namespace_
        )
        {
            ExportConfigV1 op = builder.Build(
                namespace_
            );

            return ((Dsmc.Wrapper.Config)builder.WrapperObject!).ExportConfigV1(op);
        }
        public static async Task<Stream?> ExecuteAsync(
            this ExportConfigV1.ExportConfigV1Builder builder,
            string namespace_
        )
        {
            ExportConfigV1 op = builder.Build(
                namespace_
            );

            return await ((Dsmc.Wrapper.Config)builder.WrapperObject!).ExportConfigV1Async(op);
        }
        public static Dsmc.Model.ModelsImportResponse? Execute(
            this ImportConfigV1.ImportConfigV1Builder builder,
            string namespace_
        )
        {
            ImportConfigV1 op = builder.Build(
                namespace_
            );

            return ((Dsmc.Wrapper.Config)builder.WrapperObject!).ImportConfigV1(op);
        }
        public static async Task<Dsmc.Model.ModelsImportResponse?> ExecuteAsync(
            this ImportConfigV1.ImportConfigV1Builder builder,
            string namespace_
        )
        {
            ImportConfigV1 op = builder.Build(
                namespace_
            );

            return await ((Dsmc.Wrapper.Config)builder.WrapperObject!).ImportConfigV1Async(op);
        }
    }
}