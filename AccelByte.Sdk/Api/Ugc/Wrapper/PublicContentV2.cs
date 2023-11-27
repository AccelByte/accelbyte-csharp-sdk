// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class PublicContentV2
    {
        private readonly AccelByteSDK _sdk;

        public PublicContentV2(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public PublicGetContentByChannelIDV2.PublicGetContentByChannelIDV2Builder PublicGetContentByChannelIDV2Op
        {
            get { return Operation.PublicGetContentByChannelIDV2.Builder.SetWrapperObject(this); }
        }
        public PublicListContentV2.PublicListContentV2Builder PublicListContentV2Op
        {
            get { return Operation.PublicListContentV2.Builder.SetWrapperObject(this); }
        }
        public PublicBulkGetContentByIDV2.PublicBulkGetContentByIDV2Builder PublicBulkGetContentByIDV2Op
        {
            get { return Operation.PublicBulkGetContentByIDV2.Builder.SetWrapperObject(this); }
        }
        public PublicGetContentBulkByShareCodesV2.PublicGetContentBulkByShareCodesV2Builder PublicGetContentBulkByShareCodesV2Op
        {
            get { return Operation.PublicGetContentBulkByShareCodesV2.Builder.SetWrapperObject(this); }
        }
        public PublicGetContentByShareCodeV2.PublicGetContentByShareCodeV2Builder PublicGetContentByShareCodeV2Op
        {
            get { return Operation.PublicGetContentByShareCodeV2.Builder.SetWrapperObject(this); }
        }
        public PublicGetContentByIDV2.PublicGetContentByIDV2Builder PublicGetContentByIDV2Op
        {
            get { return Operation.PublicGetContentByIDV2.Builder.SetWrapperObject(this); }
        }
        public PublicCreateContentV2.PublicCreateContentV2Builder PublicCreateContentV2Op
        {
            get { return Operation.PublicCreateContentV2.Builder.SetWrapperObject(this); }
        }
        public PublicUpdateContentByShareCodeV2.PublicUpdateContentByShareCodeV2Builder PublicUpdateContentByShareCodeV2Op
        {
            get { return Operation.PublicUpdateContentByShareCodeV2.Builder.SetWrapperObject(this); }
        }
        public PublicDeleteContentByShareCodeV2.PublicDeleteContentByShareCodeV2Builder PublicDeleteContentByShareCodeV2Op
        {
            get { return Operation.PublicDeleteContentByShareCodeV2.Builder.SetWrapperObject(this); }
        }
        public PublicDeleteContentV2.PublicDeleteContentV2Builder PublicDeleteContentV2Op
        {
            get { return Operation.PublicDeleteContentV2.Builder.SetWrapperObject(this); }
        }
        public PublicUpdateContentV2.PublicUpdateContentV2Builder PublicUpdateContentV2Op
        {
            get { return Operation.PublicUpdateContentV2.Builder.SetWrapperObject(this); }
        }
        public PublicUpdateContentFileLocation.PublicUpdateContentFileLocationBuilder PublicUpdateContentFileLocationOp
        {
            get { return Operation.PublicUpdateContentFileLocation.Builder.SetWrapperObject(this); }
        }
        public UpdateContentShareCodeV2.UpdateContentShareCodeV2Builder UpdateContentShareCodeV2Op
        {
            get { return Operation.UpdateContentShareCodeV2.Builder.SetWrapperObject(this); }
        }
        public PublicGenerateContentUploadURLV2.PublicGenerateContentUploadURLV2Builder PublicGenerateContentUploadURLV2Op
        {
            get { return Operation.PublicGenerateContentUploadURLV2.Builder.SetWrapperObject(this); }
        }
        public PublicGetContentByUserIDV2.PublicGetContentByUserIDV2Builder PublicGetContentByUserIDV2Op
        {
            get { return Operation.PublicGetContentByUserIDV2.Builder.SetWrapperObject(this); }
        }
        public UpdateScreenshotsV2.UpdateScreenshotsV2Builder UpdateScreenshotsV2Op
        {
            get { return Operation.UpdateScreenshotsV2.Builder.SetWrapperObject(this); }
        }
        public UploadContentScreenshotV2.UploadContentScreenshotV2Builder UploadContentScreenshotV2Op
        {
            get { return Operation.UploadContentScreenshotV2.Builder.SetWrapperObject(this); }
        }
        public DeleteContentScreenshotV2.DeleteContentScreenshotV2Builder DeleteContentScreenshotV2Op
        {
            get { return Operation.DeleteContentScreenshotV2.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsPaginatedContentDownloadResponseV2? PublicGetContentByChannelIDV2(PublicGetContentByChannelIDV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponseV2? PublicListContentV2(PublicListContentV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsContentDownloadResponseV2>? PublicBulkGetContentByIDV2(PublicBulkGetContentByIDV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public List<Model.ModelsContentDownloadResponseV2<T1>>? PublicBulkGetContentByIDV2<T1>(PublicBulkGetContentByIDV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsContentDownloadResponseV2>? PublicGetContentBulkByShareCodesV2(PublicGetContentBulkByShareCodesV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public List<Model.ModelsContentDownloadResponseV2<T1>>? PublicGetContentBulkByShareCodesV2<T1>(PublicGetContentBulkByShareCodesV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsContentDownloadResponseV2? PublicGetContentByShareCodeV2(PublicGetContentByShareCodeV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsContentDownloadResponseV2<T1>? PublicGetContentByShareCodeV2<T1>(PublicGetContentByShareCodeV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsContentDownloadResponseV2? PublicGetContentByIDV2(PublicGetContentByIDV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsContentDownloadResponseV2<T1>? PublicGetContentByIDV2<T1>(PublicGetContentByIDV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateContentResponseV2? PublicCreateContentV2(PublicCreateContentV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsCreateContentResponseV2<T1>? PublicCreateContentV2<T1>(PublicCreateContentV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateContentResponseV2? PublicUpdateContentByShareCodeV2(PublicUpdateContentByShareCodeV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsCreateContentResponseV2<T1>? PublicUpdateContentByShareCodeV2<T1>(PublicUpdateContentByShareCodeV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicDeleteContentByShareCodeV2(PublicDeleteContentByShareCodeV2 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicDeleteContentV2(PublicDeleteContentV2 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateContentResponseV2? PublicUpdateContentV2(PublicUpdateContentV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsUpdateContentResponseV2<T1>? PublicUpdateContentV2<T1>(PublicUpdateContentV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateContentResponseV2? PublicUpdateContentFileLocation(PublicUpdateContentFileLocation input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsUpdateContentResponseV2<T1>? PublicUpdateContentFileLocation<T1>(PublicUpdateContentFileLocation input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateContentResponseV2? UpdateContentShareCodeV2(UpdateContentShareCodeV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsCreateContentResponseV2<T1>? UpdateContentShareCodeV2<T1>(UpdateContentShareCodeV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGenerateContentUploadURLResponse? PublicGenerateContentUploadURLV2(PublicGenerateContentUploadURLV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponseV2? PublicGetContentByUserIDV2(PublicGetContentByUserIDV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateScreenshotResponse? UpdateScreenshotsV2(UpdateScreenshotsV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateScreenshotResponse? UploadContentScreenshotV2(UploadContentScreenshotV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteContentScreenshotV2(DeleteContentScreenshotV2 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}