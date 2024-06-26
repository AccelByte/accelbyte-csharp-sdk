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
    public static class CloudsaveAdminConcurrentRecord_OpExts
    {
        public static void Execute(
            this AdminPutAdminGameRecordConcurrentHandlerV1.AdminPutAdminGameRecordConcurrentHandlerV1Builder builder,
            ModelsAdminGameConcurrentRecordRequest body,
            string key,
            string namespace_
        )
        {
            AdminPutAdminGameRecordConcurrentHandlerV1 op = builder.Build(
                body,
                key,
                namespace_
            );

            ((Cloudsave.Wrapper.AdminConcurrentRecord)builder.WrapperObject!).AdminPutAdminGameRecordConcurrentHandlerV1(op);
        }
        public static async Task ExecuteAsync(
            this AdminPutAdminGameRecordConcurrentHandlerV1.AdminPutAdminGameRecordConcurrentHandlerV1Builder builder,
            ModelsAdminGameConcurrentRecordRequest body,
            string key,
            string namespace_
        )
        {
            AdminPutAdminGameRecordConcurrentHandlerV1 op = builder.Build(
                body,
                key,
                namespace_
            );

            await ((Cloudsave.Wrapper.AdminConcurrentRecord)builder.WrapperObject!).AdminPutAdminGameRecordConcurrentHandlerV1Async(op);
        }
        public static void Execute(
            this AdminPutGameRecordConcurrentHandlerV1.AdminPutGameRecordConcurrentHandlerV1Builder builder,
            ModelsAdminConcurrentRecordRequest body,
            string key,
            string namespace_
        )
        {
            AdminPutGameRecordConcurrentHandlerV1 op = builder.Build(
                body,
                key,
                namespace_
            );

            ((Cloudsave.Wrapper.AdminConcurrentRecord)builder.WrapperObject!).AdminPutGameRecordConcurrentHandlerV1(op);
        }
        public static async Task ExecuteAsync(
            this AdminPutGameRecordConcurrentHandlerV1.AdminPutGameRecordConcurrentHandlerV1Builder builder,
            ModelsAdminConcurrentRecordRequest body,
            string key,
            string namespace_
        )
        {
            AdminPutGameRecordConcurrentHandlerV1 op = builder.Build(
                body,
                key,
                namespace_
            );

            await ((Cloudsave.Wrapper.AdminConcurrentRecord)builder.WrapperObject!).AdminPutGameRecordConcurrentHandlerV1Async(op);
        }
        public static Cloudsave.Model.ModelsPlayerRecordConcurrentUpdateResponse? Execute(
            this AdminPutAdminPlayerRecordConcurrentHandlerV1.AdminPutAdminPlayerRecordConcurrentHandlerV1Builder builder,
            ModelsAdminPlayerConcurrentRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminPutAdminPlayerRecordConcurrentHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            return ((Cloudsave.Wrapper.AdminConcurrentRecord)builder.WrapperObject!).AdminPutAdminPlayerRecordConcurrentHandlerV1(op);
        }
        public static async Task<Cloudsave.Model.ModelsPlayerRecordConcurrentUpdateResponse?> ExecuteAsync(
            this AdminPutAdminPlayerRecordConcurrentHandlerV1.AdminPutAdminPlayerRecordConcurrentHandlerV1Builder builder,
            ModelsAdminPlayerConcurrentRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminPutAdminPlayerRecordConcurrentHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            return await ((Cloudsave.Wrapper.AdminConcurrentRecord)builder.WrapperObject!).AdminPutAdminPlayerRecordConcurrentHandlerV1Async(op);
        }
        public static Cloudsave.Model.ModelsPlayerRecordConcurrentUpdateResponse? Execute(
            this AdminPutPlayerRecordConcurrentHandlerV1.AdminPutPlayerRecordConcurrentHandlerV1Builder builder,
            ModelsAdminConcurrentRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminPutPlayerRecordConcurrentHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            return ((Cloudsave.Wrapper.AdminConcurrentRecord)builder.WrapperObject!).AdminPutPlayerRecordConcurrentHandlerV1(op);
        }
        public static async Task<Cloudsave.Model.ModelsPlayerRecordConcurrentUpdateResponse?> ExecuteAsync(
            this AdminPutPlayerRecordConcurrentHandlerV1.AdminPutPlayerRecordConcurrentHandlerV1Builder builder,
            ModelsAdminConcurrentRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminPutPlayerRecordConcurrentHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            return await ((Cloudsave.Wrapper.AdminConcurrentRecord)builder.WrapperObject!).AdminPutPlayerRecordConcurrentHandlerV1Async(op);
        }
        public static Cloudsave.Model.ModelsPlayerRecordConcurrentUpdateResponse? Execute(
            this AdminPutPlayerPublicRecordConcurrentHandlerV1.AdminPutPlayerPublicRecordConcurrentHandlerV1Builder builder,
            ModelsAdminConcurrentRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminPutPlayerPublicRecordConcurrentHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            return ((Cloudsave.Wrapper.AdminConcurrentRecord)builder.WrapperObject!).AdminPutPlayerPublicRecordConcurrentHandlerV1(op);
        }
        public static async Task<Cloudsave.Model.ModelsPlayerRecordConcurrentUpdateResponse?> ExecuteAsync(
            this AdminPutPlayerPublicRecordConcurrentHandlerV1.AdminPutPlayerPublicRecordConcurrentHandlerV1Builder builder,
            ModelsAdminConcurrentRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminPutPlayerPublicRecordConcurrentHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            return await ((Cloudsave.Wrapper.AdminConcurrentRecord)builder.WrapperObject!).AdminPutPlayerPublicRecordConcurrentHandlerV1Async(op);
        }
    }
}