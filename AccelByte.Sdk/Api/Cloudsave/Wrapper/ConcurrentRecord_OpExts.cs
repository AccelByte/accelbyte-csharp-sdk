// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Api.Cloudsave.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class CloudsaveConcurrentRecord_OpExts
    {
        public static void Execute(
            this PutGameRecordConcurrentHandlerV1.PutGameRecordConcurrentHandlerV1Builder builder,
            ModelsConcurrentRecordRequest body,
            string key,
            string namespace_
        )
        {
            PutGameRecordConcurrentHandlerV1 op = builder.Build(
                body,
                key,
                namespace_
            );

            ((Cloudsave.Wrapper.ConcurrentRecord)builder.WrapperObject!).PutGameRecordConcurrentHandlerV1(op);
        }

        public static void Execute(
            this PutPlayerPublicRecordConcurrentHandlerV1.PutPlayerPublicRecordConcurrentHandlerV1Builder builder,
            ModelsConcurrentRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            PutPlayerPublicRecordConcurrentHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            ((Cloudsave.Wrapper.ConcurrentRecord)builder.WrapperObject!).PutPlayerPublicRecordConcurrentHandlerV1(op);
        }

    }
}