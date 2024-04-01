// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Api.Chat.Operation;
using AccelByte.Sdk.Api.Chat.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class ChatConfig_OpExts
    {
        public static Chat.Model.ModelsConfigList? Execute(
            this AdminGetAllConfigV1.AdminGetAllConfigV1Builder builder
        )
        {
            AdminGetAllConfigV1 op = builder.Build(
            );

            return ((Chat.Wrapper.Config)builder.WrapperObject!).AdminGetAllConfigV1(op);
        }
        public static async Task<Chat.Model.ModelsConfigList?> ExecuteAsync(
            this AdminGetAllConfigV1.AdminGetAllConfigV1Builder builder
        )
        {
            AdminGetAllConfigV1 op = builder.Build(
            );

            return await ((Chat.Wrapper.Config)builder.WrapperObject!).AdminGetAllConfigV1Async(op);
        }
        public static Chat.Model.ModelsConfigResponse? Execute(
            this AdminGetConfigV1.AdminGetConfigV1Builder builder,
            string namespace_
        )
        {
            AdminGetConfigV1 op = builder.Build(
                namespace_
            );

            return ((Chat.Wrapper.Config)builder.WrapperObject!).AdminGetConfigV1(op);
        }
        public static async Task<Chat.Model.ModelsConfigResponse?> ExecuteAsync(
            this AdminGetConfigV1.AdminGetConfigV1Builder builder,
            string namespace_
        )
        {
            AdminGetConfigV1 op = builder.Build(
                namespace_
            );

            return await ((Chat.Wrapper.Config)builder.WrapperObject!).AdminGetConfigV1Async(op);
        }
        public static Chat.Model.ModelsConfigResponse? Execute(
            this AdminUpdateConfigV1.AdminUpdateConfigV1Builder builder,
            ModelsConfigResponse body,
            string namespace_
        )
        {
            AdminUpdateConfigV1 op = builder.Build(
                body,
                namespace_
            );

            return ((Chat.Wrapper.Config)builder.WrapperObject!).AdminUpdateConfigV1(op);
        }
        public static async Task<Chat.Model.ModelsConfigResponse?> ExecuteAsync(
            this AdminUpdateConfigV1.AdminUpdateConfigV1Builder builder,
            ModelsConfigResponse body,
            string namespace_
        )
        {
            AdminUpdateConfigV1 op = builder.Build(
                body,
                namespace_
            );

            return await ((Chat.Wrapper.Config)builder.WrapperObject!).AdminUpdateConfigV1Async(op);
        }
        public static List<Chat.Model.ModelsConfigExport>? Execute(
            this ExportConfig.ExportConfigBuilder builder,
            string namespace_
        )
        {
            ExportConfig op = builder.Build(
                namespace_
            );

            return ((Chat.Wrapper.Config)builder.WrapperObject!).ExportConfig(op);
        }
        public static async Task<List<Chat.Model.ModelsConfigExport>?> ExecuteAsync(
            this ExportConfig.ExportConfigBuilder builder,
            string namespace_
        )
        {
            ExportConfig op = builder.Build(
                namespace_
            );

            return await ((Chat.Wrapper.Config)builder.WrapperObject!).ExportConfigAsync(op);
        }
        public static Chat.Model.ModelsImportConfigResponse? Execute(
            this ImportConfig.ImportConfigBuilder builder,
            string namespace_
        )
        {
            ImportConfig op = builder.Build(
                namespace_
            );

            return ((Chat.Wrapper.Config)builder.WrapperObject!).ImportConfig(op);
        }
        public static async Task<Chat.Model.ModelsImportConfigResponse?> ExecuteAsync(
            this ImportConfig.ImportConfigBuilder builder,
            string namespace_
        )
        {
            ImportConfig op = builder.Build(
                namespace_
            );

            return await ((Chat.Wrapper.Config)builder.WrapperObject!).ImportConfigAsync(op);
        }
    }
}