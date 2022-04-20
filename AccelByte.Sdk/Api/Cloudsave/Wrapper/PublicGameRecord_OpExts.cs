// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Api.Cloudsave.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class CloudsavePublicGameRecord_OpExts
    {
        public static Cloudsave.Model.ModelsGameRecordResponse? Execute(
            this GetGameRecordHandlerV1.GetGameRecordHandlerV1Builder builder,
            string key,
            string namespace_
        )
        {
            GetGameRecordHandlerV1 op = builder.Build(
                key,
                namespace_
            );

            return ((Cloudsave.Wrapper.PublicGameRecord)builder.WrapperObject!).GetGameRecordHandlerV1(op);
        }

        public static void Execute(
            this PutGameRecordHandlerV1.PutGameRecordHandlerV1Builder builder,
            ModelsGameRecordRequest body,
            string key,
            string namespace_
        )
        {
            PutGameRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_
            );

            ((Cloudsave.Wrapper.PublicGameRecord)builder.WrapperObject!).PutGameRecordHandlerV1(op);
        }

        public static void Execute(
            this PostGameRecordHandlerV1.PostGameRecordHandlerV1Builder builder,
            ModelsGameRecordRequest body,
            string key,
            string namespace_
        )
        {
            PostGameRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_
            );

            ((Cloudsave.Wrapper.PublicGameRecord)builder.WrapperObject!).PostGameRecordHandlerV1(op);
        }

        public static void Execute(
            this DeleteGameRecordHandlerV1.DeleteGameRecordHandlerV1Builder builder,
            string key,
            string namespace_
        )
        {
            DeleteGameRecordHandlerV1 op = builder.Build(
                key,
                namespace_
            );

            ((Cloudsave.Wrapper.PublicGameRecord)builder.WrapperObject!).DeleteGameRecordHandlerV1(op);
        }

    }
}