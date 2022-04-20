// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class UgcPublicLike_OpExts
    {
        public static Ugc.Model.ModelsPaginatedContentDownloadResponse? Execute(
            this GetLikedContent.GetLikedContentBuilder builder,
            string namespace_
        )
        {
            GetLikedContent op = builder.Build(
                namespace_
            );

            return ((Ugc.Wrapper.PublicLike)builder.WrapperObject!).GetLikedContent(op);
        }

        public static Ugc.Model.ModelsContentLikeResponse? Execute(
            this UpdateContentLikeStatus.UpdateContentLikeStatusBuilder builder,
            ModelsContentLikeRequest body,
            string contentId,
            string namespace_
        )
        {
            UpdateContentLikeStatus op = builder.Build(
                body,
                contentId,
                namespace_
            );

            return ((Ugc.Wrapper.PublicLike)builder.WrapperObject!).UpdateContentLikeStatus(op);
        }

    }
}