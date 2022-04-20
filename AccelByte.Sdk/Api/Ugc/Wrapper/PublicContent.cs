// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class PublicContent
    {
        private readonly AccelByteSDK _sdk;

        public PublicContent(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public SearchChannelSpecificContent.SearchChannelSpecificContentBuilder SearchChannelSpecificContentOp
        {
            get { return Operation.SearchChannelSpecificContent.Builder.SetWrapperObject(this); }
        }
        public PublicSearchContent.PublicSearchContentBuilder PublicSearchContentOp
        {
            get { return Operation.PublicSearchContent.Builder.SetWrapperObject(this); }
        }
        public PublicGetContentBulk.PublicGetContentBulkBuilder PublicGetContentBulkOp
        {
            get { return Operation.PublicGetContentBulk.Builder.SetWrapperObject(this); }
        }
        public DownloadContentByShareCode.DownloadContentByShareCodeBuilder DownloadContentByShareCodeOp
        {
            get { return Operation.DownloadContentByShareCode.Builder.SetWrapperObject(this); }
        }
        public PublicDownloadContentByContentID.PublicDownloadContentByContentIDBuilder PublicDownloadContentByContentIDOp
        {
            get { return Operation.PublicDownloadContentByContentID.Builder.SetWrapperObject(this); }
        }
        public PublicDownloadContentPreview.PublicDownloadContentPreviewBuilder PublicDownloadContentPreviewOp
        {
            get { return Operation.PublicDownloadContentPreview.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public CreateContentDirect.CreateContentDirectBuilder CreateContentDirectOp
        {
            get { return Operation.CreateContentDirect.Builder.SetWrapperObject(this); }
        }
        public CreateContentS3.CreateContentS3Builder CreateContentS3Op
        {
            get { return Operation.CreateContentS3.Builder.SetWrapperObject(this); }
        }
        public UpdateContentS3.UpdateContentS3Builder UpdateContentS3Op
        {
            get { return Operation.UpdateContentS3.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public UpdateContentDirect.UpdateContentDirectBuilder UpdateContentDirectOp
        {
            get { return Operation.UpdateContentDirect.Builder.SetWrapperObject(this); }
        }
        public DeleteContent.DeleteContentBuilder DeleteContentOp
        {
            get { return Operation.DeleteContent.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserContent.PublicGetUserContentBuilder PublicGetUserContentOp
        {
            get { return Operation.PublicGetUserContent.Builder.SetWrapperObject(this); }
        }
        public UpdateScreenshots.UpdateScreenshotsBuilder UpdateScreenshotsOp
        {
            get { return Operation.UpdateScreenshots.Builder.SetWrapperObject(this); }
        }
        public UploadContentScreenshot.UploadContentScreenshotBuilder UploadContentScreenshotOp
        {
            get { return Operation.UploadContentScreenshot.Builder.SetWrapperObject(this); }
        }
        public DeleteContentScreenshot.DeleteContentScreenshotBuilder DeleteContentScreenshotOp
        {
            get { return Operation.DeleteContentScreenshot.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsPaginatedContentDownloadResponse? SearchChannelSpecificContent(SearchChannelSpecificContent input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponse? PublicSearchContent(PublicSearchContent input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsContentDownloadResponse>? PublicGetContentBulk(PublicGetContentBulk input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsContentDownloadResponse? DownloadContentByShareCode(DownloadContentByShareCode input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsContentDownloadResponse? PublicDownloadContentByContentID(PublicDownloadContentByContentID input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetContentPreviewResponse? PublicDownloadContentPreview(PublicDownloadContentPreview input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsCreateContentResponse? CreateContentDirect(CreateContentDirect input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public Model.ModelsCreateContentResponse? CreateContentS3(CreateContentS3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateContentResponse? UpdateContentS3(UpdateContentS3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsCreateContentResponse? UpdateContentDirect(UpdateContentDirect input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public void DeleteContent(DeleteContent input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponse? PublicGetUserContent(PublicGetUserContent input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateScreenshotResponse? UpdateScreenshots(UpdateScreenshots input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateScreenshotResponse? UploadContentScreenshot(UploadContentScreenshot input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteContentScreenshot(DeleteContentScreenshot input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class PublicContent_OperationExtensions
    {
        public static Model.ModelsPaginatedContentDownloadResponse? Execute(
            this SearchChannelSpecificContent.SearchChannelSpecificContentBuilder builder,
            string channelId,
            string namespace_
        )
        {
            SearchChannelSpecificContent op = builder.Build(
                channelId,
                namespace_
            );

            return ((PublicContent)builder.WrapperObject!).SearchChannelSpecificContent(op);
        }

        public static Model.ModelsPaginatedContentDownloadResponse? Execute(
            this PublicSearchContent.PublicSearchContentBuilder builder,
            string namespace_
        )
        {
            PublicSearchContent op = builder.Build(
                namespace_
            );

            return ((PublicContent)builder.WrapperObject!).PublicSearchContent(op);
        }

        public static List<Model.ModelsContentDownloadResponse>? Execute(
            this PublicGetContentBulk.PublicGetContentBulkBuilder builder,
            ModelsPublicGetContentBulkRequest body,
            string namespace_
        )
        {
            PublicGetContentBulk op = builder.Build(
                body,
                namespace_
            );

            return ((PublicContent)builder.WrapperObject!).PublicGetContentBulk(op);
        }

        public static Model.ModelsContentDownloadResponse? Execute(
            this DownloadContentByShareCode.DownloadContentByShareCodeBuilder builder,
            string namespace_,
            string shareCode
        )
        {
            DownloadContentByShareCode op = builder.Build(
                namespace_,
                shareCode
            );

            return ((PublicContent)builder.WrapperObject!).DownloadContentByShareCode(op);
        }

        public static Model.ModelsContentDownloadResponse? Execute(
            this PublicDownloadContentByContentID.PublicDownloadContentByContentIDBuilder builder,
            string contentId,
            string namespace_
        )
        {
            PublicDownloadContentByContentID op = builder.Build(
                contentId,
                namespace_
            );

            return ((PublicContent)builder.WrapperObject!).PublicDownloadContentByContentID(op);
        }

        public static Model.ModelsGetContentPreviewResponse? Execute(
            this PublicDownloadContentPreview.PublicDownloadContentPreviewBuilder builder,
            string contentId,
            string namespace_
        )
        {
            PublicDownloadContentPreview op = builder.Build(
                contentId,
                namespace_
            );

            return ((PublicContent)builder.WrapperObject!).PublicDownloadContentPreview(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsCreateContentResponse? Execute(
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

            return ((PublicContent)builder.WrapperObject!).CreateContentDirect(op);
        }

        public static Model.ModelsCreateContentResponse? Execute(
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

            return ((PublicContent)builder.WrapperObject!).CreateContentS3(op);
        }

        public static Model.ModelsCreateContentResponse? Execute(
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

            return ((PublicContent)builder.WrapperObject!).UpdateContentS3(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsCreateContentResponse? Execute(
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

            return ((PublicContent)builder.WrapperObject!).UpdateContentDirect(op);
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

            ((PublicContent)builder.WrapperObject!).DeleteContent(op);
        }

        public static Model.ModelsPaginatedContentDownloadResponse? Execute(
            this PublicGetUserContent.PublicGetUserContentBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserContent op = builder.Build(
                namespace_,
                userId
            );

            return ((PublicContent)builder.WrapperObject!).PublicGetUserContent(op);
        }

        public static Model.ModelsUpdateScreenshotResponse? Execute(
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

            return ((PublicContent)builder.WrapperObject!).UpdateScreenshots(op);
        }

        public static Model.ModelsCreateScreenshotResponse? Execute(
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

            return ((PublicContent)builder.WrapperObject!).UploadContentScreenshot(op);
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

            ((PublicContent)builder.WrapperObject!).DeleteContentScreenshot(op);
        }

    }
}