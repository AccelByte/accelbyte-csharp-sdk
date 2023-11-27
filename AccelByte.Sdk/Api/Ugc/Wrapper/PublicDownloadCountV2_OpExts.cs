// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class UgcPublicDownloadCountV2_OpExts
    {
        public static Ugc.Model.ModelsAddDownloadCountResponse? Execute(
            this PublicAddDownloadCountV2.PublicAddDownloadCountV2Builder builder,
            string contentId,
            string namespace_
        )
        {
            PublicAddDownloadCountV2 op = builder.Build(
                contentId,
                namespace_
            );

            return ((Ugc.Wrapper.PublicDownloadCountV2)builder.WrapperObject!).PublicAddDownloadCountV2(op);
        }
        public static Ugc.Model.ModelsPaginatedContentDownloaderResponse? Execute(
            this PublicListContentDownloaderV2.PublicListContentDownloaderV2Builder builder,
            string contentId,
            string namespace_
        )
        {
            PublicListContentDownloaderV2 op = builder.Build(
                contentId,
                namespace_
            );

            return ((Ugc.Wrapper.PublicDownloadCountV2)builder.WrapperObject!).PublicListContentDownloaderV2(op);
        }
    }
}