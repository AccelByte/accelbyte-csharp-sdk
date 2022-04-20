// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Dsmc.Wrapper
{
    public class ImageConfig
    {
        private readonly AccelByteSDK _sdk;

        public ImageConfig(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public UpdateImage.UpdateImageBuilder UpdateImageOp
        {
            get { return Operation.UpdateImage.Builder.SetWrapperObject(this); }
        }
        public CreateImage.CreateImageBuilder CreateImageOp
        {
            get { return Operation.CreateImage.Builder.SetWrapperObject(this); }
        }
        public ImportImages.ImportImagesBuilder ImportImagesOp
        {
            get { return Operation.ImportImages.Builder.SetWrapperObject(this); }
        }
        public CreateImagePatch.CreateImagePatchBuilder CreateImagePatchOp
        {
            get { return Operation.CreateImagePatch.Builder.SetWrapperObject(this); }
        }
        public ListImages.ListImagesBuilder ListImagesOp
        {
            get { return Operation.ListImages.Builder.SetWrapperObject(this); }
        }
        public DeleteImage.DeleteImageBuilder DeleteImageOp
        {
            get { return Operation.DeleteImage.Builder.SetWrapperObject(this); }
        }
        public ExportImages.ExportImagesBuilder ExportImagesOp
        {
            get { return Operation.ExportImages.Builder.SetWrapperObject(this); }
        }
        public GetImageLimit.GetImageLimitBuilder GetImageLimitOp
        {
            get { return Operation.GetImageLimit.Builder.SetWrapperObject(this); }
        }
        public DeleteImagePatch.DeleteImagePatchBuilder DeleteImagePatchOp
        {
            get { return Operation.DeleteImagePatch.Builder.SetWrapperObject(this); }
        }
        public GetImageDetail.GetImageDetailBuilder GetImageDetailOp
        {
            get { return Operation.GetImageDetail.Builder.SetWrapperObject(this); }
        }
        public GetImagePatches.GetImagePatchesBuilder GetImagePatchesOp
        {
            get { return Operation.GetImagePatches.Builder.SetWrapperObject(this); }
        }
        public GetImagePatchDetail.GetImagePatchDetailBuilder GetImagePatchDetailOp
        {
            get { return Operation.GetImagePatchDetail.Builder.SetWrapperObject(this); }
        }
        public ImageDetailClient.ImageDetailClientBuilder ImageDetailClientOp
        {
            get { return Operation.ImageDetailClient.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public void UpdateImage(UpdateImage input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void CreateImage(CreateImage input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsImportResponse? ImportImages(ImportImages input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void CreateImagePatch(CreateImagePatch input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListImageResponse? ListImages(ListImages input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteImage(DeleteImage input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsImageRecord>? ExportImages(ExportImages input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetImageLimitResponse? GetImageLimit(GetImageLimit input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteImagePatch(DeleteImagePatch input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetImageDetailResponse? GetImageDetail(GetImageDetail input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListImagePatchesResponse? GetImagePatches(GetImagePatches input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetImagePatchDetailResponse? GetImagePatchDetail(GetImagePatchDetail input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetImageDetailResponse? ImageDetailClient(ImageDetailClient input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class ImageConfig_OperationExtensions
    {
        public static void Execute(
            this UpdateImage.UpdateImageBuilder builder,
            ModelsImageRecordUpdate body
        )
        {
            UpdateImage op = builder.Build(
                body
            );

            ((ImageConfig)builder.WrapperObject!).UpdateImage(op);
        }

        public static void Execute(
            this CreateImage.CreateImageBuilder builder,
            ModelsCreateImageRequest body
        )
        {
            CreateImage op = builder.Build(
                body
            );

            ((ImageConfig)builder.WrapperObject!).CreateImage(op);
        }

        public static Model.ModelsImportResponse? Execute(
            this ImportImages.ImportImagesBuilder builder,
            Stream file
        )
        {
            ImportImages op = builder.Build(
                file
            );

            return ((ImageConfig)builder.WrapperObject!).ImportImages(op);
        }

        public static void Execute(
            this CreateImagePatch.CreateImagePatchBuilder builder,
            ModelsCreateImagePatchRequest body
        )
        {
            CreateImagePatch op = builder.Build(
                body
            );

            ((ImageConfig)builder.WrapperObject!).CreateImagePatch(op);
        }

        public static Model.ModelsListImageResponse? Execute(
            this ListImages.ListImagesBuilder builder,
            string namespace_
        )
        {
            ListImages op = builder.Build(
                namespace_
            );

            return ((ImageConfig)builder.WrapperObject!).ListImages(op);
        }

        public static void Execute(
            this DeleteImage.DeleteImageBuilder builder,
            string namespace_,
            string imageURI,
            string version
        )
        {
            DeleteImage op = builder.Build(
                namespace_,
                imageURI,
                version
            );

            ((ImageConfig)builder.WrapperObject!).DeleteImage(op);
        }

        public static List<Model.ModelsImageRecord>? Execute(
            this ExportImages.ExportImagesBuilder builder,
            string namespace_
        )
        {
            ExportImages op = builder.Build(
                namespace_
            );

            return ((ImageConfig)builder.WrapperObject!).ExportImages(op);
        }

        public static Model.ModelsGetImageLimitResponse? Execute(
            this GetImageLimit.GetImageLimitBuilder builder,
            string namespace_
        )
        {
            GetImageLimit op = builder.Build(
                namespace_
            );

            return ((ImageConfig)builder.WrapperObject!).GetImageLimit(op);
        }

        public static void Execute(
            this DeleteImagePatch.DeleteImagePatchBuilder builder,
            string namespace_,
            string imageURI,
            string version,
            string versionPatch
        )
        {
            DeleteImagePatch op = builder.Build(
                namespace_,
                imageURI,
                version,
                versionPatch
            );

            ((ImageConfig)builder.WrapperObject!).DeleteImagePatch(op);
        }

        public static Model.ModelsGetImageDetailResponse? Execute(
            this GetImageDetail.GetImageDetailBuilder builder,
            string namespace_,
            string version
        )
        {
            GetImageDetail op = builder.Build(
                namespace_,
                version
            );

            return ((ImageConfig)builder.WrapperObject!).GetImageDetail(op);
        }

        public static Model.ModelsListImagePatchesResponse? Execute(
            this GetImagePatches.GetImagePatchesBuilder builder,
            string namespace_,
            string version
        )
        {
            GetImagePatches op = builder.Build(
                namespace_,
                version
            );

            return ((ImageConfig)builder.WrapperObject!).GetImagePatches(op);
        }

        public static Model.ModelsGetImagePatchDetailResponse? Execute(
            this GetImagePatchDetail.GetImagePatchDetailBuilder builder,
            string namespace_,
            string version,
            string versionPatch
        )
        {
            GetImagePatchDetail op = builder.Build(
                namespace_,
                version,
                versionPatch
            );

            return ((ImageConfig)builder.WrapperObject!).GetImagePatchDetail(op);
        }

        public static Model.ModelsGetImageDetailResponse? Execute(
            this ImageDetailClient.ImageDetailClientBuilder builder,
            string namespace_,
            string version
        )
        {
            ImageDetailClient op = builder.Build(
                namespace_,
                version
            );

            return ((ImageConfig)builder.WrapperObject!).ImageDetailClient(op);
        }

    }
}