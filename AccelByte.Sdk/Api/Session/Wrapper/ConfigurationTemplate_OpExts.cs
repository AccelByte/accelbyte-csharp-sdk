// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;
using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SessionConfigurationTemplate_OpExts
    {
        public static Session.Model.ApimodelsConfigAlertResponse? Execute(
            this AdminGetConfigurationAlertV1.AdminGetConfigurationAlertV1Builder builder,
            string namespace_
        )
        {
            AdminGetConfigurationAlertV1 op = builder.Build(
                namespace_
            );

            return ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminGetConfigurationAlertV1(op);
        }
        public static async Task<Session.Model.ApimodelsConfigAlertResponse?> ExecuteAsync(
            this AdminGetConfigurationAlertV1.AdminGetConfigurationAlertV1Builder builder,
            string namespace_
        )
        {
            AdminGetConfigurationAlertV1 op = builder.Build(
                namespace_
            );

            return await ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminGetConfigurationAlertV1Async(op);
        }
        public static Session.Model.ApimodelsConfigAlertResponse? Execute(
            this AdminUpdateConfigurationAlertV1.AdminUpdateConfigurationAlertV1Builder builder,
            ApimodelsConfigAlertRequestCreate body,
            string namespace_
        )
        {
            AdminUpdateConfigurationAlertV1 op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminUpdateConfigurationAlertV1(op);
        }
        public static async Task<Session.Model.ApimodelsConfigAlertResponse?> ExecuteAsync(
            this AdminUpdateConfigurationAlertV1.AdminUpdateConfigurationAlertV1Builder builder,
            ApimodelsConfigAlertRequestCreate body,
            string namespace_
        )
        {
            AdminUpdateConfigurationAlertV1 op = builder.Build(
                body,
                namespace_
            );

            return await ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminUpdateConfigurationAlertV1Async(op);
        }
        public static Session.Model.ApimodelsConfigAlertResponse? Execute(
            this AdminCreateConfigurationAlertV1.AdminCreateConfigurationAlertV1Builder builder,
            ApimodelsConfigAlertRequestCreate body,
            string namespace_
        )
        {
            AdminCreateConfigurationAlertV1 op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminCreateConfigurationAlertV1(op);
        }
        public static async Task<Session.Model.ApimodelsConfigAlertResponse?> ExecuteAsync(
            this AdminCreateConfigurationAlertV1.AdminCreateConfigurationAlertV1Builder builder,
            ApimodelsConfigAlertRequestCreate body,
            string namespace_
        )
        {
            AdminCreateConfigurationAlertV1 op = builder.Build(
                body,
                namespace_
            );

            return await ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminCreateConfigurationAlertV1Async(op);
        }
        public static void Execute(
            this AdminDeleteConfigurationAlertV1.AdminDeleteConfigurationAlertV1Builder builder,
            string namespace_
        )
        {
            AdminDeleteConfigurationAlertV1 op = builder.Build(
                namespace_
            );

            ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminDeleteConfigurationAlertV1(op);
        }
        public static async Task ExecuteAsync(
            this AdminDeleteConfigurationAlertV1.AdminDeleteConfigurationAlertV1Builder builder,
            string namespace_
        )
        {
            AdminDeleteConfigurationAlertV1 op = builder.Build(
                namespace_
            );

            await ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminDeleteConfigurationAlertV1Async(op);
        }
        public static Session.Model.ApimodelsConfigurationTemplateResponse? Execute(
            this AdminCreateConfigurationTemplateV1.AdminCreateConfigurationTemplateV1Builder builder,
            ApimodelsCreateConfigurationTemplateRequest body,
            string namespace_
        )
        {
            AdminCreateConfigurationTemplateV1 op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminCreateConfigurationTemplateV1(op);
        }
        public static async Task<Session.Model.ApimodelsConfigurationTemplateResponse?> ExecuteAsync(
            this AdminCreateConfigurationTemplateV1.AdminCreateConfigurationTemplateV1Builder builder,
            ApimodelsCreateConfigurationTemplateRequest body,
            string namespace_
        )
        {
            AdminCreateConfigurationTemplateV1 op = builder.Build(
                body,
                namespace_
            );

            return await ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminCreateConfigurationTemplateV1Async(op);
        }

        public static Session.Model.ApimodelsConfigurationTemplateResponse<T1>? Execute<T1>(
            this AdminCreateConfigurationTemplateV1.AdminCreateConfigurationTemplateV1Builder builder,
            ApimodelsCreateConfigurationTemplateRequest body,
            string namespace_
        )
        {
            AdminCreateConfigurationTemplateV1 op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminCreateConfigurationTemplateV1<T1>(op);
        }
        public static async Task<Session.Model.ApimodelsConfigurationTemplateResponse<T1>?> ExecuteAsync<T1>(
            this AdminCreateConfigurationTemplateV1.AdminCreateConfigurationTemplateV1Builder builder,
            ApimodelsCreateConfigurationTemplateRequest body,
            string namespace_
        )
        {
            AdminCreateConfigurationTemplateV1 op = builder.Build(
                body,
                namespace_
            );

            return await ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminCreateConfigurationTemplateV1Async<T1>(op);
        }
        public static Session.Model.ApimodelsConfigurationTemplatesResponse? Execute(
            this AdminGetAllConfigurationTemplatesV1.AdminGetAllConfigurationTemplatesV1Builder builder,
            string namespace_
        )
        {
            AdminGetAllConfigurationTemplatesV1 op = builder.Build(
                namespace_
            );

            return ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminGetAllConfigurationTemplatesV1(op);
        }
        public static async Task<Session.Model.ApimodelsConfigurationTemplatesResponse?> ExecuteAsync(
            this AdminGetAllConfigurationTemplatesV1.AdminGetAllConfigurationTemplatesV1Builder builder,
            string namespace_
        )
        {
            AdminGetAllConfigurationTemplatesV1 op = builder.Build(
                namespace_
            );

            return await ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminGetAllConfigurationTemplatesV1Async(op);
        }
        public static Session.Model.ApimodelsConfigurationTemplateResponse? Execute(
            this AdminGetConfigurationTemplateV1.AdminGetConfigurationTemplateV1Builder builder,
            string name,
            string namespace_
        )
        {
            AdminGetConfigurationTemplateV1 op = builder.Build(
                name,
                namespace_
            );

            return ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminGetConfigurationTemplateV1(op);
        }
        public static async Task<Session.Model.ApimodelsConfigurationTemplateResponse?> ExecuteAsync(
            this AdminGetConfigurationTemplateV1.AdminGetConfigurationTemplateV1Builder builder,
            string name,
            string namespace_
        )
        {
            AdminGetConfigurationTemplateV1 op = builder.Build(
                name,
                namespace_
            );

            return await ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminGetConfigurationTemplateV1Async(op);
        }

        public static Session.Model.ApimodelsConfigurationTemplateResponse<T1>? Execute<T1>(
            this AdminGetConfigurationTemplateV1.AdminGetConfigurationTemplateV1Builder builder,
            string name,
            string namespace_
        )
        {
            AdminGetConfigurationTemplateV1 op = builder.Build(
                name,
                namespace_
            );

            return ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminGetConfigurationTemplateV1<T1>(op);
        }
        public static async Task<Session.Model.ApimodelsConfigurationTemplateResponse<T1>?> ExecuteAsync<T1>(
            this AdminGetConfigurationTemplateV1.AdminGetConfigurationTemplateV1Builder builder,
            string name,
            string namespace_
        )
        {
            AdminGetConfigurationTemplateV1 op = builder.Build(
                name,
                namespace_
            );

            return await ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminGetConfigurationTemplateV1Async<T1>(op);
        }
        public static Session.Model.ApimodelsConfigurationTemplateResponse? Execute(
            this AdminUpdateConfigurationTemplateV1.AdminUpdateConfigurationTemplateV1Builder builder,
            ApimodelsUpdateConfigurationTemplateRequest body,
            string name,
            string namespace_
        )
        {
            AdminUpdateConfigurationTemplateV1 op = builder.Build(
                body,
                name,
                namespace_
            );

            return ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminUpdateConfigurationTemplateV1(op);
        }
        public static async Task<Session.Model.ApimodelsConfigurationTemplateResponse?> ExecuteAsync(
            this AdminUpdateConfigurationTemplateV1.AdminUpdateConfigurationTemplateV1Builder builder,
            ApimodelsUpdateConfigurationTemplateRequest body,
            string name,
            string namespace_
        )
        {
            AdminUpdateConfigurationTemplateV1 op = builder.Build(
                body,
                name,
                namespace_
            );

            return await ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminUpdateConfigurationTemplateV1Async(op);
        }

        public static Session.Model.ApimodelsConfigurationTemplateResponse<T1>? Execute<T1>(
            this AdminUpdateConfigurationTemplateV1.AdminUpdateConfigurationTemplateV1Builder builder,
            ApimodelsUpdateConfigurationTemplateRequest body,
            string name,
            string namespace_
        )
        {
            AdminUpdateConfigurationTemplateV1 op = builder.Build(
                body,
                name,
                namespace_
            );

            return ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminUpdateConfigurationTemplateV1<T1>(op);
        }
        public static async Task<Session.Model.ApimodelsConfigurationTemplateResponse<T1>?> ExecuteAsync<T1>(
            this AdminUpdateConfigurationTemplateV1.AdminUpdateConfigurationTemplateV1Builder builder,
            ApimodelsUpdateConfigurationTemplateRequest body,
            string name,
            string namespace_
        )
        {
            AdminUpdateConfigurationTemplateV1 op = builder.Build(
                body,
                name,
                namespace_
            );

            return await ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminUpdateConfigurationTemplateV1Async<T1>(op);
        }
        public static void Execute(
            this AdminDeleteConfigurationTemplateV1.AdminDeleteConfigurationTemplateV1Builder builder,
            string name,
            string namespace_
        )
        {
            AdminDeleteConfigurationTemplateV1 op = builder.Build(
                name,
                namespace_
            );

            ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminDeleteConfigurationTemplateV1(op);
        }
        public static async Task ExecuteAsync(
            this AdminDeleteConfigurationTemplateV1.AdminDeleteConfigurationTemplateV1Builder builder,
            string name,
            string namespace_
        )
        {
            AdminDeleteConfigurationTemplateV1 op = builder.Build(
                name,
                namespace_
            );

            await ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminDeleteConfigurationTemplateV1Async(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static Session.Model.ModelsDSMConfigRecord? Execute(
            this AdminGetDSMCConfiguration.AdminGetDSMCConfigurationBuilder builder,
            string namespace_
        )
        {
            AdminGetDSMCConfiguration op = builder.Build(
                namespace_
            );

            return ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminGetDSMCConfiguration(op);
        }
        public static async Task<Session.Model.ModelsDSMConfigRecord?> ExecuteAsync(
            this AdminGetDSMCConfiguration.AdminGetDSMCConfigurationBuilder builder,
            string namespace_
        )
        {
            AdminGetDSMCConfiguration op = builder.Build(
                namespace_
            );

            return await ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminGetDSMCConfigurationAsync(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static Session.Model.ModelsDSMConfigRecord? Execute(
            this AdminSyncDSMCConfiguration.AdminSyncDSMCConfigurationBuilder builder,
            string namespace_
        )
        {
            AdminSyncDSMCConfiguration op = builder.Build(
                namespace_
            );

            return ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminSyncDSMCConfiguration(op);
        }
        public static async Task<Session.Model.ModelsDSMConfigRecord?> ExecuteAsync(
            this AdminSyncDSMCConfiguration.AdminSyncDSMCConfigurationBuilder builder,
            string namespace_
        )
        {
            AdminSyncDSMCConfiguration op = builder.Build(
                namespace_
            );

            return await ((Session.Wrapper.ConfigurationTemplate)builder.WrapperObject!).AdminSyncDSMCConfigurationAsync(op);
        }
    }
}