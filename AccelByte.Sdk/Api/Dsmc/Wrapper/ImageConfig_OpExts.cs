// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class DsmcImageConfig_OpExts
    {
        public static void Execute(
            this UpdateImage.UpdateImageBuilder builder,
            ModelsImageRecordUpdate body
        )
        {
            UpdateImage op = builder.Build(
                body
            );

            ((Dsmc.Wrapper.ImageConfig)builder.WrapperObject!).UpdateImage(op);
        }
        public static void Execute(
            this CreateImage.CreateImageBuilder builder,
            ModelsCreateImageRequest body
        )
        {
            CreateImage op = builder.Build(
                body
            );

            ((Dsmc.Wrapper.ImageConfig)builder.WrapperObject!).CreateImage(op);
        }
        public static Dsmc.Model.ModelsImportResponse? Execute(
            this ImportImages.ImportImagesBuilder builder,
            Stream file
        )
        {
            ImportImages op = builder.Build(
                file
            );

            return ((Dsmc.Wrapper.ImageConfig)builder.WrapperObject!).ImportImages(op);
        }
        public static void Execute(
            this CreateImagePatch.CreateImagePatchBuilder builder,
            ModelsCreateImagePatchRequest body
        )
        {
            CreateImagePatch op = builder.Build(
                body
            );

            ((Dsmc.Wrapper.ImageConfig)builder.WrapperObject!).CreateImagePatch(op);
        }
        public static Dsmc.Model.ModelsListImageResponse? Execute(
            this ListImages.ListImagesBuilder builder,
            string namespace_,
            long count,
            long offset
        )
        {
            ListImages op = builder.Build(
                namespace_,
                count,
                offset
            );

            return ((Dsmc.Wrapper.ImageConfig)builder.WrapperObject!).ListImages(op);
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

            ((Dsmc.Wrapper.ImageConfig)builder.WrapperObject!).DeleteImage(op);
        }
        public static List<Dsmc.Model.ModelsImageRecord>? Execute(
            this ExportImages.ExportImagesBuilder builder,
            string namespace_
        )
        {
            ExportImages op = builder.Build(
                namespace_
            );

            return ((Dsmc.Wrapper.ImageConfig)builder.WrapperObject!).ExportImages(op);
        }
        public static Dsmc.Model.ModelsGetImageLimitResponse? Execute(
            this GetImageLimit.GetImageLimitBuilder builder,
            string namespace_
        )
        {
            GetImageLimit op = builder.Build(
                namespace_
            );

            return ((Dsmc.Wrapper.ImageConfig)builder.WrapperObject!).GetImageLimit(op);
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

            ((Dsmc.Wrapper.ImageConfig)builder.WrapperObject!).DeleteImagePatch(op);
        }
        public static Dsmc.Model.ModelsGetImageDetailResponse? Execute(
            this GetImageDetail.GetImageDetailBuilder builder,
            string namespace_,
            string version
        )
        {
            GetImageDetail op = builder.Build(
                namespace_,
                version
            );

            return ((Dsmc.Wrapper.ImageConfig)builder.WrapperObject!).GetImageDetail(op);
        }
        public static Dsmc.Model.ModelsListImagePatchesResponse? Execute(
            this GetImagePatches.GetImagePatchesBuilder builder,
            string namespace_,
            string version
        )
        {
            GetImagePatches op = builder.Build(
                namespace_,
                version
            );

            return ((Dsmc.Wrapper.ImageConfig)builder.WrapperObject!).GetImagePatches(op);
        }
        public static Dsmc.Model.ModelsGetImagePatchDetailResponse? Execute(
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

            return ((Dsmc.Wrapper.ImageConfig)builder.WrapperObject!).GetImagePatchDetail(op);
        }
        public static Dsmc.Model.ModelsRepositoryRecord? Execute(
            this GetRepository.GetRepositoryBuilder builder,
            string namespace_
        )
        {
            GetRepository op = builder.Build(
                namespace_
            );

            return ((Dsmc.Wrapper.ImageConfig)builder.WrapperObject!).GetRepository(op);
        }
        public static void Execute(
            this CreateRepository.CreateRepositoryBuilder builder,
            ModelsCreateRepositoryRequest body
        )
        {
            CreateRepository op = builder.Build(
                body
            );

            ((Dsmc.Wrapper.ImageConfig)builder.WrapperObject!).CreateRepository(op);
        }
        public static Dsmc.Model.ModelsListImageResponse? Execute(
            this ListImagesClient.ListImagesClientBuilder builder,
            string namespace_
        )
        {
            ListImagesClient op = builder.Build(
                namespace_
            );

            return ((Dsmc.Wrapper.ImageConfig)builder.WrapperObject!).ListImagesClient(op);
        }
        public static Dsmc.Model.ModelsGetImageLimitResponse? Execute(
            this ImageLimitClient.ImageLimitClientBuilder builder,
            string namespace_
        )
        {
            ImageLimitClient op = builder.Build(
                namespace_
            );

            return ((Dsmc.Wrapper.ImageConfig)builder.WrapperObject!).ImageLimitClient(op);
        }
        public static Dsmc.Model.ModelsGetImageDetailResponse? Execute(
            this ImageDetailClient.ImageDetailClientBuilder builder,
            string namespace_,
            string version
        )
        {
            ImageDetailClient op = builder.Build(
                namespace_,
                version
            );

            return ((Dsmc.Wrapper.ImageConfig)builder.WrapperObject!).ImageDetailClient(op);
        }
    }
}