// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Api.Csm.Operation;
using AccelByte.Sdk.Api.Csm.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class CsmApp_OpExts
    {
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static Csm.Model.GeneratedGetAppListV1Response? Execute(
            this GetAppListV1.GetAppListV1Builder builder,
            GeneratedGetAppListV1Request body,
            string namespace_
        )
        {
            GetAppListV1 op = builder.Build(
                body,
                namespace_
            );

            return ((Csm.Wrapper.App)builder.WrapperObject!).GetAppListV1(op);
        }
        public static async Task<Csm.Model.GeneratedGetAppListV1Response?> ExecuteAsync(
            this GetAppListV1.GetAppListV1Builder builder,
            GeneratedGetAppListV1Request body,
            string namespace_
        )
        {
            GetAppListV1 op = builder.Build(
                body,
                namespace_
            );

            return await ((Csm.Wrapper.App)builder.WrapperObject!).GetAppListV1Async(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static Csm.Model.GeneratedGetAppV1Response? Execute(
            this GetAppV1.GetAppV1Builder builder,
            string app,
            string namespace_
        )
        {
            GetAppV1 op = builder.Build(
                app,
                namespace_
            );

            return ((Csm.Wrapper.App)builder.WrapperObject!).GetAppV1(op);
        }
        public static async Task<Csm.Model.GeneratedGetAppV1Response?> ExecuteAsync(
            this GetAppV1.GetAppV1Builder builder,
            string app,
            string namespace_
        )
        {
            GetAppV1 op = builder.Build(
                app,
                namespace_
            );

            return await ((Csm.Wrapper.App)builder.WrapperObject!).GetAppV1Async(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static Csm.Model.GeneratedCreateAppV1Response? Execute(
            this CreateAppV1.CreateAppV1Builder builder,
            GeneratedCreateAppV1Request body,
            string app,
            string namespace_
        )
        {
            CreateAppV1 op = builder.Build(
                body,
                app,
                namespace_
            );

            return ((Csm.Wrapper.App)builder.WrapperObject!).CreateAppV1(op);
        }
        public static async Task<Csm.Model.GeneratedCreateAppV1Response?> ExecuteAsync(
            this CreateAppV1.CreateAppV1Builder builder,
            GeneratedCreateAppV1Request body,
            string app,
            string namespace_
        )
        {
            CreateAppV1 op = builder.Build(
                body,
                app,
                namespace_
            );

            return await ((Csm.Wrapper.App)builder.WrapperObject!).CreateAppV1Async(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static void Execute(
            this DeleteAppV1.DeleteAppV1Builder builder,
            string app,
            string namespace_
        )
        {
            DeleteAppV1 op = builder.Build(
                app,
                namespace_
            );

            ((Csm.Wrapper.App)builder.WrapperObject!).DeleteAppV1(op);
        }
        public static async Task ExecuteAsync(
            this DeleteAppV1.DeleteAppV1Builder builder,
            string app,
            string namespace_
        )
        {
            DeleteAppV1 op = builder.Build(
                app,
                namespace_
            );

            await ((Csm.Wrapper.App)builder.WrapperObject!).DeleteAppV1Async(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static Csm.Model.GeneratedUpdateAppV1Response? Execute(
            this UpdateAppV1.UpdateAppV1Builder builder,
            GeneratedUpdateAppV1Request body,
            string app,
            string namespace_
        )
        {
            UpdateAppV1 op = builder.Build(
                body,
                app,
                namespace_
            );

            return ((Csm.Wrapper.App)builder.WrapperObject!).UpdateAppV1(op);
        }
        public static async Task<Csm.Model.GeneratedUpdateAppV1Response?> ExecuteAsync(
            this UpdateAppV1.UpdateAppV1Builder builder,
            GeneratedUpdateAppV1Request body,
            string app,
            string namespace_
        )
        {
            UpdateAppV1 op = builder.Build(
                body,
                app,
                namespace_
            );

            return await ((Csm.Wrapper.App)builder.WrapperObject!).UpdateAppV1Async(op);
        }
        public static Csm.Model.GeneratedGetAppReleaseV1Response? Execute(
            this GetAppReleaseV1.GetAppReleaseV1Builder builder,
            string app,
            string namespace_
        )
        {
            GetAppReleaseV1 op = builder.Build(
                app,
                namespace_
            );

            return ((Csm.Wrapper.App)builder.WrapperObject!).GetAppReleaseV1(op);
        }
        public static async Task<Csm.Model.GeneratedGetAppReleaseV1Response?> ExecuteAsync(
            this GetAppReleaseV1.GetAppReleaseV1Builder builder,
            string app,
            string namespace_
        )
        {
            GetAppReleaseV1 op = builder.Build(
                app,
                namespace_
            );

            return await ((Csm.Wrapper.App)builder.WrapperObject!).GetAppReleaseV1Async(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static Csm.Model.GeneratedStartAppV1Response? Execute(
            this StartAppV1.StartAppV1Builder builder,
            GeneratedStartAppV1Request body,
            string app,
            string namespace_
        )
        {
            StartAppV1 op = builder.Build(
                body,
                app,
                namespace_
            );

            return ((Csm.Wrapper.App)builder.WrapperObject!).StartAppV1(op);
        }
        public static async Task<Csm.Model.GeneratedStartAppV1Response?> ExecuteAsync(
            this StartAppV1.StartAppV1Builder builder,
            GeneratedStartAppV1Request body,
            string app,
            string namespace_
        )
        {
            StartAppV1 op = builder.Build(
                body,
                app,
                namespace_
            );

            return await ((Csm.Wrapper.App)builder.WrapperObject!).StartAppV1Async(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static Csm.Model.GeneratedStopAppV1Response? Execute(
            this StopAppV1.StopAppV1Builder builder,
            GeneratedStopAppV1Request body,
            string app,
            string namespace_
        )
        {
            StopAppV1 op = builder.Build(
                body,
                app,
                namespace_
            );

            return ((Csm.Wrapper.App)builder.WrapperObject!).StopAppV1(op);
        }
        public static async Task<Csm.Model.GeneratedStopAppV1Response?> ExecuteAsync(
            this StopAppV1.StopAppV1Builder builder,
            GeneratedStopAppV1Request body,
            string app,
            string namespace_
        )
        {
            StopAppV1 op = builder.Build(
                body,
                app,
                namespace_
            );

            return await ((Csm.Wrapper.App)builder.WrapperObject!).StopAppV1Async(op);
        }
    }
}