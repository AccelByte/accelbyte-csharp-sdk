// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Api.Reporting.Operation;
using AccelByte.Sdk.Api.Reporting.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class ReportingAdminConfigurations_OpExts
    {
        public static Reporting.Model.RestapiConfigResponse? Execute(
            this Get.GetBuilder builder,
            string namespace_
        )
        {
            Get op = builder.Build(
                namespace_
            );

            return ((Reporting.Wrapper.AdminConfigurations)builder.WrapperObject!).Get(op);
        }
        public static async Task<Reporting.Model.RestapiConfigResponse?> ExecuteAsync(
            this Get.GetBuilder builder,
            string namespace_
        )
        {
            Get op = builder.Build(
                namespace_
            );

            return await ((Reporting.Wrapper.AdminConfigurations)builder.WrapperObject!).GetAsync(op);
        }
        public static Reporting.Model.RestapiConfigResponse? Execute(
            this Upsert.UpsertBuilder builder,
            RestapiReportingLimit body,
            string namespace_
        )
        {
            Upsert op = builder.Build(
                body,
                namespace_
            );

            return ((Reporting.Wrapper.AdminConfigurations)builder.WrapperObject!).Upsert(op);
        }
        public static async Task<Reporting.Model.RestapiConfigResponse?> ExecuteAsync(
            this Upsert.UpsertBuilder builder,
            RestapiReportingLimit body,
            string namespace_
        )
        {
            Upsert op = builder.Build(
                body,
                namespace_
            );

            return await ((Reporting.Wrapper.AdminConfigurations)builder.WrapperObject!).UpsertAsync(op);
        }
    }
}