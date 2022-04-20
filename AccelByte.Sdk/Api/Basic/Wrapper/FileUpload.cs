// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Basic.Wrapper
{
    public class FileUpload
    {
        private readonly AccelByteSDK _sdk;

        public FileUpload(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GeneratedUploadUrl.GeneratedUploadUrlBuilder GeneratedUploadUrlOp
        {
            get { return Operation.GeneratedUploadUrl.Builder.SetWrapperObject(this); }
        }
        public GeneratedUserUploadContentUrl.GeneratedUserUploadContentUrlBuilder GeneratedUserUploadContentUrlOp
        {
            get { return Operation.GeneratedUserUploadContentUrl.Builder.SetWrapperObject(this); }
        }
        public PublicGeneratedUploadUrl.PublicGeneratedUploadUrlBuilder PublicGeneratedUploadUrlOp
        {
            get { return Operation.PublicGeneratedUploadUrl.Builder.SetWrapperObject(this); }
        }
        public PublicGeneratedUserUploadContentUrl.PublicGeneratedUserUploadContentUrlBuilder PublicGeneratedUserUploadContentUrlOp
        {
            get { return Operation.PublicGeneratedUserUploadContentUrl.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.FileUploadUrlInfo? GeneratedUploadUrl(GeneratedUploadUrl input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FileUploadUrlInfo? GeneratedUserUploadContentUrl(GeneratedUserUploadContentUrl input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FileUploadUrlInfo? PublicGeneratedUploadUrl(PublicGeneratedUploadUrl input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FileUploadUrlInfo? PublicGeneratedUserUploadContentUrl(PublicGeneratedUserUploadContentUrl input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class FileUpload_OperationExtensions
    {
        public static Model.FileUploadUrlInfo? Execute(
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

            return ((FileUpload)builder.WrapperObject!).GeneratedUploadUrl(op);
        }

        public static Model.FileUploadUrlInfo? Execute(
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

            return ((FileUpload)builder.WrapperObject!).GeneratedUserUploadContentUrl(op);
        }

        public static Model.FileUploadUrlInfo? Execute(
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

            return ((FileUpload)builder.WrapperObject!).PublicGeneratedUploadUrl(op);
        }

        public static Model.FileUploadUrlInfo? Execute(
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

            return ((FileUpload)builder.WrapperObject!).PublicGeneratedUserUploadContentUrl(op);
        }

    }
}