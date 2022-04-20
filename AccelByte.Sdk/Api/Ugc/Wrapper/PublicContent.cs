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
}