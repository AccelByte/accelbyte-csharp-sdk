// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Api.Chat.Operation;
using AccelByte.Sdk.Api.Chat.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class ChatProfanity_OpExts
    {
        public static Chat.Model.ModelsDictionaryQueryResult? Execute(
            this AdminProfanityQuery.AdminProfanityQueryBuilder builder,
            string namespace_
        )
        {
            AdminProfanityQuery op = builder.Build(
                namespace_
            );

            return ((Chat.Wrapper.Profanity)builder.WrapperObject!).AdminProfanityQuery(op);
        }
        public static Chat.Model.ModelsDictionary? Execute(
            this AdminProfanityCreate.AdminProfanityCreateBuilder builder,
            ModelsDictionaryInsertRequest body,
            string namespace_
        )
        {
            AdminProfanityCreate op = builder.Build(
                body,
                namespace_
            );

            return ((Chat.Wrapper.Profanity)builder.WrapperObject!).AdminProfanityCreate(op);
        }
        public static Chat.Model.ModelsDictionary? Execute(
            this AdminProfanityCreateBulk.AdminProfanityCreateBulkBuilder builder,
            ModelsDictionaryInsertBulkRequest body,
            string namespace_
        )
        {
            AdminProfanityCreateBulk op = builder.Build(
                body,
                namespace_
            );

            return ((Chat.Wrapper.Profanity)builder.WrapperObject!).AdminProfanityCreateBulk(op);
        }
        public static Chat.Model.ModelsDictionaryExport? Execute(
            this AdminProfanityExport.AdminProfanityExportBuilder builder,
            string namespace_
        )
        {
            AdminProfanityExport op = builder.Build(
                namespace_
            );

            return ((Chat.Wrapper.Profanity)builder.WrapperObject!).AdminProfanityExport(op);
        }
        public static List<Chat.Model.ModelsDictionaryGroup>? Execute(
            this AdminProfanityGroup.AdminProfanityGroupBuilder builder,
            string namespace_
        )
        {
            AdminProfanityGroup op = builder.Build(
                namespace_
            );

            return ((Chat.Wrapper.Profanity)builder.WrapperObject!).AdminProfanityGroup(op);
        }
        public static Chat.Model.ModelsDictionaryImportResult? Execute(
            this AdminProfanityImport.AdminProfanityImportBuilder builder,
            Stream file,
            string namespace_
        )
        {
            AdminProfanityImport op = builder.Build(
                file,
                namespace_
            );

            return ((Chat.Wrapper.Profanity)builder.WrapperObject!).AdminProfanityImport(op);
        }
        public static Chat.Model.ModelsDictionary? Execute(
            this AdminProfanityUpdate.AdminProfanityUpdateBuilder builder,
            ModelsDictionaryUpdateRequest body,
            string id,
            string namespace_
        )
        {
            AdminProfanityUpdate op = builder.Build(
                body,
                id,
                namespace_
            );

            return ((Chat.Wrapper.Profanity)builder.WrapperObject!).AdminProfanityUpdate(op);
        }
        public static void Execute(
            this AdminProfanityDelete.AdminProfanityDeleteBuilder builder,
            string id,
            string namespace_
        )
        {
            AdminProfanityDelete op = builder.Build(
                id,
                namespace_
            );

            ((Chat.Wrapper.Profanity)builder.WrapperObject!).AdminProfanityDelete(op);
        }
    }
}