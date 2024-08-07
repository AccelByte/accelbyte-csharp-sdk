// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Api.Ams.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ams.Wrapper
{
    public class Images
    {
        private readonly AccelByteSDK _sdk;

        public Images(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ImageList.ImageListBuilder ImageListOp
        {
            get { return Operation.ImageList.Builder.SetWrapperObject(this); }
        }
        public ImagesStorage.ImagesStorageBuilder ImagesStorageOp
        {
            get { return Operation.ImagesStorage.Builder.SetWrapperObject(this); }
        }
        public ImageGet.ImageGetBuilder ImageGetOp
        {
            get { return Operation.ImageGet.Builder.SetWrapperObject(this); }
        }
        public ImageMarkForDeletion.ImageMarkForDeletionBuilder ImageMarkForDeletionOp
        {
            get { return Operation.ImageMarkForDeletion.Builder.SetWrapperObject(this); }
        }
        public ImagePatch.ImagePatchBuilder ImagePatchOp
        {
            get { return Operation.ImagePatch.Builder.SetWrapperObject(this); }
        }
        public ImageUnmarkForDeletion.ImageUnmarkForDeletionBuilder ImageUnmarkForDeletionOp
        {
            get { return Operation.ImageUnmarkForDeletion.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ApiImageList? ImageList(ImageList input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiImageList?> ImageListAsync(ImageList input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiImageStorage? ImagesStorage(ImagesStorage input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiImageStorage?> ImagesStorageAsync(ImagesStorage input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiImageDetails? ImageGet(ImageGet input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiImageDetails?> ImageGetAsync(ImageGet input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void ImageMarkForDeletion(ImageMarkForDeletion input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task ImageMarkForDeletionAsync(ImageMarkForDeletion input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiImageDetails? ImagePatch(ImagePatch input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiImageDetails?> ImagePatchAsync(ImagePatch input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void ImageUnmarkForDeletion(ImageUnmarkForDeletion input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task ImageUnmarkForDeletionAsync(ImageUnmarkForDeletion input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}