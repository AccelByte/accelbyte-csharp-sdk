// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;
using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class BasicFileUpload_OpExts
    {
        public static Basic.Model.FileUploadUrlInfo? Execute(
            this GeneratedUploadUrl.GeneratedUploadUrlBuilder builder,
            string folder,
            string namespace_,
            string fileType
        )
        {
            GeneratedUploadUrl op = builder.Build(
                folder,
                namespace_,
                fileType
            );

            return ((Basic.Wrapper.FileUpload)builder.WrapperObject!).GeneratedUploadUrl(op);
        }

        public static Basic.Model.FileUploadUrlInfo? Execute(
            this GeneratedUserUploadContentUrl.GeneratedUserUploadContentUrlBuilder builder,
            string namespace_,
            string userId,
            string fileType
        )
        {
            GeneratedUserUploadContentUrl op = builder.Build(
                namespace_,
                userId,
                fileType
            );

            return ((Basic.Wrapper.FileUpload)builder.WrapperObject!).GeneratedUserUploadContentUrl(op);
        }

        public static Basic.Model.FileUploadUrlInfo? Execute(
            this PublicGeneratedUploadUrl.PublicGeneratedUploadUrlBuilder builder,
            string folder,
            string namespace_,
            string fileType
        )
        {
            PublicGeneratedUploadUrl op = builder.Build(
                folder,
                namespace_,
                fileType
            );

            return ((Basic.Wrapper.FileUpload)builder.WrapperObject!).PublicGeneratedUploadUrl(op);
        }

        public static Basic.Model.FileUploadUrlInfo? Execute(
            this PublicGeneratedUserUploadContentUrl.PublicGeneratedUserUploadContentUrlBuilder builder,
            string namespace_,
            string userId,
            string fileType
        )
        {
            PublicGeneratedUserUploadContentUrl op = builder.Build(
                namespace_,
                userId,
                fileType
            );

            return ((Basic.Wrapper.FileUpload)builder.WrapperObject!).PublicGeneratedUserUploadContentUrl(op);
        }

    }
}