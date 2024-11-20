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
    public static class CsmImage_OpExts
    {
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static Csm.Model.GeneratedGetAppImageListV1Response? Execute(
            this GetAppImageListV1.GetAppImageListV1Builder builder,
            string app,
            string namespace_
        )
        {
            GetAppImageListV1 op = builder.Build(
                app,
                namespace_
            );

            return ((Csm.Wrapper.Image)builder.WrapperObject!).GetAppImageListV1(op);
        }
        public static async Task<Csm.Model.GeneratedGetAppImageListV1Response?> ExecuteAsync(
            this GetAppImageListV1.GetAppImageListV1Builder builder,
            string app,
            string namespace_
        )
        {
            GetAppImageListV1 op = builder.Build(
                app,
                namespace_
            );

            return await ((Csm.Wrapper.Image)builder.WrapperObject!).GetAppImageListV1Async(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static void Execute(
            this DeleteAppImagesV1.DeleteAppImagesV1Builder builder,
            GeneratedDeleteAppImagesV1Request body,
            string app,
            string namespace_
        )
        {
            DeleteAppImagesV1 op = builder.Build(
                body,
                app,
                namespace_
            );

            ((Csm.Wrapper.Image)builder.WrapperObject!).DeleteAppImagesV1(op);
        }
        public static async Task ExecuteAsync(
            this DeleteAppImagesV1.DeleteAppImagesV1Builder builder,
            GeneratedDeleteAppImagesV1Request body,
            string app,
            string namespace_
        )
        {
            DeleteAppImagesV1 op = builder.Build(
                body,
                app,
                namespace_
            );

            await ((Csm.Wrapper.Image)builder.WrapperObject!).DeleteAppImagesV1Async(op);
        }
    }
}