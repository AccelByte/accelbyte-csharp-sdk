// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
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
        public AdminGetUserContentByShareCode.AdminGetUserContentByShareCodeBuilder AdminGetUserContentByShareCodeOp
        {
            get { return Operation.AdminGetUserContentByShareCode.Builder.SetWrapperObject(this); }
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
        public Model.ModelsContentDownloadResponse? AdminGetUserContentByShareCode(AdminGetUserContentByShareCode input) {
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
}