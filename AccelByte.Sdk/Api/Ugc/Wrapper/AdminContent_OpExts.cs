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
    public static class UgcAdminContent_OpExts
    {
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static Ugc.Model.ModelsCreateContentResponse? Execute(
            this AdminUploadContentDirect.AdminUploadContentDirectBuilder builder,
            ModelsCreateContentRequest body,
            string channelId,
            string namespace_
        )
        {
            AdminUploadContentDirect op = builder.Build(
                body,
                channelId,
                namespace_
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminUploadContentDirect(op);
        }

        public static Ugc.Model.ModelsCreateContentResponse<T1>? Execute<T1>(
            this AdminUploadContentDirect.AdminUploadContentDirectBuilder builder,
            ModelsCreateContentRequest body,
            string channelId,
            string namespace_
        )
        {
            AdminUploadContentDirect op = builder.Build(
                body,
                channelId,
                namespace_
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminUploadContentDirect<T1>(op);
        }
        public static Ugc.Model.ModelsCreateContentResponse? Execute(
            this AdminUploadContentS3.AdminUploadContentS3Builder builder,
            ModelsCreateContentRequestS3 body,
            string channelId,
            string namespace_
        )
        {
            AdminUploadContentS3 op = builder.Build(
                body,
                channelId,
                namespace_
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminUploadContentS3(op);
        }

        public static Ugc.Model.ModelsCreateContentResponse<T1>? Execute<T1>(
            this AdminUploadContentS3.AdminUploadContentS3Builder builder,
            ModelsCreateContentRequestS3 body,
            string channelId,
            string namespace_
        )
        {
            AdminUploadContentS3 op = builder.Build(
                body,
                channelId,
                namespace_
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminUploadContentS3<T1>(op);
        }
        public static Ugc.Model.ModelsCreateContentResponse? Execute(
            this SingleAdminUpdateContentS3.SingleAdminUpdateContentS3Builder builder,
            ModelsContentRequest body,
            string channelId,
            string contentId,
            string namespace_
        )
        {
            SingleAdminUpdateContentS3 op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).SingleAdminUpdateContentS3(op);
        }

        public static Ugc.Model.ModelsCreateContentResponse<T1>? Execute<T1>(
            this SingleAdminUpdateContentS3.SingleAdminUpdateContentS3Builder builder,
            ModelsContentRequest body,
            string channelId,
            string contentId,
            string namespace_
        )
        {
            SingleAdminUpdateContentS3 op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).SingleAdminUpdateContentS3<T1>(op);
        }
        public static Ugc.Model.ModelsPaginatedContentDownloadResponse? Execute(
            this AdminSearchChannelSpecificContent.AdminSearchChannelSpecificContentBuilder builder,
            string channelId,
            string namespace_
        )
        {
            AdminSearchChannelSpecificContent op = builder.Build(
                channelId,
                namespace_
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminSearchChannelSpecificContent(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static Ugc.Model.ModelsCreateContentResponse? Execute(
            this SingleAdminUpdateContentDirect.SingleAdminUpdateContentDirectBuilder builder,
            ModelsCreateContentRequest body,
            string channelId,
            string contentId,
            string namespace_
        )
        {
            SingleAdminUpdateContentDirect op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).SingleAdminUpdateContentDirect(op);
        }

        public static Ugc.Model.ModelsCreateContentResponse<T1>? Execute<T1>(
            this SingleAdminUpdateContentDirect.SingleAdminUpdateContentDirectBuilder builder,
            ModelsCreateContentRequest body,
            string channelId,
            string contentId,
            string namespace_
        )
        {
            SingleAdminUpdateContentDirect op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).SingleAdminUpdateContentDirect<T1>(op);
        }
        public static void Execute(
            this SingleAdminDeleteContent.SingleAdminDeleteContentBuilder builder,
            string channelId,
            string contentId,
            string namespace_
        )
        {
            SingleAdminDeleteContent op = builder.Build(
                channelId,
                contentId,
                namespace_
            );

            ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).SingleAdminDeleteContent(op);
        }
        public static Ugc.Model.ModelsPaginatedContentDownloadResponse? Execute(
            this SingleAdminGetContent.SingleAdminGetContentBuilder builder,
            string namespace_
        )
        {
            SingleAdminGetContent op = builder.Build(
                namespace_
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).SingleAdminGetContent(op);
        }
        public static List<Ugc.Model.ModelsContentDownloadResponse>? Execute(
            this AdminGetContentBulk.AdminGetContentBulkBuilder builder,
            ModelsAdminGetContentBulkRequest body,
            string namespace_
        )
        {
            AdminGetContentBulk op = builder.Build(
                body,
                namespace_
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminGetContentBulk(op);
        }

        public static List<Ugc.Model.ModelsContentDownloadResponse<T1>>? Execute<T1>(
            this AdminGetContentBulk.AdminGetContentBulkBuilder builder,
            ModelsAdminGetContentBulkRequest body,
            string namespace_
        )
        {
            AdminGetContentBulk op = builder.Build(
                body,
                namespace_
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminGetContentBulk<T1>(op);
        }
        public static Ugc.Model.ModelsPaginatedContentDownloadResponse? Execute(
            this AdminSearchContent.AdminSearchContentBuilder builder,
            string namespace_
        )
        {
            AdminSearchContent op = builder.Build(
                namespace_
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminSearchContent(op);
        }
        public static Ugc.Model.ModelsContentDownloadResponse? Execute(
            this AdminGetUserContentByShareCode.AdminGetUserContentByShareCodeBuilder builder,
            string namespace_,
            string shareCode
        )
        {
            AdminGetUserContentByShareCode op = builder.Build(
                namespace_,
                shareCode
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminGetUserContentByShareCode(op);
        }

        public static Ugc.Model.ModelsContentDownloadResponse<T1>? Execute<T1>(
            this AdminGetUserContentByShareCode.AdminGetUserContentByShareCodeBuilder builder,
            string namespace_,
            string shareCode
        )
        {
            AdminGetUserContentByShareCode op = builder.Build(
                namespace_,
                shareCode
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminGetUserContentByShareCode<T1>(op);
        }
        public static Ugc.Model.ModelsContentDownloadResponse? Execute(
            this AdminGetSpecificContent.AdminGetSpecificContentBuilder builder,
            string contentId,
            string namespace_
        )
        {
            AdminGetSpecificContent op = builder.Build(
                contentId,
                namespace_
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminGetSpecificContent(op);
        }

        public static Ugc.Model.ModelsContentDownloadResponse<T1>? Execute<T1>(
            this AdminGetSpecificContent.AdminGetSpecificContentBuilder builder,
            string contentId,
            string namespace_
        )
        {
            AdminGetSpecificContent op = builder.Build(
                contentId,
                namespace_
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminGetSpecificContent<T1>(op);
        }
        public static Ugc.Model.ModelsGetContentPreviewResponse? Execute(
            this AdminDownloadContentPreview.AdminDownloadContentPreviewBuilder builder,
            string contentId,
            string namespace_
        )
        {
            AdminDownloadContentPreview op = builder.Build(
                contentId,
                namespace_
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminDownloadContentPreview(op);
        }
        public static Ugc.Model.ModelsUpdateScreenshotResponse? Execute(
            this AdminUpdateScreenshots.AdminUpdateScreenshotsBuilder builder,
            ModelsUpdateScreenshotRequest body,
            string contentId,
            string namespace_
        )
        {
            AdminUpdateScreenshots op = builder.Build(
                body,
                contentId,
                namespace_
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminUpdateScreenshots(op);
        }
        public static Ugc.Model.ModelsCreateScreenshotResponse? Execute(
            this AdminUploadContentScreenshot.AdminUploadContentScreenshotBuilder builder,
            ModelsCreateScreenshotRequest body,
            string contentId,
            string namespace_
        )
        {
            AdminUploadContentScreenshot op = builder.Build(
                body,
                contentId,
                namespace_
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminUploadContentScreenshot(op);
        }
        public static void Execute(
            this AdminDeleteContentScreenshot.AdminDeleteContentScreenshotBuilder builder,
            string contentId,
            string namespace_,
            string screenshotId
        )
        {
            AdminDeleteContentScreenshot op = builder.Build(
                contentId,
                namespace_,
                screenshotId
            );

            ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminDeleteContentScreenshot(op);
        }
        public static Ugc.Model.ModelsCreateContentResponse? Execute(
            this AdminUpdateContentS3.AdminUpdateContentS3Builder builder,
            ModelsContentRequest body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            AdminUpdateContentS3 op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminUpdateContentS3(op);
        }

        public static Ugc.Model.ModelsCreateContentResponse<T1>? Execute<T1>(
            this AdminUpdateContentS3.AdminUpdateContentS3Builder builder,
            ModelsContentRequest body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            AdminUpdateContentS3 op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminUpdateContentS3<T1>(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static Ugc.Model.ModelsCreateContentResponse? Execute(
            this AdminUpdateContentDirect.AdminUpdateContentDirectBuilder builder,
            ModelsCreateContentRequest body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            AdminUpdateContentDirect op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminUpdateContentDirect(op);
        }

        public static Ugc.Model.ModelsCreateContentResponse<T1>? Execute<T1>(
            this AdminUpdateContentDirect.AdminUpdateContentDirectBuilder builder,
            ModelsCreateContentRequest body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            AdminUpdateContentDirect op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminUpdateContentDirect<T1>(op);
        }
        public static void Execute(
            this AdminDeleteContent.AdminDeleteContentBuilder builder,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            AdminDeleteContent op = builder.Build(
                channelId,
                contentId,
                namespace_,
                userId
            );

            ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminDeleteContent(op);
        }
        public static Ugc.Model.ModelsPaginatedContentDownloadResponse? Execute(
            this AdminGetContent.AdminGetContentBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetContent op = builder.Build(
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminGetContent(op);
        }
        public static Ugc.Model.ModelsCreateContentResponse? Execute(
            this AdminHideUserContent.AdminHideUserContentBuilder builder,
            ModelsHideContentRequest body,
            string contentId,
            string namespace_,
            string userId
        )
        {
            AdminHideUserContent op = builder.Build(
                body,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminHideUserContent(op);
        }

        public static Ugc.Model.ModelsCreateContentResponse<T1>? Execute<T1>(
            this AdminHideUserContent.AdminHideUserContentBuilder builder,
            ModelsHideContentRequest body,
            string contentId,
            string namespace_,
            string userId
        )
        {
            AdminHideUserContent op = builder.Build(
                body,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.AdminContent)builder.WrapperObject!).AdminHideUserContent<T1>(op);
        }
    }
}