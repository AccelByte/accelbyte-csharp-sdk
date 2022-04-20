// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Api.Cloudsave.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class CloudsaveAdminPlayerRecord_OpExts
    {
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Cloudsave.Model.ModelsListPlayerRecordKeysResponse? Execute(
            this ListPlayerRecordHandlerV1.ListPlayerRecordHandlerV1Builder builder,
            string namespace_
        )
        {
            ListPlayerRecordHandlerV1 op = builder.Build(
                namespace_
            );

            return ((Cloudsave.Wrapper.AdminPlayerRecord)builder.WrapperObject!).ListPlayerRecordHandlerV1(op);
        }

        public static Cloudsave.Model.ModelsListPlayerRecordKeysResponse? Execute(
            this AdminRetrievePlayerRecords.AdminRetrievePlayerRecordsBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminRetrievePlayerRecords op = builder.Build(
                namespace_,
                userId
            );

            return ((Cloudsave.Wrapper.AdminPlayerRecord)builder.WrapperObject!).AdminRetrievePlayerRecords(op);
        }

        public static Cloudsave.Model.ModelsPlayerRecordResponse? Execute(
            this AdminGetPlayerRecordHandlerV1.AdminGetPlayerRecordHandlerV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminGetPlayerRecordHandlerV1 op = builder.Build(
                key,
                namespace_,
                userId
            );

            return ((Cloudsave.Wrapper.AdminPlayerRecord)builder.WrapperObject!).AdminGetPlayerRecordHandlerV1(op);
        }

        public static void Execute(
            this AdminPutPlayerRecordHandlerV1.AdminPutPlayerRecordHandlerV1Builder builder,
            ModelsPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminPutPlayerRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            ((Cloudsave.Wrapper.AdminPlayerRecord)builder.WrapperObject!).AdminPutPlayerRecordHandlerV1(op);
        }

        public static void Execute(
            this AdminPostPlayerRecordHandlerV1.AdminPostPlayerRecordHandlerV1Builder builder,
            ModelsPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminPostPlayerRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            ((Cloudsave.Wrapper.AdminPlayerRecord)builder.WrapperObject!).AdminPostPlayerRecordHandlerV1(op);
        }

        public static void Execute(
            this AdminDeletePlayerRecordHandlerV1.AdminDeletePlayerRecordHandlerV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminDeletePlayerRecordHandlerV1 op = builder.Build(
                key,
                namespace_,
                userId
            );

            ((Cloudsave.Wrapper.AdminPlayerRecord)builder.WrapperObject!).AdminDeletePlayerRecordHandlerV1(op);
        }

        public static Cloudsave.Model.ModelsPlayerRecordResponse? Execute(
            this AdminGetPlayerPublicRecordHandlerV1.AdminGetPlayerPublicRecordHandlerV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminGetPlayerPublicRecordHandlerV1 op = builder.Build(
                key,
                namespace_,
                userId
            );

            return ((Cloudsave.Wrapper.AdminPlayerRecord)builder.WrapperObject!).AdminGetPlayerPublicRecordHandlerV1(op);
        }

        public static void Execute(
            this AdminPutPlayerPublicRecordHandlerV1.AdminPutPlayerPublicRecordHandlerV1Builder builder,
            ModelsPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminPutPlayerPublicRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            ((Cloudsave.Wrapper.AdminPlayerRecord)builder.WrapperObject!).AdminPutPlayerPublicRecordHandlerV1(op);
        }

        public static void Execute(
            this AdminPostPlayerPublicRecordHandlerV1.AdminPostPlayerPublicRecordHandlerV1Builder builder,
            ModelsPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminPostPlayerPublicRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            ((Cloudsave.Wrapper.AdminPlayerRecord)builder.WrapperObject!).AdminPostPlayerPublicRecordHandlerV1(op);
        }

        public static void Execute(
            this AdminDeletePlayerPublicRecordHandlerV1.AdminDeletePlayerPublicRecordHandlerV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminDeletePlayerPublicRecordHandlerV1 op = builder.Build(
                key,
                namespace_,
                userId
            );

            ((Cloudsave.Wrapper.AdminPlayerRecord)builder.WrapperObject!).AdminDeletePlayerPublicRecordHandlerV1(op);
        }

    }
}