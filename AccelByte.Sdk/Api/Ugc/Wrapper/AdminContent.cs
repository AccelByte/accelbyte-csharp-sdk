// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class AdminContent
    {
        private readonly AccelByteSDK _sdk;

        public AdminContent(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public AdminUploadContentDirect.AdminUploadContentDirectBuilder AdminUploadContentDirectOp
        {
            get { return Operation.AdminUploadContentDirect.Builder.SetWrapperObject(this); }
        }
        public AdminUploadContentS3.AdminUploadContentS3Builder AdminUploadContentS3Op
        {
            get { return Operation.AdminUploadContentS3.Builder.SetWrapperObject(this); }
        }
        public SingleAdminUpdateContentS3.SingleAdminUpdateContentS3Builder SingleAdminUpdateContentS3Op
        {
            get { return Operation.SingleAdminUpdateContentS3.Builder.SetWrapperObject(this); }
        }
        public AdminSearchChannelSpecificContent.AdminSearchChannelSpecificContentBuilder AdminSearchChannelSpecificContentOp
        {
            get { return Operation.AdminSearchChannelSpecificContent.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public SingleAdminUpdateContentDirect.SingleAdminUpdateContentDirectBuilder SingleAdminUpdateContentDirectOp
        {
            get { return Operation.SingleAdminUpdateContentDirect.Builder.SetWrapperObject(this); }
        }
        public SingleAdminDeleteContent.SingleAdminDeleteContentBuilder SingleAdminDeleteContentOp
        {
            get { return Operation.SingleAdminDeleteContent.Builder.SetWrapperObject(this); }
        }
        public SingleAdminGetContent.SingleAdminGetContentBuilder SingleAdminGetContentOp
        {
            get { return Operation.SingleAdminGetContent.Builder.SetWrapperObject(this); }
        }
        public AdminSearchContent.AdminSearchContentBuilder AdminSearchContentOp
        {
            get { return Operation.AdminSearchContent.Builder.SetWrapperObject(this); }
        }
        public AdminGetSpecificContent.AdminGetSpecificContentBuilder AdminGetSpecificContentOp
        {
            get { return Operation.AdminGetSpecificContent.Builder.SetWrapperObject(this); }
        }
        public AdminDownloadContentPreview.AdminDownloadContentPreviewBuilder AdminDownloadContentPreviewOp
        {
            get { return Operation.AdminDownloadContentPreview.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateScreenshots.AdminUpdateScreenshotsBuilder AdminUpdateScreenshotsOp
        {
            get { return Operation.AdminUpdateScreenshots.Builder.SetWrapperObject(this); }
        }
        public AdminUploadContentScreenshot.AdminUploadContentScreenshotBuilder AdminUploadContentScreenshotOp
        {
            get { return Operation.AdminUploadContentScreenshot.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteContentScreenshot.AdminDeleteContentScreenshotBuilder AdminDeleteContentScreenshotOp
        {
            get { return Operation.AdminDeleteContentScreenshot.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateContentS3.AdminUpdateContentS3Builder AdminUpdateContentS3Op
        {
            get { return Operation.AdminUpdateContentS3.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public AdminUpdateContentDirect.AdminUpdateContentDirectBuilder AdminUpdateContentDirectOp
        {
            get { return Operation.AdminUpdateContentDirect.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteContent.AdminDeleteContentBuilder AdminDeleteContentOp
        {
            get { return Operation.AdminDeleteContent.Builder.SetWrapperObject(this); }
        }
        public AdminGetContent.AdminGetContentBuilder AdminGetContentOp
        {
            get { return Operation.AdminGetContent.Builder.SetWrapperObject(this); }
        }
        public AdminHideUserContent.AdminHideUserContentBuilder AdminHideUserContentOp
        {
            get { return Operation.AdminHideUserContent.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsCreateContentResponse? AdminUploadContentDirect(AdminUploadContentDirect input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public Model.ModelsCreateContentResponse? AdminUploadContentS3(AdminUploadContentS3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateContentResponse? SingleAdminUpdateContentS3(SingleAdminUpdateContentS3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponse? AdminSearchChannelSpecificContent(AdminSearchChannelSpecificContent input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsCreateContentResponse? SingleAdminUpdateContentDirect(SingleAdminUpdateContentDirect input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public void SingleAdminDeleteContent(SingleAdminDeleteContent input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponse? SingleAdminGetContent(SingleAdminGetContent input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponse? AdminSearchContent(AdminSearchContent input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsContentDownloadResponse? AdminGetSpecificContent(AdminGetSpecificContent input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetContentPreviewResponse? AdminDownloadContentPreview(AdminDownloadContentPreview input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateScreenshotResponse? AdminUpdateScreenshots(AdminUpdateScreenshots input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateScreenshotResponse? AdminUploadContentScreenshot(AdminUploadContentScreenshot input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteContentScreenshot(AdminDeleteContentScreenshot input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateContentResponse? AdminUpdateContentS3(AdminUpdateContentS3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsCreateContentResponse? AdminUpdateContentDirect(AdminUpdateContentDirect input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public void AdminDeleteContent(AdminDeleteContent input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponse? AdminGetContent(AdminGetContent input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateContentResponse? AdminHideUserContent(AdminHideUserContent input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class AdminContent_OperationExtensions
    {
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsCreateContentResponse? Execute(
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

            return ((AdminContent)builder.WrapperObject!).AdminUploadContentDirect(op);
        }

        public static Model.ModelsCreateContentResponse? Execute(
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

            return ((AdminContent)builder.WrapperObject!).AdminUploadContentS3(op);
        }

        public static Model.ModelsCreateContentResponse? Execute(
            this SingleAdminUpdateContentS3.SingleAdminUpdateContentS3Builder builder,
            ModelsCreateContentRequestS3 body,
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

            return ((AdminContent)builder.WrapperObject!).SingleAdminUpdateContentS3(op);
        }

        public static Model.ModelsPaginatedContentDownloadResponse? Execute(
            this AdminSearchChannelSpecificContent.AdminSearchChannelSpecificContentBuilder builder,
            string channelId,
            string namespace_
        )
        {
            AdminSearchChannelSpecificContent op = builder.Build(
                channelId,
                namespace_
            );

            return ((AdminContent)builder.WrapperObject!).AdminSearchChannelSpecificContent(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsCreateContentResponse? Execute(
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

            return ((AdminContent)builder.WrapperObject!).SingleAdminUpdateContentDirect(op);
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

            ((AdminContent)builder.WrapperObject!).SingleAdminDeleteContent(op);
        }

        public static Model.ModelsPaginatedContentDownloadResponse? Execute(
            this SingleAdminGetContent.SingleAdminGetContentBuilder builder,
            string namespace_
        )
        {
            SingleAdminGetContent op = builder.Build(
                namespace_
            );

            return ((AdminContent)builder.WrapperObject!).SingleAdminGetContent(op);
        }

        public static Model.ModelsPaginatedContentDownloadResponse? Execute(
            this AdminSearchContent.AdminSearchContentBuilder builder,
            string namespace_
        )
        {
            AdminSearchContent op = builder.Build(
                namespace_
            );

            return ((AdminContent)builder.WrapperObject!).AdminSearchContent(op);
        }

        public static Model.ModelsContentDownloadResponse? Execute(
            this AdminGetSpecificContent.AdminGetSpecificContentBuilder builder,
            string contentId,
            string namespace_
        )
        {
            AdminGetSpecificContent op = builder.Build(
                contentId,
                namespace_
            );

            return ((AdminContent)builder.WrapperObject!).AdminGetSpecificContent(op);
        }

        public static Model.ModelsGetContentPreviewResponse? Execute(
            this AdminDownloadContentPreview.AdminDownloadContentPreviewBuilder builder,
            string contentId,
            string namespace_
        )
        {
            AdminDownloadContentPreview op = builder.Build(
                contentId,
                namespace_
            );

            return ((AdminContent)builder.WrapperObject!).AdminDownloadContentPreview(op);
        }

        public static Model.ModelsUpdateScreenshotResponse? Execute(
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

            return ((AdminContent)builder.WrapperObject!).AdminUpdateScreenshots(op);
        }

        public static Model.ModelsCreateScreenshotResponse? Execute(
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

            return ((AdminContent)builder.WrapperObject!).AdminUploadContentScreenshot(op);
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

            ((AdminContent)builder.WrapperObject!).AdminDeleteContentScreenshot(op);
        }

        public static Model.ModelsCreateContentResponse? Execute(
            this AdminUpdateContentS3.AdminUpdateContentS3Builder builder,
            ModelsCreateContentRequestS3 body,
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

            return ((AdminContent)builder.WrapperObject!).AdminUpdateContentS3(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsCreateContentResponse? Execute(
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

            return ((AdminContent)builder.WrapperObject!).AdminUpdateContentDirect(op);
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

            ((AdminContent)builder.WrapperObject!).AdminDeleteContent(op);
        }

        public static Model.ModelsPaginatedContentDownloadResponse? Execute(
            this AdminGetContent.AdminGetContentBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetContent op = builder.Build(
                namespace_,
                userId
            );

            return ((AdminContent)builder.WrapperObject!).AdminGetContent(op);
        }

        public static Model.ModelsCreateContentResponse? Execute(
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

            return ((AdminContent)builder.WrapperObject!).AdminHideUserContent(op);
        }

    }
}