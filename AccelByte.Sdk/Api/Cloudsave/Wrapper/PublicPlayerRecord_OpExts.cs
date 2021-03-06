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
    public static class CloudsavePublicPlayerRecord_OpExts
    {
        public static Cloudsave.Model.ModelsBulkGetPlayerRecordResponse? Execute(
            this BulkGetPlayerPublicRecordHandlerV1.BulkGetPlayerPublicRecordHandlerV1Builder builder,
            ModelsBulkUserIDsRequest body,
            string key,
            string namespace_
        )
        {
            BulkGetPlayerPublicRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_
            );

            return ((Cloudsave.Wrapper.PublicPlayerRecord)builder.WrapperObject!).BulkGetPlayerPublicRecordHandlerV1(op);
        }

        public static void Execute(
            this PublicDeletePlayerPublicRecordHandlerV1.PublicDeletePlayerPublicRecordHandlerV1Builder builder,
            string key,
            string namespace_
        )
        {
            PublicDeletePlayerPublicRecordHandlerV1 op = builder.Build(
                key,
                namespace_
            );

            ((Cloudsave.Wrapper.PublicPlayerRecord)builder.WrapperObject!).PublicDeletePlayerPublicRecordHandlerV1(op);
        }

        public static Cloudsave.Model.ModelsPlayerRecordResponse? Execute(
            this GetPlayerRecordHandlerV1.GetPlayerRecordHandlerV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            GetPlayerRecordHandlerV1 op = builder.Build(
                key,
                namespace_,
                userId
            );

            return ((Cloudsave.Wrapper.PublicPlayerRecord)builder.WrapperObject!).GetPlayerRecordHandlerV1(op);
        }

        public static void Execute(
            this PutPlayerRecordHandlerV1.PutPlayerRecordHandlerV1Builder builder,
            ModelsPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            PutPlayerRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            ((Cloudsave.Wrapper.PublicPlayerRecord)builder.WrapperObject!).PutPlayerRecordHandlerV1(op);
        }

        public static void Execute(
            this PostPlayerRecordHandlerV1.PostPlayerRecordHandlerV1Builder builder,
            ModelsPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            PostPlayerRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            ((Cloudsave.Wrapper.PublicPlayerRecord)builder.WrapperObject!).PostPlayerRecordHandlerV1(op);
        }

        public static void Execute(
            this DeletePlayerRecordHandlerV1.DeletePlayerRecordHandlerV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            DeletePlayerRecordHandlerV1 op = builder.Build(
                key,
                namespace_,
                userId
            );

            ((Cloudsave.Wrapper.PublicPlayerRecord)builder.WrapperObject!).DeletePlayerRecordHandlerV1(op);
        }

        public static Cloudsave.Model.ModelsPlayerRecordResponse? Execute(
            this GetPlayerPublicRecordHandlerV1.GetPlayerPublicRecordHandlerV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            GetPlayerPublicRecordHandlerV1 op = builder.Build(
                key,
                namespace_,
                userId
            );

            return ((Cloudsave.Wrapper.PublicPlayerRecord)builder.WrapperObject!).GetPlayerPublicRecordHandlerV1(op);
        }

        public static void Execute(
            this PutPlayerPublicRecordHandlerV1.PutPlayerPublicRecordHandlerV1Builder builder,
            ModelsPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            PutPlayerPublicRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            ((Cloudsave.Wrapper.PublicPlayerRecord)builder.WrapperObject!).PutPlayerPublicRecordHandlerV1(op);
        }

        public static void Execute(
            this PostPlayerPublicRecordHandlerV1.PostPlayerPublicRecordHandlerV1Builder builder,
            ModelsPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            PostPlayerPublicRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            ((Cloudsave.Wrapper.PublicPlayerRecord)builder.WrapperObject!).PostPlayerPublicRecordHandlerV1(op);
        }

    }
}