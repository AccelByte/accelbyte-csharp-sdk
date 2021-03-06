// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
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

        public static void Execute(
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

            ((Cloudsave.Wrapper.AdminConcurrentRecord)builder.WrapperObject!).AdminPutPlayerRecordConcurrentHandlerV1(op);
        }

        public static void Execute(
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

            ((Cloudsave.Wrapper.AdminConcurrentRecord)builder.WrapperObject!).AdminPutPlayerPublicRecordConcurrentHandlerV1(op);
        }

    }
}