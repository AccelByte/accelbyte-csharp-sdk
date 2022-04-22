// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Api.Cloudsave.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class CloudsaveAdminGameRecord_OpExts
    {
        public static Cloudsave.Model.ModelsListGameRecordKeysResponse? Execute(
            this ListGameRecordsHandlerV1.ListGameRecordsHandlerV1Builder builder,
            string namespace_,
            long limit,
            long offset
        )
        {
            ListGameRecordsHandlerV1 op = builder.Build(
                namespace_,
                limit,
                offset
            );

            return ((Cloudsave.Wrapper.AdminGameRecord)builder.WrapperObject!).ListGameRecordsHandlerV1(op);
        }

        public static Cloudsave.Model.ModelsGameRecordResponse? Execute(
            this AdminGetGameRecordHandlerV1.AdminGetGameRecordHandlerV1Builder builder,
            string key,
            string namespace_
        )
        {
            AdminGetGameRecordHandlerV1 op = builder.Build(
                key,
                namespace_
            );

            return ((Cloudsave.Wrapper.AdminGameRecord)builder.WrapperObject!).AdminGetGameRecordHandlerV1(op);
        }

        public static void Execute(
            this AdminPutGameRecordHandlerV1.AdminPutGameRecordHandlerV1Builder builder,
            ModelsGameRecordRequest body,
            string key,
            string namespace_
        )
        {
            AdminPutGameRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_
            );

            ((Cloudsave.Wrapper.AdminGameRecord)builder.WrapperObject!).AdminPutGameRecordHandlerV1(op);
        }

        public static void Execute(
            this AdminPostGameRecordHandlerV1.AdminPostGameRecordHandlerV1Builder builder,
            ModelsGameRecordRequest body,
            string key,
            string namespace_
        )
        {
            AdminPostGameRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_
            );

            ((Cloudsave.Wrapper.AdminGameRecord)builder.WrapperObject!).AdminPostGameRecordHandlerV1(op);
        }

        public static void Execute(
            this AdminDeleteGameRecordHandlerV1.AdminDeleteGameRecordHandlerV1Builder builder,
            string key,
            string namespace_
        )
        {
            AdminDeleteGameRecordHandlerV1 op = builder.Build(
                key,
                namespace_
            );

            ((Cloudsave.Wrapper.AdminGameRecord)builder.WrapperObject!).AdminDeleteGameRecordHandlerV1(op);
        }

    }
}