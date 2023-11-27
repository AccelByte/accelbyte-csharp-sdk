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
    public static class UgcPublicContentLegacy_OpExts
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

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).SearchChannelSpecificContent(op);
        }
        public static Ugc.Model.ModelsPaginatedContentDownloadResponse? Execute(
            this PublicSearchContent.PublicSearchContentBuilder builder,
            string namespace_
        )
        {
            PublicSearchContent op = builder.Build(
                namespace_
            );

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).PublicSearchContent(op);
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

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).PublicGetContentBulk(op);
        }

        public static List<Ugc.Model.ModelsContentDownloadResponse<T1>>? Execute<T1>(
            this PublicGetContentBulk.PublicGetContentBulkBuilder builder,
            ModelsPublicGetContentBulkRequest body,
            string namespace_
        )
        {
            PublicGetContentBulk op = builder.Build(
                body,
                namespace_
            );

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).PublicGetContentBulk<T1>(op);
        }
        public static List<Ugc.Model.ModelsContentDownloadResponse>? Execute(
            this PublicGetContentBulkByShareCodes.PublicGetContentBulkByShareCodesBuilder builder,
            ModelsGetContentBulkByShareCodesRequest body,
            string namespace_
        )
        {
            PublicGetContentBulkByShareCodes op = builder.Build(
                body,
                namespace_
            );

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).PublicGetContentBulkByShareCodes(op);
        }

        public static List<Ugc.Model.ModelsContentDownloadResponse<T1>>? Execute<T1>(
            this PublicGetContentBulkByShareCodes.PublicGetContentBulkByShareCodesBuilder builder,
            ModelsGetContentBulkByShareCodesRequest body,
            string namespace_
        )
        {
            PublicGetContentBulkByShareCodes op = builder.Build(
                body,
                namespace_
            );

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).PublicGetContentBulkByShareCodes<T1>(op);
        }
        public static Ugc.Model.ModelsContentDownloadResponse? Execute(
            this PublicDownloadContentByShareCode.PublicDownloadContentByShareCodeBuilder builder,
            string namespace_,
            string shareCode
        )
        {
            PublicDownloadContentByShareCode op = builder.Build(
                namespace_,
                shareCode
            );

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).PublicDownloadContentByShareCode(op);
        }

        public static Ugc.Model.ModelsContentDownloadResponse<T1>? Execute<T1>(
            this PublicDownloadContentByShareCode.PublicDownloadContentByShareCodeBuilder builder,
            string namespace_,
            string shareCode
        )
        {
            PublicDownloadContentByShareCode op = builder.Build(
                namespace_,
                shareCode
            );

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).PublicDownloadContentByShareCode<T1>(op);
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

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).PublicDownloadContentByContentID(op);
        }

        public static Ugc.Model.ModelsContentDownloadResponse<T1>? Execute<T1>(
            this PublicDownloadContentByContentID.PublicDownloadContentByContentIDBuilder builder,
            string contentId,
            string namespace_
        )
        {
            PublicDownloadContentByContentID op = builder.Build(
                contentId,
                namespace_
            );

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).PublicDownloadContentByContentID<T1>(op);
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

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).PublicDownloadContentPreview(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
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

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).CreateContentDirect(op);
        }

        public static Ugc.Model.ModelsCreateContentResponse<T1>? Execute<T1>(
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

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).CreateContentDirect<T1>(op);
        }
        public static Ugc.Model.ModelsCreateContentResponse? Execute(
            this CreateContentS3.CreateContentS3Builder builder,
            ModelsPublicCreateContentRequestS3 body,
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

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).CreateContentS3(op);
        }

        public static Ugc.Model.ModelsCreateContentResponse<T1>? Execute<T1>(
            this CreateContentS3.CreateContentS3Builder builder,
            ModelsPublicCreateContentRequestS3 body,
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

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).CreateContentS3<T1>(op);
        }
        public static Ugc.Model.ModelsCreateContentResponse? Execute(
            this PublicUpdateContentByShareCode.PublicUpdateContentByShareCodeBuilder builder,
            ModelsUpdateContentRequest body,
            string channelId,
            string namespace_,
            string shareCode,
            string userId
        )
        {
            PublicUpdateContentByShareCode op = builder.Build(
                body,
                channelId,
                namespace_,
                shareCode,
                userId
            );

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).PublicUpdateContentByShareCode(op);
        }

        public static Ugc.Model.ModelsCreateContentResponse<T1>? Execute<T1>(
            this PublicUpdateContentByShareCode.PublicUpdateContentByShareCodeBuilder builder,
            ModelsUpdateContentRequest body,
            string channelId,
            string namespace_,
            string shareCode,
            string userId
        )
        {
            PublicUpdateContentByShareCode op = builder.Build(
                body,
                channelId,
                namespace_,
                shareCode,
                userId
            );

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).PublicUpdateContentByShareCode<T1>(op);
        }
        public static Ugc.Model.ModelsCreateContentResponse? Execute(
            this UpdateContentS3.UpdateContentS3Builder builder,
            ModelsUpdateContentRequest body,
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

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).UpdateContentS3(op);
        }

        public static Ugc.Model.ModelsCreateContentResponse<T1>? Execute<T1>(
            this UpdateContentS3.UpdateContentS3Builder builder,
            ModelsUpdateContentRequest body,
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

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).UpdateContentS3<T1>(op);
        }
        public static void Execute(
            this PublicDeleteContentByShareCode.PublicDeleteContentByShareCodeBuilder builder,
            string channelId,
            string namespace_,
            string shareCode,
            string userId
        )
        {
            PublicDeleteContentByShareCode op = builder.Build(
                channelId,
                namespace_,
                shareCode,
                userId
            );

            ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).PublicDeleteContentByShareCode(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
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

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).UpdateContentDirect(op);
        }

        public static Ugc.Model.ModelsCreateContentResponse<T1>? Execute<T1>(
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

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).UpdateContentDirect<T1>(op);
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

            ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).DeleteContent(op);
        }
        public static Ugc.Model.ModelsCreateContentResponse? Execute(
            this UpdateContentShareCode.UpdateContentShareCodeBuilder builder,
            ModelsUpdateContentShareCodeRequest body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            UpdateContentShareCode op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).UpdateContentShareCode(op);
        }

        public static Ugc.Model.ModelsCreateContentResponse<T1>? Execute<T1>(
            this UpdateContentShareCode.UpdateContentShareCodeBuilder builder,
            ModelsUpdateContentShareCodeRequest body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            UpdateContentShareCode op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).UpdateContentShareCode<T1>(op);
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

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).PublicGetUserContent(op);
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

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).UpdateScreenshots(op);
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

            return ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).UploadContentScreenshot(op);
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

            ((Ugc.Wrapper.PublicContentLegacy)builder.WrapperObject!).DeleteContentScreenshot(op);
        }
    }
}