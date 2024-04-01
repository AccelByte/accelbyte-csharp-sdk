// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Api.Match2.Operation;
using AccelByte.Sdk.Api.Match2.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class Match2Config_OpExts
    {
        public static Match2.Model.ApiNamespaceConfigList? Execute(
            this AdminGetAllConfigV1.AdminGetAllConfigV1Builder builder
        )
        {
            AdminGetAllConfigV1 op = builder.Build(
            );

            return ((Match2.Wrapper.Config)builder.WrapperObject!).AdminGetAllConfigV1(op);
        }
        public static async Task<Match2.Model.ApiNamespaceConfigList?> ExecuteAsync(
            this AdminGetAllConfigV1.AdminGetAllConfigV1Builder builder
        )
        {
            AdminGetAllConfigV1 op = builder.Build(
            );

            return await ((Match2.Wrapper.Config)builder.WrapperObject!).AdminGetAllConfigV1Async(op);
        }
        public static Match2.Model.ConfigmodelsNamespaceConfig? Execute(
            this AdminGetConfigV1.AdminGetConfigV1Builder builder,
            string namespace_
        )
        {
            AdminGetConfigV1 op = builder.Build(
                namespace_
            );

            return ((Match2.Wrapper.Config)builder.WrapperObject!).AdminGetConfigV1(op);
        }
        public static async Task<Match2.Model.ConfigmodelsNamespaceConfig?> ExecuteAsync(
            this AdminGetConfigV1.AdminGetConfigV1Builder builder,
            string namespace_
        )
        {
            AdminGetConfigV1 op = builder.Build(
                namespace_
            );

            return await ((Match2.Wrapper.Config)builder.WrapperObject!).AdminGetConfigV1Async(op);
        }
        public static Match2.Model.ConfigmodelsNamespaceConfig? Execute(
            this AdminPatchConfigV1.AdminPatchConfigV1Builder builder,
            ApiPatchNamespaceConfigRequest body,
            string namespace_
        )
        {
            AdminPatchConfigV1 op = builder.Build(
                body,
                namespace_
            );

            return ((Match2.Wrapper.Config)builder.WrapperObject!).AdminPatchConfigV1(op);
        }
        public static async Task<Match2.Model.ConfigmodelsNamespaceConfig?> ExecuteAsync(
            this AdminPatchConfigV1.AdminPatchConfigV1Builder builder,
            ApiPatchNamespaceConfigRequest body,
            string namespace_
        )
        {
            AdminPatchConfigV1 op = builder.Build(
                body,
                namespace_
            );

            return await ((Match2.Wrapper.Config)builder.WrapperObject!).AdminPatchConfigV1Async(op);
        }
    }
}