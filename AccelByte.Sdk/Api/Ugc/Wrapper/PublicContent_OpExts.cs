// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class UgcPublicContent_OpExts
    {
        public static Ugc.Model.ModelsPaginatedContentDownloadResponse? Execute(
            this SearchChannelSpecificContent.SearchChannelSpecificContentBuilder builder,
            string channelId,
            string namespace_
        )
        {
            SearchChannelSpecificContent op = builder.Build(
                channelId,
                namespace_
            );

            return ((Ugc.Wrapper.PublicContent)builder.WrapperObject!).SearchChannelSpecificContent(op);
        }

        public static Ugc.Model.ModelsPaginatedContentDownloadResponse? Execute(
            this PublicSearchContent.PublicSearchContentBuilder builder,
            string namespace_
        )
        {
            PublicSearchContent op = builder.Build(
                namespace_
            );

            return ((Ugc.Wrapper.PublicContent)builder.WrapperObject!).PublicSearchContent(op);
        }

        public static List<Ugc.Model.ModelsContentDownloadResponse>? Execute(
            this PublicGetContentBulk.PublicGetContentBulkBuilder builder,
            ModelsPublicGetContentBulkRequest body,
            string namespace_
        )
        {
            PublicGetContentBulk op = builder.Build(
                body,
                namespace_
            );

            return ((Ugc.Wrapper.PublicContent)builder.WrapperObject!).PublicGetContentBulk(op);
        }

        public static Ugc.Model.ModelsContentDownloadResponse? Execute(
            this DownloadContentByShareCode.DownloadContentByShareCodeBuilder builder,
            string namespace_,
            string shareCode
        )
        {
            DownloadContentByShareCode op = builder.Build(
                namespace_,
                shareCode
            );

            return ((Ugc.Wrapper.PublicContent)builder.WrapperObject!).DownloadContentByShareCode(op);
        }

        public static Ugc.Model.ModelsContentDownloadResponse? Execute(
            this PublicDownloadContentByContentID.PublicDownloadContentByContentIDBuilder builder,
            string contentId,
            string namespace_
        )
        {
            PublicDownloadContentByContentID op = builder.Build(
                contentId,
                namespace_
            );

            return ((Ugc.Wrapper.PublicContent)builder.WrapperObject!).PublicDownloadContentByContentID(op);
        }

        public static Ugc.Model.ModelsGetContentPreviewResponse? Execute(
            this PublicDownloadContentPreview.PublicDownloadContentPreviewBuilder builder,
            string contentId,
            string namespace_
        )
        {
            PublicDownloadContentPreview op = builder.Build(
                contentId,
                namespace_
            );

            return ((Ugc.Wrapper.PublicContent)builder.WrapperObject!).PublicDownloadContentPreview(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Ugc.Model.ModelsCreateContentResponse? Execute(
            this CreateContentDirect.CreateContentDirectBuilder builder,
            ModelsCreateContentRequest body,
            string channelId,
            string namespace_,
            string userId
        )
        {
            CreateContentDirect op = builder.Build(
                body,
                channelId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContent)builder.WrapperObject!).CreateContentDirect(op);
        }

        public static Ugc.Model.ModelsCreateContentResponse? Execute(
            this CreateContentS3.CreateContentS3Builder builder,
            ModelsCreateContentRequestS3 body,
            string channelId,
            string namespace_,
            string userId
        )
        {
            CreateContentS3 op = builder.Build(
                body,
                channelId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContent)builder.WrapperObject!).CreateContentS3(op);
        }

        public static Ugc.Model.ModelsCreateContentResponse? Execute(
            this UpdateContentS3.UpdateContentS3Builder builder,
            ModelsCreateContentRequestS3 body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            UpdateContentS3 op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContent)builder.WrapperObject!).UpdateContentS3(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Ugc.Model.ModelsCreateContentResponse? Execute(
            this UpdateContentDirect.UpdateContentDirectBuilder builder,
            ModelsCreateContentRequest body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            UpdateContentDirect op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContent)builder.WrapperObject!).UpdateContentDirect(op);
        }

        public static void Execute(
            this DeleteContent.DeleteContentBuilder builder,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            DeleteContent op = builder.Build(
                channelId,
                contentId,
                namespace_,
                userId
            );

            ((Ugc.Wrapper.PublicContent)builder.WrapperObject!).DeleteContent(op);
        }

        public static Ugc.Model.ModelsPaginatedContentDownloadResponse? Execute(
            this PublicGetUserContent.PublicGetUserContentBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserContent op = builder.Build(
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContent)builder.WrapperObject!).PublicGetUserContent(op);
        }

        public static Ugc.Model.ModelsUpdateScreenshotResponse? Execute(
            this UpdateScreenshots.UpdateScreenshotsBuilder builder,
            ModelsUpdateScreenshotRequest body,
            string contentId,
            string namespace_,
            string userId
        )
        {
            UpdateScreenshots op = builder.Build(
                body,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContent)builder.WrapperObject!).UpdateScreenshots(op);
        }

        public static Ugc.Model.ModelsCreateScreenshotResponse? Execute(
            this UploadContentScreenshot.UploadContentScreenshotBuilder builder,
            ModelsCreateScreenshotRequest body,
            string contentId,
            string namespace_,
            string userId
        )
        {
            UploadContentScreenshot op = builder.Build(
                body,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContent)builder.WrapperObject!).UploadContentScreenshot(op);
        }

        public static void Execute(
            this DeleteContentScreenshot.DeleteContentScreenshotBuilder builder,
            string contentId,
            string namespace_,
            string screenshotId,
            string userId
        )
        {
            DeleteContentScreenshot op = builder.Build(
                contentId,
                namespace_,
                screenshotId,
                userId
            );

            ((Ugc.Wrapper.PublicContent)builder.WrapperObject!).DeleteContentScreenshot(op);
        }

    }
}