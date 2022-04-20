// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class UgcAdminTag_OpExts
    {
        public static Ugc.Model.ModelsPaginatedGetTagResponse? Execute(
            this AdminGetTag.AdminGetTagBuilder builder,
            string namespace_
        )
        {
            AdminGetTag op = builder.Build(
                namespace_
            );

            return ((Ugc.Wrapper.AdminTag)builder.WrapperObject!).AdminGetTag(op);
        }

        public static Ugc.Model.ModelsCreateTagResponse? Execute(
            this AdminCreateTag.AdminCreateTagBuilder builder,
            ModelsCreateTagRequest body,
            string namespace_
        )
        {
            AdminCreateTag op = builder.Build(
                body,
                namespace_
            );

            return ((Ugc.Wrapper.AdminTag)builder.WrapperObject!).AdminCreateTag(op);
        }

        public static Ugc.Model.ModelsCreateTagResponse? Execute(
            this AdminUpdateTag.AdminUpdateTagBuilder builder,
            ModelsCreateTagRequest body,
            string namespace_,
            string tagId
        )
        {
            AdminUpdateTag op = builder.Build(
                body,
                namespace_,
                tagId
            );

            return ((Ugc.Wrapper.AdminTag)builder.WrapperObject!).AdminUpdateTag(op);
        }

        public static void Execute(
            this AdminDeleteTag.AdminDeleteTagBuilder builder,
            string namespace_,
            string tagId
        )
        {
            AdminDeleteTag op = builder.Build(
                namespace_,
                tagId
            );

            ((Ugc.Wrapper.AdminTag)builder.WrapperObject!).AdminDeleteTag(op);
        }

    }
}