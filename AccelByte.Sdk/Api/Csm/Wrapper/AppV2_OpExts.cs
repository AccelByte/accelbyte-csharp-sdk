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
    public static class CsmAppV2_OpExts
    {
        public static Csm.Model.ApimodelGetAppListV2Response? Execute(
            this GetAppListV2.GetAppListV2Builder builder,
            ApimodelGetAppListV2Request body,
            string namespace_
        )
        {
            GetAppListV2 op = builder.Build(
                body,
                namespace_
            );

            return ((Csm.Wrapper.AppV2)builder.WrapperObject!).GetAppListV2(op);
        }
        public static async Task<Csm.Model.ApimodelGetAppListV2Response?> ExecuteAsync(
            this GetAppListV2.GetAppListV2Builder builder,
            ApimodelGetAppListV2Request body,
            string namespace_
        )
        {
            GetAppListV2 op = builder.Build(
                body,
                namespace_
            );

            return await ((Csm.Wrapper.AppV2)builder.WrapperObject!).GetAppListV2Async(op);
        }
        public static Csm.Model.ApimodelAppItem? Execute(
            this GetAppV2.GetAppV2Builder builder,
            string app,
            string namespace_
        )
        {
            GetAppV2 op = builder.Build(
                app,
                namespace_
            );

            return ((Csm.Wrapper.AppV2)builder.WrapperObject!).GetAppV2(op);
        }
        public static async Task<Csm.Model.ApimodelAppItem?> ExecuteAsync(
            this GetAppV2.GetAppV2Builder builder,
            string app,
            string namespace_
        )
        {
            GetAppV2 op = builder.Build(
                app,
                namespace_
            );

            return await ((Csm.Wrapper.AppV2)builder.WrapperObject!).GetAppV2Async(op);
        }
        public static Csm.Model.ApimodelAppItem? Execute(
            this CreateAppV2.CreateAppV2Builder builder,
            ApimodelCreateAppV2Request body,
            string app,
            string namespace_
        )
        {
            CreateAppV2 op = builder.Build(
                body,
                app,
                namespace_
            );

            return ((Csm.Wrapper.AppV2)builder.WrapperObject!).CreateAppV2(op);
        }
        public static async Task<Csm.Model.ApimodelAppItem?> ExecuteAsync(
            this CreateAppV2.CreateAppV2Builder builder,
            ApimodelCreateAppV2Request body,
            string app,
            string namespace_
        )
        {
            CreateAppV2 op = builder.Build(
                body,
                app,
                namespace_
            );

            return await ((Csm.Wrapper.AppV2)builder.WrapperObject!).CreateAppV2Async(op);
        }
        public static void Execute(
            this DeleteAppV2.DeleteAppV2Builder builder,
            string app,
            string namespace_
        )
        {
            DeleteAppV2 op = builder.Build(
                app,
                namespace_
            );

            ((Csm.Wrapper.AppV2)builder.WrapperObject!).DeleteAppV2(op);
        }
        public static async Task ExecuteAsync(
            this DeleteAppV2.DeleteAppV2Builder builder,
            string app,
            string namespace_
        )
        {
            DeleteAppV2 op = builder.Build(
                app,
                namespace_
            );

            await ((Csm.Wrapper.AppV2)builder.WrapperObject!).DeleteAppV2Async(op);
        }
        public static Csm.Model.ApimodelAppItem? Execute(
            this UpdateAppV2.UpdateAppV2Builder builder,
            ApimodelUpdateAppV2Request body,
            string app,
            string namespace_
        )
        {
            UpdateAppV2 op = builder.Build(
                body,
                app,
                namespace_
            );

            return ((Csm.Wrapper.AppV2)builder.WrapperObject!).UpdateAppV2(op);
        }
        public static async Task<Csm.Model.ApimodelAppItem?> ExecuteAsync(
            this UpdateAppV2.UpdateAppV2Builder builder,
            ApimodelUpdateAppV2Request body,
            string app,
            string namespace_
        )
        {
            UpdateAppV2 op = builder.Build(
                body,
                app,
                namespace_
            );

            return await ((Csm.Wrapper.AppV2)builder.WrapperObject!).UpdateAppV2Async(op);
        }
        public static Csm.Model.ApimodelAppItem? Execute(
            this UpdateAppResourcesV2.UpdateAppResourcesV2Builder builder,
            ApimodelUpdateAppResourceRequest body,
            string app,
            string namespace_
        )
        {
            UpdateAppResourcesV2 op = builder.Build(
                body,
                app,
                namespace_
            );

            return ((Csm.Wrapper.AppV2)builder.WrapperObject!).UpdateAppResourcesV2(op);
        }
        public static async Task<Csm.Model.ApimodelAppItem?> ExecuteAsync(
            this UpdateAppResourcesV2.UpdateAppResourcesV2Builder builder,
            ApimodelUpdateAppResourceRequest body,
            string app,
            string namespace_
        )
        {
            UpdateAppResourcesV2 op = builder.Build(
                body,
                app,
                namespace_
            );

            return await ((Csm.Wrapper.AppV2)builder.WrapperObject!).UpdateAppResourcesV2Async(op);
        }
        public static void Execute(
            this UpdateAppResourcesResourceLimitFormV2.UpdateAppResourcesResourceLimitFormV2Builder builder,
            ApimodelIncreaseLimitFormRequest body,
            string app,
            string namespace_
        )
        {
            UpdateAppResourcesResourceLimitFormV2 op = builder.Build(
                body,
                app,
                namespace_
            );

            ((Csm.Wrapper.AppV2)builder.WrapperObject!).UpdateAppResourcesResourceLimitFormV2(op);
        }
        public static async Task ExecuteAsync(
            this UpdateAppResourcesResourceLimitFormV2.UpdateAppResourcesResourceLimitFormV2Builder builder,
            ApimodelIncreaseLimitFormRequest body,
            string app,
            string namespace_
        )
        {
            UpdateAppResourcesResourceLimitFormV2 op = builder.Build(
                body,
                app,
                namespace_
            );

            await ((Csm.Wrapper.AppV2)builder.WrapperObject!).UpdateAppResourcesResourceLimitFormV2Async(op);
        }
        public static void Execute(
            this StartAppV2.StartAppV2Builder builder,
            string app,
            string namespace_
        )
        {
            StartAppV2 op = builder.Build(
                app,
                namespace_
            );

            ((Csm.Wrapper.AppV2)builder.WrapperObject!).StartAppV2(op);
        }
        public static async Task ExecuteAsync(
            this StartAppV2.StartAppV2Builder builder,
            string app,
            string namespace_
        )
        {
            StartAppV2 op = builder.Build(
                app,
                namespace_
            );

            await ((Csm.Wrapper.AppV2)builder.WrapperObject!).StartAppV2Async(op);
        }
        public static void Execute(
            this StopAppV2.StopAppV2Builder builder,
            string app,
            string namespace_
        )
        {
            StopAppV2 op = builder.Build(
                app,
                namespace_
            );

            ((Csm.Wrapper.AppV2)builder.WrapperObject!).StopAppV2(op);
        }
        public static async Task ExecuteAsync(
            this StopAppV2.StopAppV2Builder builder,
            string app,
            string namespace_
        )
        {
            StopAppV2 op = builder.Build(
                app,
                namespace_
            );

            await ((Csm.Wrapper.AppV2)builder.WrapperObject!).StopAppV2Async(op);
        }
    }
}