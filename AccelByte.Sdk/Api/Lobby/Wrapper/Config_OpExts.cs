// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LobbyConfig_OpExts
    {
        public static Lobby.Model.ModelsConfigList? Execute(
            this AdminGetAllConfigV1.AdminGetAllConfigV1Builder builder
        )
        {
            AdminGetAllConfigV1 op = builder.Build(
            );

            return ((Lobby.Wrapper.Config)builder.WrapperObject!).AdminGetAllConfigV1(op);
        }
        public static async Task<Lobby.Model.ModelsConfigList?> ExecuteAsync(
            this AdminGetAllConfigV1.AdminGetAllConfigV1Builder builder
        )
        {
            AdminGetAllConfigV1 op = builder.Build(
            );

            return await ((Lobby.Wrapper.Config)builder.WrapperObject!).AdminGetAllConfigV1Async(op);
        }
        public static Lobby.Model.ModelsConfigReq? Execute(
            this AdminGetConfigV1.AdminGetConfigV1Builder builder,
            string namespace_
        )
        {
            AdminGetConfigV1 op = builder.Build(
                namespace_
            );

            return ((Lobby.Wrapper.Config)builder.WrapperObject!).AdminGetConfigV1(op);
        }
        public static async Task<Lobby.Model.ModelsConfigReq?> ExecuteAsync(
            this AdminGetConfigV1.AdminGetConfigV1Builder builder,
            string namespace_
        )
        {
            AdminGetConfigV1 op = builder.Build(
                namespace_
            );

            return await ((Lobby.Wrapper.Config)builder.WrapperObject!).AdminGetConfigV1Async(op);
        }
        public static Lobby.Model.ModelsConfigReq? Execute(
            this AdminUpdateConfigV1.AdminUpdateConfigV1Builder builder,
            ModelsConfigReq body,
            string namespace_
        )
        {
            AdminUpdateConfigV1 op = builder.Build(
                body,
                namespace_
            );

            return ((Lobby.Wrapper.Config)builder.WrapperObject!).AdminUpdateConfigV1(op);
        }
        public static async Task<Lobby.Model.ModelsConfigReq?> ExecuteAsync(
            this AdminUpdateConfigV1.AdminUpdateConfigV1Builder builder,
            ModelsConfigReq body,
            string namespace_
        )
        {
            AdminUpdateConfigV1 op = builder.Build(
                body,
                namespace_
            );

            return await ((Lobby.Wrapper.Config)builder.WrapperObject!).AdminUpdateConfigV1Async(op);
        }
        public static Stream? Execute(
            this AdminExportConfigV1.AdminExportConfigV1Builder builder,
            string namespace_
        )
        {
            AdminExportConfigV1 op = builder.Build(
                namespace_
            );

            return ((Lobby.Wrapper.Config)builder.WrapperObject!).AdminExportConfigV1(op);
        }
        public static async Task<Stream?> ExecuteAsync(
            this AdminExportConfigV1.AdminExportConfigV1Builder builder,
            string namespace_
        )
        {
            AdminExportConfigV1 op = builder.Build(
                namespace_
            );

            return await ((Lobby.Wrapper.Config)builder.WrapperObject!).AdminExportConfigV1Async(op);
        }
        public static Lobby.Model.ModelsImportConfigResponse? Execute(
            this AdminImportConfigV1.AdminImportConfigV1Builder builder,
            string namespace_
        )
        {
            AdminImportConfigV1 op = builder.Build(
                namespace_
            );

            return ((Lobby.Wrapper.Config)builder.WrapperObject!).AdminImportConfigV1(op);
        }
        public static async Task<Lobby.Model.ModelsImportConfigResponse?> ExecuteAsync(
            this AdminImportConfigV1.AdminImportConfigV1Builder builder,
            string namespace_
        )
        {
            AdminImportConfigV1 op = builder.Build(
                namespace_
            );

            return await ((Lobby.Wrapper.Config)builder.WrapperObject!).AdminImportConfigV1Async(op);
        }
    }
}